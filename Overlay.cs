using System;
using System.Windows.Forms;
using System.Threading;
using JetBrains.Annotations;
using _7DaysToCheat.Classes;
using Application = System.Windows.Forms.Application;
using System.Runtime.InteropServices;
using _7DaysToCheat.Menus;

namespace _7DaysToCheat
{
    public partial class Overlay : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WmNclButtonDown = 0xA1, HtCaption = 0x2;

        [CanBeNull] private static Thread _overlayThread, _espMenuThread;
        [CanBeNull] private static Overlay _instance;
        public static bool IsInitialized;

        [NotNull] public ESPMenu EspMenu = new ESPMenu();

        [CanBeNull]
        public static Overlay GetInstance()
        {
            var creator = _instance;
            if (creator != null)
            {
                return creator;
            }
            return (_instance = new Overlay());
        }

        public Overlay()
        {
            InitializeComponent();
            TopMost = true;

            UnityEngine.Application.quitting += ApplicationOnQuit;
            Application.ApplicationExit += OnApplicationExit;
        }

        private void InjectButton_Click(object sender, EventArgs e)
        {
            Loader.LoadCheats();
        }

        private void EnableFOVAimbotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aimbot.IsFovAimbot = EnableFOVAimbotCheckBox.Checked;
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
        }

        private void ApplicationOnQuit()
        {
            Loader.Unload();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            Loader.Unload();
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