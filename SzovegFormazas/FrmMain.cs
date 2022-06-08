using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzovegFormazas
{
    public partial class FrmMain : Form
    {

        private string eFontNev;
        private float aktFontMeret;

        public FrmMain()
        {
            InitializeComponent();
            eFontNev = lblSzoveg.Font.Name;
            aktFontMeret = lblSzoveg.Font.Size;
        }

        private void btnKek_Click(object sender, EventArgs e)
        {
            lblSzoveg.ForeColor = Color.Blue;
        }

        private void btnFeher_Click(object sender, EventArgs e)
        {
            lblSzoveg.BackColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = String.Empty;
        }

        private void btnBalKozep_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btnKozepKozep_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnJobbKozep_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = lblSzoveg.Text.ToUpper();
        }

        private void btnNagyit_Click(object sender, EventArgs e)
        {
            aktFontMeret++;
            lblSzoveg.Font = new Font(
                familyName: eFontNev,
                emSize: aktFontMeret);
        }

        private void btnKicsinyit_Click(object sender, EventArgs e)
        {
            if (aktFontMeret > 1)
            {
                aktFontMeret--;
                lblSzoveg.Font = new Font(
                    familyName: eFontNev,
                    emSize: aktFontMeret);
            }
        }

        private void btnAlaphelyzet_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
