using System;
using System.Windows.Forms;
using _7DaysToCheat.Classes;

namespace _7DaysToCheat.Menus
{
    public partial class AimbotMenu : Form
    {
        public AimbotMenu()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AimbotMenu_Load(object sender, EventArgs e)
        {
            DisabledEntitiesListView.Items.Add("Player");
            DisabledEntitiesListView.Items.Add("Animal");

            EnabledEntitesListView.Items.Add("Zombie & Enemy Animal");

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
            EnabledEntitesListView.Items.Add(selectedOption.Text);
            DisabledEntitiesListView.Items.Remove(selectedOption);
        }

        private void RemoveEntityButton_Click(object sender, EventArgs e)
        {
            var selectedOption = EnabledEntitesListView.FocusedItem;
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