namespace Muveletek
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAdat1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzorzas = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOsztas = new System.Windows.Forms.Button();
            this.btnOsszeadas = new System.Windows.Forms.Button();
            this.btnKivonas = new System.Windows.Forms.Button();
            this.tbAdat2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEredmeny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAdat1
            // 
            this.tbAdat1.Location = new System.Drawing.Point(36, 86);
            this.tbAdat1.Name = "tbAdat1";
            this.tbAdat1.Size = new System.Drawing.Size(86, 38);
            this.tbAdat1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. adat:";
            // 
            // btnSzorzas
            // 
            this.btnSzorzas.Location = new System.Drawing.Point(12, 275);
            this.btnSzorzas.Name = "btnSzorzas";
            this.btnSzorzas.Size = new System.Drawing.Size(81, 44);
            this.btnSzorzas.TabIndex = 2;
            this.btnSzorzas.Text = "*";
            this.btnSzorzas.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(342, 52);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnOsztas
            // 
            this.btnOsztas.Location = new System.Drawing.Point(99, 275);
            this.btnOsztas.Name = "btnOsztas";
            this.btnOsztas.Size = new System.Drawing.Size(81, 44);
            this.btnOsztas.TabIndex = 2;
            this.btnOsztas.Text = "/";
            this.btnOsztas.UseVisualStyleBackColor = true;
            // 
            // btnOsszeadas
            // 
            this.btnOsszeadas.Location = new System.Drawing.Point(186, 275);
            this.btnOsszeadas.Name = "btnOsszeadas";
            this.btnOsszeadas.Size = new System.Drawing.Size(81, 44);
            this.btnOsszeadas.TabIndex = 2;
            this.btnOsszeadas.Text = "+";
            this.btnOsszeadas.UseVisualStyleBackColor = true;
            // 
            // btnKivonas
            // 
            this.btnKivonas.Location = new System.Drawing.Point(273, 275);
            this.btnKivonas.Name = "btnKivonas";
            this.btnKivonas.Size = new System.Drawing.Size(81, 44);
            this.btnKivonas.TabIndex = 2;
            this.btnKivonas.Text = "-";
            this.btnKivonas.UseVisualStyleBackColor = true;
            // 
            // tbAdat2
            // 
            this.tbAdat2.Location = new System.Drawing.Point(222, 86);
            this.tbAdat2.Name = "tbAdat2";
            this.tbAdat2.Size = new System.Drawing.Size(86, 38);
            this.tbAdat2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. adat:";
            // 
            // tbEredmeny
            // 
            this.tbEredmeny.Location = new System.Drawing.Point(128, 196);
            this.tbEredmeny.Name = "tbEredmeny";
            this.tbEredmeny.Size = new System.Drawing.Size(86, 38);
            this.tbEredmeny.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(122, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "eredmény";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 388);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKivonas);
            this.Controls.Add(this.btnOsszeadas);
            this.Controls.Add(this.btnOsztas);
            this.Controls.Add(this.btnSzorzas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdat2);
            this.Controls.Add(this.tbEredmeny);
            this.Controls.Add(this.tbAdat1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.Text = "Műveletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzorzas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOsztas;
        private System.Windows.Forms.Button btnOsszeadas;
        private System.Windows.Forms.Button btnKivonas;
        private System.Windows.Forms.TextBox tbAdat2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEredmeny;
        private System.Windows.Forms.Label label3;
    }
}

