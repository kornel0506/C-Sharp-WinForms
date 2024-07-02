namespace Talalkozo
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
            this.dtTmPckrDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTmPckrIdo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErtekeles = new System.Windows.Forms.Label();
            this.btnErtekel = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.lblTalalkozo = new System.Windows.Forms.Label();
            this.lblAktualis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtTmPckrDatum
            // 
            this.dtTmPckrDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrDatum.Location = new System.Drawing.Point(24, 64);
            this.dtTmPckrDatum.Name = "dtTmPckrDatum";
            this.dtTmPckrDatum.Size = new System.Drawing.Size(115, 20);
            this.dtTmPckrDatum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A találkozó ideje:";
            // 
            // dtTmPckrIdo
            // 
            this.dtTmPckrIdo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTmPckrIdo.Location = new System.Drawing.Point(188, 64);
            this.dtTmPckrIdo.Name = "dtTmPckrIdo";
            this.dtTmPckrIdo.ShowUpDown = true;
            this.dtTmPckrIdo.Size = new System.Drawing.Size(104, 20);
            this.dtTmPckrIdo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A találkozó ideje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aktuális idő:";
            // 
            // lblErtekeles
            // 
            this.lblErtekeles.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErtekeles.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErtekeles.Location = new System.Drawing.Point(0, 188);
            this.lblErtekeles.Name = "lblErtekeles";
            this.lblErtekeles.Size = new System.Drawing.Size(316, 27);
            this.lblErtekeles.TabIndex = 5;
            this.lblErtekeles.Text = "label";
            this.lblErtekeles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErtekel
            // 
            this.btnErtekel.Location = new System.Drawing.Point(24, 235);
            this.btnErtekel.Name = "btnErtekel";
            this.btnErtekel.Size = new System.Drawing.Size(75, 23);
            this.btnErtekel.TabIndex = 6;
            this.btnErtekel.Text = "Értékel";
            this.btnErtekel.UseVisualStyleBackColor = true;
            this.btnErtekel.Click += new System.EventHandler(this.btnErtekel_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(217, 235);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 7;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(121, 272);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 8;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // lblTalalkozo
            // 
            this.lblTalalkozo.AutoSize = true;
            this.lblTalalkozo.Location = new System.Drawing.Point(120, 124);
            this.lblTalalkozo.Name = "lblTalalkozo";
            this.lblTalalkozo.Size = new System.Drawing.Size(35, 13);
            this.lblTalalkozo.TabIndex = 9;
            this.lblTalalkozo.Text = "label5";
            // 
            // lblAktualis
            // 
            this.lblAktualis.AutoSize = true;
            this.lblAktualis.Location = new System.Drawing.Point(120, 150);
            this.lblAktualis.Name = "lblAktualis";
            this.lblAktualis.Size = new System.Drawing.Size(35, 13);
            this.lblAktualis.TabIndex = 10;
            this.lblAktualis.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 315);
            this.Controls.Add(this.lblAktualis);
            this.Controls.Add(this.lblTalalkozo);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnErtekel);
            this.Controls.Add(this.lblErtekeles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTmPckrIdo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTmPckrDatum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Találkozó";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTmPckrDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTmPckrIdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErtekeles;
        private System.Windows.Forms.Button btnErtekel;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label lblTalalkozo;
        private System.Windows.Forms.Label lblAktualis;
    }
}

