namespace Uszoverseny2
{
    partial class NevjegyForm
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
            this.txtNevjegy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNevjegy
            // 
            this.txtNevjegy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNevjegy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNevjegy.Location = new System.Drawing.Point(0, 0);
            this.txtNevjegy.Name = "txtNevjegy";
            this.txtNevjegy.Size = new System.Drawing.Size(299, 178);
            this.txtNevjegy.TabIndex = 0;
            this.txtNevjegy.Text = "label1";
            this.txtNevjegy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NevjegyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 178);
            this.Controls.Add(this.txtNevjegy);
            this.Name = "NevjegyForm";
            this.Text = "NevjegyForm";
            this.Load += new System.EventHandler(this.NevjegyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtNevjegy;
    }
}