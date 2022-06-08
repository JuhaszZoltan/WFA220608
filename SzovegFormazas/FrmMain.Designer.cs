namespace SzovegFormazas
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
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.btnKek = new System.Windows.Forms.Button();
            this.btnBalKozep = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnFeher = new System.Windows.Forms.Button();
            this.btnKozepKozep = new System.Windows.Forms.Button();
            this.btnNagyit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnJobbKozep = new System.Windows.Forms.Button();
            this.btnKicsinyit = new System.Windows.Forms.Button();
            this.btnAlaphelyzet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.BackColor = System.Drawing.SystemColors.Control;
            this.lblSzoveg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzoveg.Location = new System.Drawing.Point(12, 21);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(528, 190);
            this.lblSzoveg.TabIndex = 0;
            this.lblSzoveg.Text = "Fluxuskondenzátor";
            // 
            // btnKek
            // 
            this.btnKek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKek.Location = new System.Drawing.Point(12, 227);
            this.btnKek.Name = "btnKek";
            this.btnKek.Size = new System.Drawing.Size(172, 51);
            this.btnKek.TabIndex = 1;
            this.btnKek.Text = "kék betű";
            this.btnKek.UseVisualStyleBackColor = true;
            this.btnKek.Click += new System.EventHandler(this.btnKek_Click);
            // 
            // btnBalKozep
            // 
            this.btnBalKozep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBalKozep.Location = new System.Drawing.Point(12, 284);
            this.btnBalKozep.Name = "btnBalKozep";
            this.btnBalKozep.Size = new System.Drawing.Size(172, 51);
            this.btnBalKozep.TabIndex = 1;
            this.btnBalKozep.Text = "bal-közép";
            this.btnBalKozep.UseVisualStyleBackColor = true;
            this.btnBalKozep.Click += new System.EventHandler(this.btnBalKozep_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpper.Location = new System.Drawing.Point(12, 341);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(172, 51);
            this.btnUpper.TabIndex = 1;
            this.btnUpper.Text = "nagybetűs";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnFeher
            // 
            this.btnFeher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeher.Location = new System.Drawing.Point(190, 227);
            this.btnFeher.Name = "btnFeher";
            this.btnFeher.Size = new System.Drawing.Size(172, 51);
            this.btnFeher.TabIndex = 1;
            this.btnFeher.Text = "fehér háttér";
            this.btnFeher.UseVisualStyleBackColor = true;
            this.btnFeher.Click += new System.EventHandler(this.btnFeher_Click);
            // 
            // btnKozepKozep
            // 
            this.btnKozepKozep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKozepKozep.Location = new System.Drawing.Point(190, 284);
            this.btnKozepKozep.Name = "btnKozepKozep";
            this.btnKozepKozep.Size = new System.Drawing.Size(172, 51);
            this.btnKozepKozep.TabIndex = 1;
            this.btnKozepKozep.Text = "közép-közép";
            this.btnKozepKozep.UseVisualStyleBackColor = true;
            this.btnKozepKozep.Click += new System.EventHandler(this.btnKozepKozep_Click);
            // 
            // btnNagyit
            // 
            this.btnNagyit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNagyit.Location = new System.Drawing.Point(190, 341);
            this.btnNagyit.Name = "btnNagyit";
            this.btnNagyit.Size = new System.Drawing.Size(172, 51);
            this.btnNagyit.TabIndex = 1;
            this.btnNagyit.Text = "nagyít";
            this.btnNagyit.UseVisualStyleBackColor = true;
            this.btnNagyit.Click += new System.EventHandler(this.btnNagyit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(368, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 51);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "töröl";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnJobbKozep
            // 
            this.btnJobbKozep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJobbKozep.Location = new System.Drawing.Point(368, 284);
            this.btnJobbKozep.Name = "btnJobbKozep";
            this.btnJobbKozep.Size = new System.Drawing.Size(172, 51);
            this.btnJobbKozep.TabIndex = 1;
            this.btnJobbKozep.Text = "jobb-közép";
            this.btnJobbKozep.UseVisualStyleBackColor = true;
            this.btnJobbKozep.Click += new System.EventHandler(this.btnJobbKozep_Click);
            // 
            // btnKicsinyit
            // 
            this.btnKicsinyit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKicsinyit.Location = new System.Drawing.Point(368, 341);
            this.btnKicsinyit.Name = "btnKicsinyit";
            this.btnKicsinyit.Size = new System.Drawing.Size(172, 51);
            this.btnKicsinyit.TabIndex = 1;
            this.btnKicsinyit.Text = "kicsinyít";
            this.btnKicsinyit.UseVisualStyleBackColor = true;
            this.btnKicsinyit.Click += new System.EventHandler(this.btnKicsinyit_Click);
            // 
            // btnAlaphelyzet
            // 
            this.btnAlaphelyzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlaphelyzet.Location = new System.Drawing.Point(12, 398);
            this.btnAlaphelyzet.Name = "btnAlaphelyzet";
            this.btnAlaphelyzet.Size = new System.Drawing.Size(172, 51);
            this.btnAlaphelyzet.TabIndex = 1;
            this.btnAlaphelyzet.Text = "alaphelyzet";
            this.btnAlaphelyzet.UseVisualStyleBackColor = true;
            this.btnAlaphelyzet.Click += new System.EventHandler(this.btnAlaphelyzet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(368, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 466);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKicsinyit);
            this.Controls.Add(this.btnNagyit);
            this.Controls.Add(this.btnJobbKozep);
            this.Controls.Add(this.btnAlaphelyzet);
            this.Controls.Add(this.btnKozepKozep);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnFeher);
            this.Controls.Add(this.btnBalKozep);
            this.Controls.Add(this.btnKek);
            this.Controls.Add(this.lblSzoveg);
            this.Name = "FrmMain";
            this.Text = "Szöveg formázása";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSzoveg;
        private System.Windows.Forms.Button btnKek;
        private System.Windows.Forms.Button btnBalKozep;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnFeher;
        private System.Windows.Forms.Button btnKozepKozep;
        private System.Windows.Forms.Button btnNagyit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnJobbKozep;
        private System.Windows.Forms.Button btnKicsinyit;
        private System.Windows.Forms.Button btnAlaphelyzet;
        private System.Windows.Forms.Button btnExit;
    }
}

