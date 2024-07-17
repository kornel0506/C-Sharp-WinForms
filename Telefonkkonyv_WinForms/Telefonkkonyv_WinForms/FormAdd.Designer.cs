namespace Telefonkkonyv_WinForms
{
    partial class FormAdd
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
            this.CBoxNem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxSzemelyi = new System.Windows.Forms.TextBox();
            this.TBoxEmail = new System.Windows.Forms.TextBox();
            this.TBoxTel = new System.Windows.Forms.TextBox();
            this.TBoxMother = new System.Windows.Forms.TextBox();
            this.TBoxFather = new System.Windows.Forms.TextBox();
            this.TBoxCim = new System.Windows.Forms.TextBox();
            this.TBoxNev = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBoxNem
            // 
            this.CBoxNem.FormattingEnabled = true;
            this.CBoxNem.Items.AddRange(new object[] {
            "Férfi",
            "Nő"});
            this.CBoxNem.Location = new System.Drawing.Point(300, 50);
            this.CBoxNem.Name = "CBoxNem";
            this.CBoxNem.Size = new System.Drawing.Size(100, 21);
            this.CBoxNem.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Személyi szám:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Telefonszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Anya neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apja neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cím:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Név:";
            // 
            // TBoxSzemelyi
            // 
            this.TBoxSzemelyi.Location = new System.Drawing.Point(300, 126);
            this.TBoxSzemelyi.Name = "TBoxSzemelyi";
            this.TBoxSzemelyi.Size = new System.Drawing.Size(100, 20);
            this.TBoxSzemelyi.TabIndex = 25;
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.Location = new System.Drawing.Point(300, 88);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.TBoxEmail.TabIndex = 24;
            // 
            // TBoxTel
            // 
            this.TBoxTel.Location = new System.Drawing.Point(300, 12);
            this.TBoxTel.Name = "TBoxTel";
            this.TBoxTel.Size = new System.Drawing.Size(100, 20);
            this.TBoxTel.TabIndex = 23;
            // 
            // TBoxMother
            // 
            this.TBoxMother.Location = new System.Drawing.Point(105, 126);
            this.TBoxMother.Name = "TBoxMother";
            this.TBoxMother.Size = new System.Drawing.Size(100, 20);
            this.TBoxMother.TabIndex = 22;
            // 
            // TBoxFather
            // 
            this.TBoxFather.Location = new System.Drawing.Point(105, 88);
            this.TBoxFather.Name = "TBoxFather";
            this.TBoxFather.Size = new System.Drawing.Size(100, 20);
            this.TBoxFather.TabIndex = 21;
            // 
            // TBoxCim
            // 
            this.TBoxCim.Location = new System.Drawing.Point(105, 50);
            this.TBoxCim.Name = "TBoxCim";
            this.TBoxCim.Size = new System.Drawing.Size(100, 20);
            this.TBoxCim.TabIndex = 20;
            // 
            // TBoxNev
            // 
            this.TBoxNev.Location = new System.Drawing.Point(105, 12);
            this.TBoxNev.Name = "TBoxNev";
            this.TBoxNev.Size = new System.Drawing.Size(100, 20);
            this.TBoxNev.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBoxNem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxSzemelyi);
            this.Controls.Add(this.TBoxEmail);
            this.Controls.Add(this.TBoxTel);
            this.Controls.Add(this.TBoxMother);
            this.Controls.Add(this.TBoxFather);
            this.Controls.Add(this.TBoxCim);
            this.Controls.Add(this.TBoxNev);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxNem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxSzemelyi;
        private System.Windows.Forms.TextBox TBoxEmail;
        private System.Windows.Forms.TextBox TBoxTel;
        private System.Windows.Forms.TextBox TBoxMother;
        private System.Windows.Forms.TextBox TBoxFather;
        private System.Windows.Forms.TextBox TBoxCim;
        private System.Windows.Forms.TextBox TBoxNev;
        private System.Windows.Forms.Button button1;
    }
}