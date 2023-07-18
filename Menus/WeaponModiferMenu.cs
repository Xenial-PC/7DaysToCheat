using System;
using System.Windows.Forms;
using C7D2C.Classes;

namespace C7D2C.Menus
{
    public partial class WeaponModiferMenu : Form
    {
        public WeaponModiferMenu()
        {
            InitializeComponent();
            TopMost = true;
            ShowInTaskbar = false;
        }

        private void WeaponModiferMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        { 
            Hide();
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Overlay.ReleaseCapture();
            Overlay.SendMessage(Handle, Overlay.WmNclButtonDown, Overlay.HtCaption, 0);
        }
    }
}
