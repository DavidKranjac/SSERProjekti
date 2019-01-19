namespace KranjacDavidContexMenuStrip
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
            this.txtBoxLijevo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxLijevo
            // 
            this.txtBoxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.txtBoxLijevo.Location = new System.Drawing.Point(13, 13);
            this.txtBoxLijevo.Multiline = true;
            this.txtBoxLijevo.Name = "txtBoxLijevo";
            this.txtBoxLijevo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLijevo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 48);
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
            // txtBoxDesno
            // 
            this.txtBoxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.txtBoxDesno.Location = new System.Drawing.Point(339, 13);
            this.txtBoxDesno.Multiline = true;
            this.txtBoxDesno.Name = "txtBoxDesno";
            this.txtBoxDesno.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDesno.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxDesno);
            this.Controls.Add(this.txtBoxLijevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLijevo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxDesno;
    }
}

