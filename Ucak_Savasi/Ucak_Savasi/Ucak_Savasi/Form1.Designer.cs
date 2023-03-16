namespace Ucak_Savasi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ducak3 = new System.Windows.Forms.PictureBox();
            this.ducak1 = new System.Windows.Forms.PictureBox();
            this.bucak = new System.Windows.Forms.PictureBox();
            this.mermi = new System.Windows.Forms.PictureBox();
            this.ducak2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ducak3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblsonuc);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 44);
            this.panel1.TabIndex = 4;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.ForeColor = System.Drawing.Color.White;
            this.lblsonuc.Location = new System.Drawing.Point(78, 2);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(37, 42);
            this.lblsonuc.TabIndex = 2;
            this.lblsonuc.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puan";
            // 
            // ducak3
            // 
            this.ducak3.Image = global::Ucak_Savasi.Properties.Resources.dusman1;
            this.ducak3.Location = new System.Drawing.Point(438, 126);
            this.ducak3.Name = "ducak3";
            this.ducak3.Size = new System.Drawing.Size(100, 84);
            this.ducak3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak3.TabIndex = 3;
            this.ducak3.TabStop = false;
            // 
            // ducak1
            // 
            this.ducak1.Image = global::Ucak_Savasi.Properties.Resources.dusman1;
            this.ducak1.Location = new System.Drawing.Point(72, 126);
            this.ducak1.Name = "ducak1";
            this.ducak1.Size = new System.Drawing.Size(100, 84);
            this.ducak1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak1.TabIndex = 2;
            this.ducak1.TabStop = false;
            // 
            // bucak
            // 
            this.bucak.Image = global::Ucak_Savasi.Properties.Resources.bizim;
            this.bucak.Location = new System.Drawing.Point(258, 498);
            this.bucak.Name = "bucak";
            this.bucak.Size = new System.Drawing.Size(107, 83);
            this.bucak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bucak.TabIndex = 0;
            this.bucak.TabStop = false;
            // 
            // mermi
            // 
            this.mermi.Image = global::Ucak_Savasi.Properties.Resources.ates;
            this.mermi.Location = new System.Drawing.Point(294, 422);
            this.mermi.Name = "mermi";
            this.mermi.Size = new System.Drawing.Size(23, 37);
            this.mermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mermi.TabIndex = 0;
            this.mermi.TabStop = false;
            // 
            // ducak2
            // 
            this.ducak2.Image = global::Ucak_Savasi.Properties.Resources.dusman1;
            this.ducak2.Location = new System.Drawing.Point(258, 126);
            this.ducak2.Name = "ducak2";
            this.ducak2.Size = new System.Drawing.Size(100, 84);
            this.ducak2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ducak2.TabIndex = 0;
            this.ducak2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(624, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ducak3);
            this.Controls.Add(this.ducak1);
            this.Controls.Add(this.bucak);
            this.Controls.Add(this.mermi);
            this.Controls.Add(this.ducak2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Savaşı -- www.bilisimogretmeni.com---";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ducak3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducak2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ducak2;
        private System.Windows.Forms.PictureBox mermi;
        private System.Windows.Forms.PictureBox bucak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ducak1;
        private System.Windows.Forms.PictureBox ducak3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label1;
    }
}

