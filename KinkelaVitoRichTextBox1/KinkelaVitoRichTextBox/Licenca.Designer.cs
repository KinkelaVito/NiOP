namespace KinkelaVitoRichTextBox
{
    partial class Licenca
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmVanForme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KinkelaVitoRichTextBox.Properties.Resources.cc_licence4;
            this.pictureBox1.Location = new System.Drawing.Point(61, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izradio: Vito Kinkela\r\nRazred: 3.d\r\nDatum: 19.1.2019.\r\n";
            // 
            // btmVanForme
            // 
            this.btmVanForme.Location = new System.Drawing.Point(61, 12);
            this.btmVanForme.Name = "btmVanForme";
            this.btmVanForme.Size = new System.Drawing.Size(75, 23);
            this.btmVanForme.TabIndex = 2;
            this.btmVanForme.Text = "Zatvori";
            this.btmVanForme.UseVisualStyleBackColor = true;
            this.btmVanForme.Click += new System.EventHandler(this.btmVanForme_Click);
            // 
            // Licenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 130);
            this.Controls.Add(this.btmVanForme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Licenca";
            this.Text = "Licenca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmVanForme;
    }
}