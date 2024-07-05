namespace Retoxikalo
{
    partial class ItalLapForm
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
            this.pnlValasztek = new System.Windows.Forms.Panel();
            this.btnRendel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szamlatKerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlValasztek
            // 
            this.pnlValasztek.AutoScroll = true;
            this.pnlValasztek.Location = new System.Drawing.Point(12, 12);
            this.pnlValasztek.Name = "pnlValasztek";
            this.pnlValasztek.Size = new System.Drawing.Size(409, 507);
            this.pnlValasztek.TabIndex = 0;
            // 
            // btnRendel
            // 
            this.btnRendel.ContextMenuStrip = this.contextMenuStrip1;
            this.btnRendel.Location = new System.Drawing.Point(174, 550);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(75, 23);
            this.btnRendel.TabIndex = 1;
            this.btnRendel.Text = "Rendel";
            this.btnRendel.UseVisualStyleBackColor = true;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szamlatKerToolStripMenuItem,
            this.fizetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // szamlatKerToolStripMenuItem
            // 
            this.szamlatKerToolStripMenuItem.Name = "szamlatKerToolStripMenuItem";
            this.szamlatKerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szamlatKerToolStripMenuItem.Text = "Számlát kér";
            this.szamlatKerToolStripMenuItem.Click += new System.EventHandler(this.szamlatKerToolStripMenuItem_Click);
            // 
            // fizetToolStripMenuItem
            // 
            this.fizetToolStripMenuItem.Name = "fizetToolStripMenuItem";
            this.fizetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fizetToolStripMenuItem.Text = "Fizet";
            this.fizetToolStripMenuItem.Click += new System.EventHandler(this.fizetToolStripMenuItem_Click);
            // 
            // ItalLapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 602);
            this.Controls.Add(this.btnRendel);
            this.Controls.Add(this.pnlValasztek);
            this.Name = "ItalLapForm";
            this.Text = "ItalLapForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlValasztek;
        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szamlatKerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizetToolStripMenuItem;
    }
}