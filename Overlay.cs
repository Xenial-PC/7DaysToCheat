using System;
using System.Windows.Forms;
using System.Threading;
using JetBrains.Annotations;
using Application = System.Windows.Forms.Application;
using System.Runtime.InteropServices;
using C7D2C.Classes;
using C7D2C.Menus;

namespace C7D2C
{
    public partial class Overlay : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WmNclButtonDown = 0xA1, HtCaption = 0x2;

        [CanBeNull] private static Thread _overlayThread, _espMenuThread;
        [CanBeNull] public static Overlay OverlayInstance;
        public static bool IsInitialized;

        [NotNull] public ESPMenu EspMenu = new ESPMenu();
        [NotNull] public AimbotMenu AimbotMenu = new AimbotMenu();
        [NotNull] public BlockEditorMenu BlockEditor = new BlockEditorMenu();

        [CanBeNull]
        public static Overlay GetInstance()
        {
            var creator = OverlayInstance;
            if (creator != null)
            {
                return creator;
            }
            return (OverlayInstance = new Overlay());
        }

        public Overlay()
        {
            InitializeComponent();
            TopMost = true;
            ShowInTaskbar = false;
        }

        private void InjectButton_Click(object sender, EventArgs e)
        {
            Loader.LoadCheats();
        }

        private void EspButton_Click(object sender, EventArgs e)
        {
            _espMenuThread = new Thread(OpenEspMenu) { IsBackground = true };
            _espMenuThread.Start();
        }

        private void OpenEspMenu()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(EspMenu);
        }

        private void OverlayHandler()
        {
            if (GameManager.Instance.gameStateManager.IsGameStarted() && IsInitialized == false)
            {
                Loader.LoadCheats();
                IsInitialized = true;
            }

            while (true)
            {
                if (!GameManager.Instance.gameStateManager.IsGameStarted())
                {
                    Thread.Sleep(100);
                    Loader.UnloadInGame();
                    IsInitialized = false;
                }
                if (GameManager.Instance.gameStateManager.IsGameStarted() && IsInitialized == false)
                {
                    Loader.LoadCheats();
                    IsInitialized = true;
                }
            }
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            _overlayThread = new Thread(OverlayHandler) { IsBackground = true };
            _overlayThread.Start();

            InitializeMenus();

            ItemNameComboBox.Items.AddRange(GetAllItems.GetAllCurrentItems().ToArray());
        }

        private void InitializeMenus()
        {
            EspMenu.Show();
            EspMenu.Hide();

            AimbotMenu.Show();
            AimbotMenu.Hide();
        }

        private void IsCreativeModeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            PlayerModifer.IsCreativeMode(IsCreativeModeEnabled.Checked);
        }

        private void AimbotButton_Click(object sender, EventArgs e)
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(AimbotMenu);
        }

        private void IsDebugMode_CheckedChanged(object sender, EventArgs e)
        {
            PlayerModifer.IsDebugMode(IsDebugMode.Checked);
        }

        private void IsSpawnMenu_CheckedChanged(object sender, EventArgs e)
        {
            PlayerModifer.IsSpawnWindowShowed(IsSpawnMenu.Checked);
        }

        private void BlockEditorButton_Click(object sender, EventArgs e)
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(BlockEditor);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Loader.UnloadInGame();
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void WeaponModifierButton_Click(object sender, EventArgs e)
        {
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WmNclButtonDown, HtCaption, 0);
        }

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WmNclButtonDown, HtCaption, 0);
        }
    }
}