namespace Pizzeria
{
    partial class PizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFizetendo = new System.Windows.Forms.TextBox();
            this.pnlKozponti = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(31, 419);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 4;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(31, 479);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 5;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(207, 479);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(163, 23);
            this.btnAdatBe.TabIndex = 6;
            this.btnAdatBe.Text = "Adatbevitel";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(484, 479);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 7;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(162, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fizetendő:";
            // 
            // txtFizetendo
            // 
            this.txtFizetendo.Location = new System.Drawing.Point(271, 422);
            this.txtFizetendo.Name = "txtFizetendo";
            this.txtFizetendo.Size = new System.Drawing.Size(112, 20);
            this.txtFizetendo.TabIndex = 9;
            // 
            // pnlKozponti
            // 
            this.pnlKozponti.AutoScroll = true;
            this.pnlKozponti.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlKozponti.Location = new System.Drawing.Point(31, 73);
            this.pnlKozponti.Name = "pnlKozponti";
            this.pnlKozponti.Size = new System.Drawing.Size(528, 313);
            this.pnlKozponti.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menüválaszték";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFizetendo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.pnlKozponti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PizzaForm";
            this.Text = "Pizzéria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFizetendo;
        private System.Windows.Forms.Panel pnlKozponti;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

