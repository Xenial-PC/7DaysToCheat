using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7DaysToCheat.Menus
{
    public partial class BaseMenu : Form
    {
        public BaseMenu()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        { 
            Hide();
        }
    }
}
