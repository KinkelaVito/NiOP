namespace KinkelaVitoContextMenuStrip
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
            this.textBoxLijevo = new System.Windows.Forms.TextBox();
            this.textBoxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLijevo
            // 
            this.textBoxLijevo.ContextMenuStrip = this.contextMenuStrip2;
            this.textBoxLijevo.Location = new System.Drawing.Point(12, 43);
            this.textBoxLijevo.Name = "textBoxLijevo";
            this.textBoxLijevo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLijevo.TabIndex = 0;
            // 
            // textBoxDesno
            // 
            this.textBoxDesno.ContextMenuStrip = this.contextMenuStrip2;
            this.textBoxDesno.Location = new System.Drawing.Point(168, 43);
            this.textBoxDesno.Name = "textBoxDesno";
            this.textBoxDesno.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesno.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(199, 48);
            // 
            // lijevoNaDesnoToolStripMenuItem
            // 
            this.lijevoNaDesnoToolStripMenuItem.Name = "lijevoNaDesnoToolStripMenuItem";
            this.lijevoNaDesnoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.lijevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lijevoNaDesnoToolStripMenuItem.Text = "Lijevo na desno";
            this.lijevoNaDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoNaDesnoToolStripMenuItem_Click);
            // 
            // desnoNaLijevoToolStripMenuItem
            // 
            this.desnoNaLijevoToolStripMenuItem.Name = "desnoNaLijevoToolStripMenuItem";
            this.desnoNaLijevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.desnoNaLijevoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.desnoNaLijevoToolStripMenuItem.Text = "Desno na lijevo";
            this.desnoNaLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLijevoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
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
            this.ClientSize = new System.Drawing.Size(280, 75);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxDesno);
            this.Controls.Add(this.textBoxLijevo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLijevo;
        private System.Windows.Forms.TextBox textBoxDesno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
    }
}

