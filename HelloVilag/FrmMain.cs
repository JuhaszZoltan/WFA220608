using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVilag
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //this.Text = "Viszlát Világ!";
            //lblHelloWorld.Text = "Viszlát Világ";
        }

        private void LblHelloWorld_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Helló Világ!");
        }
    }
}
