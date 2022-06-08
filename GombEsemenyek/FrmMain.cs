using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GombEsemenyek
{
    public partial class FrmMain : Form
    {
        private string eGombFelirat;
        private string eFormFelirat;
        private Color eFormSzin;

        public FrmMain()
        {
            InitializeComponent();

            eGombFelirat = btnGomb.Text;
            eFormFelirat = this.Text;
            eFormSzin = this.BackColor;
        }

        private void BtnGomb_Click(object sender, EventArgs e)
        {
            //(sender as Button).Text = (sender as Button).Text.ToUpper();
            btnGomb.Text = btnGomb.Text.ToUpper();
        }

        private void BtnGomb_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
        }

        private void BtnGomb_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"{Cursor.Position.ToString()}";
        }

        private void BtnGomb_MouseLeave(object sender, EventArgs e)
        {
            btnGomb.Text = eGombFelirat;
            //btnGomb.Text = btnGomb.Text.ToLower();
            this.Text = eFormFelirat;
            this.BackColor = eFormSzin;
        }
    }
}
