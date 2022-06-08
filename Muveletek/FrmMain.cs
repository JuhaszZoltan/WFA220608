using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muveletek
{
    public partial class FrmMain : Form
    {

        private int adat1;
        private int adat2;

        public FrmMain()
        {
            InitializeComponent();

            btnOsszeadas.Click += Btn_Click;
            btnKivonas.Click += Btn_Click;
            btnSzorzas.Click += Btn_Click;
            btnOsztas.Click += Btn_Click;

            tbAdat1.TextChanged += Tb_TextChanged;
            tbAdat2.TextChanged += Tb_TextChanged;

            tbEredmeny.ReadOnly = true;

        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            tbEredmeny.Text = string.Empty;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (!MindkettoSzam()) MessageBox.Show("valamelyik input nem szám!");
            else
            {
                switch ((sender as Button).Text)
                {
                    case "*":
                        tbEredmeny.Text = $"{adat1 * adat2}";
                        return;
                    case "+":
                        tbEredmeny.Text = $"{adat1 + adat2}";
                        return;
                    case "-":
                        tbEredmeny.Text = $"{adat1 - adat2}";
                        return;
                    case "/":
                        if (adat2 == 0) MessageBox.Show("0-val nem lehet osztani!");
                        else tbEredmeny.Text = $"{adat1 / (float)adat2, 0:0.00}";
                        return;
                }
            }
        }

        private bool MindkettoSzam()
        {
            bool adat1Jo = int.TryParse(tbAdat1.Text, out adat1);
            bool adat2Jo = int.TryParse(tbAdat2.Text, out adat2);

            return adat1Jo && adat2Jo;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
