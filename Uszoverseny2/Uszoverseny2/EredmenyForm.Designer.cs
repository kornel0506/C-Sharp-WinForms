namespace Uszoverseny2
{
    partial class EredmenyForm
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
            this.lblCim = new System.Windows.Forms.Label();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrszagok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoEredemeny = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnNevsor = new System.Windows.Forms.RadioButton();
            this.rdBtnEredmeny = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCim
            // 
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.ForeColor = System.Drawing.Color.Brown;
            this.lblCim.Location = new System.Drawing.Point(0, 33);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(491, 23);
            this.lblCim.TabIndex = 0;
            this.lblCim.Text = "label1";
            this.lblCim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(46, 133);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(176, 290);
            this.lstVersenyzok.TabIndex = 1;
            this.lstVersenyzok.SelectedIndexChanged += new System.EventHandler(this.lstVersenyzok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Résztvevők";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrszagok
            // 
            this.btnOrszagok.Location = new System.Drawing.Point(73, 460);
            this.btnOrszagok.Name = "btnOrszagok";
            this.btnOrszagok.Size = new System.Drawing.Size(122, 23);
            this.btnOrszagok.TabIndex = 3;
            this.btnOrszagok.Text = "Résztvevő országok";
            this.btnOrszagok.UseVisualStyleBackColor = true;
            this.btnOrszagok.Click += new System.EventHandler(this.btnOrszagok_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bezár";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rajszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Időeredmény:";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Location = new System.Drawing.Point(354, 130);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.ReadOnly = true;
            this.txtRajtszam.Size = new System.Drawing.Size(100, 20);
            this.txtRajtszam.TabIndex = 8;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(354, 179);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.ReadOnly = true;
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 9;
            // 
            // txtIdoEredemeny
            // 
            this.txtIdoEredemeny.Location = new System.Drawing.Point(354, 228);
            this.txtIdoEredemeny.Name = "txtIdoEredemeny";
            this.txtIdoEredemeny.ReadOnly = true;
            this.txtIdoEredemeny.Size = new System.Drawing.Size(100, 20);
            this.txtIdoEredemeny.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnEredmeny);
            this.groupBox1.Controls.Add(this.rdBtnNevsor);
            this.groupBox1.Location = new System.Drawing.Point(271, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezési szempont";
            // 
            // rdBtnNevsor
            // 
            this.rdBtnNevsor.AutoSize = true;
            this.rdBtnNevsor.Location = new System.Drawing.Point(24, 19);
            this.rdBtnNevsor.Name = "rdBtnNevsor";
            this.rdBtnNevsor.Size = new System.Drawing.Size(92, 17);
            this.rdBtnNevsor.TabIndex = 0;
            this.rdBtnNevsor.TabStop = true;
            this.rdBtnNevsor.Text = "Névsor szerint";
            this.rdBtnNevsor.UseVisualStyleBackColor = true;
            this.rdBtnNevsor.CheckedChanged += new System.EventHandler(this.rdBtnNevsor_CheckedChanged);
            // 
            // rdBtnEredmeny
            // 
            this.rdBtnEredmeny.AutoSize = true;
            this.rdBtnEredmeny.Location = new System.Drawing.Point(24, 42);
            this.rdBtnEredmeny.Name = "rdBtnEredmeny";
            this.rdBtnEredmeny.Size = new System.Drawing.Size(105, 17);
            this.rdBtnEredmeny.TabIndex = 1;
            this.rdBtnEredmeny.TabStop = true;
            this.rdBtnEredmeny.Text = "Eredmény szerint";
            this.rdBtnEredmeny.UseVisualStyleBackColor = true;
            this.rdBtnEredmeny.CheckedChanged += new System.EventHandler(this.rdBtnEredmeny_CheckedChanged);
            // 
            // EredmenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdoEredemeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOrszagok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.lblCim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EredmenyForm";
            this.Text = "EredmenyForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrszagok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoEredemeny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnEredmeny;
        private System.Windows.Forms.RadioButton rdBtnNevsor;
    }
}