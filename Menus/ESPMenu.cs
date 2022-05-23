using System;
using System.Windows.Forms;
using JetBrains.Annotations;
using Color = System.Drawing.Color;

namespace _7DaysToCheat.Menus
{
    public partial class ESPMenu : Form
    {
        public static UnityEngine.Color EspColor = UnityEngine.Color.green, ApproachingPlayerColor = UnityEngine.Color.red;
        public static UnityEngine.Color ZombieEspColor = UnityEngine.Color.red, PlayerEspColor = UnityEngine.Color.cyan,
            AnimalEspColor = UnityEngine.Color.white;

        public static UnityEngine.Color ZombieChamsColor = UnityEngine.Color.red, PlayerChamsColor = UnityEngine.Color.cyan,
            AnimalChamsColor = UnityEngine.Color.white;
        [CanBeNull] private static ESPMenu _instance;

        [CanBeNull]
        public static ESPMenu GetInstance()
        {
            var creator = _instance;
            if (creator != null)
            {
                return creator;
            }
            return (_instance = new ESPMenu());
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            var selectedOption = DisabledEntitiesListView.FocusedItem;
            EnabledEntitesListView.Items.Add(selectedOption.Text);
            DisabledEntitiesListView.Items.Remove(selectedOption);
        }

        private void RemoveEntityButton_Click(object sender, EventArgs e)
        {
            var selectedOption = EnabledEntitesListView.FocusedItem;
            DisabledEntitiesListView.Items.Add(selectedOption.Text);
            EnabledEntitesListView.Items.Remove(selectedOption);
        }

        public ESPMenu()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
            ColorEditorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                FullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                Color = Color.Green
            };
            if (ColorEditorDialog.ShowDialog() != DialogResult.OK) return;

            var r = ColorEditorDialog.Color.R;
            var g = ColorEditorDialog.Color.G;
            var b = ColorEditorDialog.Color.B;
            var a = ColorEditorDialog.Color.A;

            EspColor = new UnityEngine.Color(r, g, b, a);
            EspColorPanel.BackColor = ColorEditorDialog.Color;
        }

        private void ApproachingPlayerEspButton_Click(object sender, EventArgs e)
        {
            ColorEditorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                FullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                Color = Color.Red
            };
            if (ColorEditorDialog.ShowDialog() != DialogResult.OK) return;

            var r = ColorEditorDialog.Color.R;
            var g = ColorEditorDialog.Color.G;
            var b = ColorEditorDialog.Color.B;
            var a = ColorEditorDialog.Color.A;

            ApproachingPlayerColor = new UnityEngine.Color(r, g, b, a);
            ApproachingPlayerEspColorPanel.BackColor = ColorEditorDialog.Color;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }

        private void ESPMenu_Load(object sender, EventArgs e)
        {
            EspColorPanel.BackColor = Color.Green;
            ApproachingPlayerEspColorPanel.BackColor = Color.Red;

            EspOptionsCheckListBox.Items.Add("Esp Box");
            EspOptionsCheckListBox.Items.Add("Esp CornerBox");
            EspOptionsCheckListBox.Items.Add("Entity Health");
            EspOptionsCheckListBox.Items.Add("Entity Info");
            EspOptionsCheckListBox.Items.Add("Esp Head Circle");
            EspOptionsCheckListBox.SetItemChecked(3, true);

            EntityComboBox.Items.Add("Zombie");
            EntityComboBox.Items.Add("Enemy Animal");
            EntityComboBox.Items.Add("Player");
            EntityComboBox.Items.Add("Animal");

            EntityComboBox.Items.Add("Zombie");
            EntityComboBox.Items.Add("Enemy Animal Chams");
            EntityComboBox.Items.Add("Player Chams");
            EntityComboBox.Items.Add("Animal Chams");

            DisabledEntitiesListView.Items.Add("Player");
            DisabledEntitiesListView.Items.Add("Animal");

            EnabledEntitesListView.Items.Add("Zombie");
            EnabledEntitesListView.Items.Add("Enemy Animal");
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }
    }
}