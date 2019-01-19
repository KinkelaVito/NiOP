namespace KinkelaVitoRichTextBox
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
            this.btm1 = new System.Windows.Forms.Button();
            this.btm2 = new System.Windows.Forms.Button();
            this.btm3 = new System.Windows.Forms.Button();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btm1
            // 
            this.btm1.Location = new System.Drawing.Point(46, 39);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(147, 46);
            this.btm1.TabIndex = 0;
            this.btm1.Text = "Čitaj";
            this.btm1.UseVisualStyleBackColor = true;
            this.btm1.Click += new System.EventHandler(this.btm1_Click);
            // 
            // btm2
            // 
            this.btm2.Location = new System.Drawing.Point(46, 237);
            this.btm2.Name = "btm2";
            this.btm2.Size = new System.Drawing.Size(147, 51);
            this.btm2.TabIndex = 1;
            this.btm2.Text = "Spremi";
            this.btm2.UseVisualStyleBackColor = true;
            this.btm2.Click += new System.EventHandler(this.btm2_Click);
            // 
            // btm3
            // 
            this.btm3.Location = new System.Drawing.Point(224, 123);
            this.btm3.Name = "btm3";
            this.btm3.Size = new System.Drawing.Size(143, 83);
            this.btm3.TabIndex = 2;
            this.btm3.Text = "Briši";
            this.btm3.UseVisualStyleBackColor = true;
            this.btm3.Click += new System.EventHandler(this.btm3_Click);
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(46, 91);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(147, 140);
            this.richTxtBox.TabIndex = 3;
            this.richTxtBox.Text = "";
            this.richTxtBox.TextChanged += new System.EventHandler(this.richTxtBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 341);
            this.Controls.Add(this.richTxtBox);
            this.Controls.Add(this.btm3);
            this.Controls.Add(this.btm2);
            this.Controls.Add(this.btm1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm1;
        private System.Windows.Forms.Button btm2;
        private System.Windows.Forms.Button btm3;
        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
    }
}

