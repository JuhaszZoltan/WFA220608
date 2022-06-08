namespace Szinezo
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.btnAlaphelyzet = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Tomato;
            this.pb1.Location = new System.Drawing.Point(15, 100);
            this.pb1.Margin = new System.Windows.Forms.Padding(6);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(525, 97);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.Location = new System.Drawing.Point(15, 9);
            this.lblSzoveg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(525, 85);
            this.lblSzoveg.TabIndex = 1;
            this.lblSzoveg.Text = "Kattints valamelyik színes téglalapra!";
            this.lblSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlaphelyzet
            // 
            this.btnAlaphelyzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlaphelyzet.Location = new System.Drawing.Point(15, 667);
            this.btnAlaphelyzet.Margin = new System.Windows.Forms.Padding(6);
            this.btnAlaphelyzet.Name = "btnAlaphelyzet";
            this.btnAlaphelyzet.Size = new System.Drawing.Size(235, 64);
            this.btnAlaphelyzet.TabIndex = 2;
            this.btnAlaphelyzet.Text = "Alaphelyzet";
            this.btnAlaphelyzet.UseVisualStyleBackColor = true;
            this.btnAlaphelyzet.Click += new System.EventHandler(this.BtnAlaphelyzet_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.LawnGreen;
            this.pb2.Location = new System.Drawing.Point(15, 245);
            this.pb2.Margin = new System.Windows.Forms.Padding(6);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(525, 97);
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Aqua;
            this.pb3.Location = new System.Drawing.Point(15, 392);
            this.pb3.Margin = new System.Windows.Forms.Padding(6);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(525, 97);
            this.pb3.TabIndex = 0;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Orange;
            this.pb4.Location = new System.Drawing.Point(15, 538);
            this.pb4.Margin = new System.Windows.Forms.Padding(6);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(525, 97);
            this.pb4.TabIndex = 0;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(305, 667);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(235, 64);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 746);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAlaphelyzet);
            this.Controls.Add(this.lblSzoveg);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.Text = "Színező";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblSzoveg;
        private System.Windows.Forms.Button btnAlaphelyzet;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnExit;
    }
}

