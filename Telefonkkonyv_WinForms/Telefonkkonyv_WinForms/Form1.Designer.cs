namespace Telefonkkonyv_WinForms
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxNev = new System.Windows.Forms.TextBox();
            this.TBoxCim = new System.Windows.Forms.TextBox();
            this.TBoxFather = new System.Windows.Forms.TextBox();
            this.TBoxMother = new System.Windows.Forms.TextBox();
            this.TBoxTel = new System.Windows.Forms.TextBox();
            this.TBoxEmail = new System.Windows.Forms.TextBox();
            this.TBoxSzemelyi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBoxNem = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefonkönyv";
            // 
            // TBoxNev
            // 
            this.TBoxNev.Location = new System.Drawing.Point(345, 64);
            this.TBoxNev.Name = "TBoxNev";
            this.TBoxNev.Size = new System.Drawing.Size(151, 20);
            this.TBoxNev.TabIndex = 2;
            // 
            // TBoxCim
            // 
            this.TBoxCim.Location = new System.Drawing.Point(345, 102);
            this.TBoxCim.Name = "TBoxCim";
            this.TBoxCim.Size = new System.Drawing.Size(151, 20);
            this.TBoxCim.TabIndex = 3;
            // 
            // TBoxFather
            // 
            this.TBoxFather.Location = new System.Drawing.Point(345, 140);
            this.TBoxFather.Name = "TBoxFather";
            this.TBoxFather.Size = new System.Drawing.Size(151, 20);
            this.TBoxFather.TabIndex = 4;
            // 
            // TBoxMother
            // 
            this.TBoxMother.Location = new System.Drawing.Point(345, 178);
            this.TBoxMother.Name = "TBoxMother";
            this.TBoxMother.Size = new System.Drawing.Size(151, 20);
            this.TBoxMother.TabIndex = 5;
            // 
            // TBoxTel
            // 
            this.TBoxTel.Location = new System.Drawing.Point(345, 216);
            this.TBoxTel.Name = "TBoxTel";
            this.TBoxTel.Size = new System.Drawing.Size(151, 20);
            this.TBoxTel.TabIndex = 6;
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.Location = new System.Drawing.Point(345, 292);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Size = new System.Drawing.Size(151, 20);
            this.TBoxEmail.TabIndex = 8;
            // 
            // TBoxSzemelyi
            // 
            this.TBoxSzemelyi.Location = new System.Drawing.Point(345, 330);
            this.TBoxSzemelyi.Name = "TBoxSzemelyi";
            this.TBoxSzemelyi.Size = new System.Drawing.Size(151, 20);
            this.TBoxSzemelyi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apja neve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anya neve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefonszám:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Személyi szám:";
            // 
            // CBoxNem
            // 
            this.CBoxNem.FormattingEnabled = true;
            this.CBoxNem.Items.AddRange(new object[] {
            "Férfi",
            "Nő"});
            this.CBoxNem.Location = new System.Drawing.Point(345, 254);
            this.CBoxNem.Name = "CBoxNem";
            this.CBoxNem.Size = new System.Drawing.Size(151, 21);
            this.CBoxNem.TabIndex = 18;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 394);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 19;
            this.BtnAdd.Text = "Hozzáadás";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(148, 394);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 20;
            this.BtnEdit.Text = "Módosítás";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(284, 394);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Törlés";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(420, 394);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 22;
            this.BtnClose.Text = "Bezár";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Telefonkönyv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxNev;
        private System.Windows.Forms.TextBox TBoxCim;
        private System.Windows.Forms.TextBox TBoxFather;
        private System.Windows.Forms.TextBox TBoxMother;
        private System.Windows.Forms.TextBox TBoxTel;
        private System.Windows.Forms.TextBox TBoxEmail;
        private System.Windows.Forms.TextBox TBoxSzemelyi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBoxNem;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClose;
    }
}

