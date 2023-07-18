using System;
using System.Windows.Forms;
using C7D2C.Classes;

namespace C7D2C.Menus
{
    public partial class AimbotMenu : Form
    {
        public AimbotMenu()
        {
            InitializeComponent();
            TopMost = true;
            ShowInTaskbar = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AimbotMenu_Load(object sender, EventArgs e)
        {
            DisabledEntitiesListView.Items.Add("Player");
            DisabledEntitiesListView.Items.Add("Animal");

            EnabledEntitesListView.Items.Add("Zombie");
            EnabledEntitesListView.Items.Add("Enemy Animal");

            InitValues();
        }

        private void InitValues()
        {
            CurrentDistanceLabel.Text = $@"Current: {DistanceSlider.Value}";
            CurrentFOVSizeLabel.Text = $@"Current: {FOVSlider.Value}";

            Aimbot.AimbotDistance = DistanceSlider.Value;
            Aimbot.AimbotFovDistance = HandleFovSlider(FOVSlider.Value);
        }

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            var selectedOption = DisabledEntitiesListView.FocusedItem;
            if (selectedOption == null)
            {
                if (DisabledEntitiesListView.Items.Count <= 0) return;
                selectedOption = DisabledEntitiesListView.Items[0];
            }
            EnabledEntitesListView.Items.Add(selectedOption.Text);
            DisabledEntitiesListView.Items.Remove(selectedOption);
        }

        private void RemoveEntityButton_Click(object sender, EventArgs e)
        {
            var selectedOption = EnabledEntitesListView.FocusedItem;
            if (selectedOption == null)
            {
                if (EnabledEntitesListView.Items.Count <= 0) return;
                selectedOption = EnabledEntitesListView.Items[0];
            }
            DisabledEntitiesListView.Items.Add(selectedOption.Text);
            EnabledEntitesListView.Items.Remove(selectedOption);
        }

        private void DistanceSlider_ValueChanged(object sender, EventArgs e)
        {
            CurrentDistanceLabel.Text = $@"Current: {DistanceSlider.Value}";
            Aimbot.AimbotDistance = DistanceSlider.Value;
        }

        private void FOVSlider_ValueChanged(object sender, EventArgs e)
        {
            CurrentFOVSizeLabel.Text = $@"Current: {FOVSlider.Value}";
            Aimbot.AimbotFovDistance = HandleFovSlider(FOVSlider.Value);
        }

        private float HandleFovSlider(int fovLevel)
        {
            switch (fovLevel)
            {
                case 1:
                    return 25;
                case 2:
                    return 50;
                case 3:
                    return 100;
                case 4:
                    return 150;
                case 5:
                    return 200;
            }
            return 150;
        }
    }
}