using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Pizzeria
{
    public partial class PizzaForm : Form
    {
        private List<Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzetek = new List<CheckBox>();
        private List<RadioButton> rdBtnKicsiArak = new List<RadioButton>();
        private List<RadioButton> rdBtnNagyArak = new List<RadioButton>();
        private List<TextBox> txtDarabok = new List<TextBox>();

        private int bal = 20, fent = 10;
        private int kozY = 40;
        private int meretY = 20;
        private int panelX = 350;
        private int meretChk = 120;
        private int meretAr = 50;
        private int meretFt = 20;
        private int meretDb = 50;
        private int koz = 3;

        public PizzaForm()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            LathatosagBeallitasa(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LathatosagBeallitasa(false);
        }
        private void LathatosagBeallitasa(bool lathatoE)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnAdatBe.Visible = !lathatoE;
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);
                    AdatBeolvasas(sr);

                    ValasztekFeltoltes();

                    LathatosagBeallitasa(true);
                    btnAdatBe.Visible = false;

                    this.BackgroundImage = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
           
        }

        private void AdatBeolvasas(StreamReader sr)
        {
            string adat;

            while (!sr.EndOfStream)
            {
                adat = sr.ReadLine();
                Feldolgoz(adat);
            }
        }
        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            pizzak.Add(new Pizza(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2])));
        }

        private void ValasztekFeltoltes()
        {
            CheckBox checkBox;
            Label label;
            RadioButton radioButton;
            Panel panel;
            TextBox textBox;
            Label labelDarab;

            for (int i = 0; i < pizzak.Count; i++)
            {
                checkBox = new CheckBox();
                checkBox.TextAlign = ContentAlignment.MiddleLeft;
                checkBox.Text = pizzak[i].Nev;
                checkBox.Location = new Point(bal, fent + i * kozY);
                checkBox.Size = new Size(meretChk, meretY);
                checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

                jeloloNegyzetek.Add(checkBox);

                pnlKozponti.Controls.Add(checkBox);

                panel = new Panel();
                panel.Size = new Size(panelX, meretY);
                panel.Location = new Point(bal + meretChk, fent + i * kozY);

                pnlKozponti.Controls.Add(panel);

                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArKicsi.ToString();
                radioButton.Location = new Point(0,0);
                rdBtnKicsiArak.Add(radioButton);

                panel.Controls.Add(radioButton);

                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(meretAr + koz, 0);
                label.Size = new Size(meretFt * 2, meretY);
                panel.Controls.Add(label);

                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArNagy.ToString();
                radioButton.Location = new Point(meretAr + meretFt * 2 + koz * 2, 0);
                rdBtnNagyArak.Add(radioButton);

                panel.Controls.Add(radioButton);

                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(meretAr * 2 + meretFt * 2 + koz * 3, 0);
                label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);

                textBox = new TextBox();
                textBox.Size = new Size(meretDb, meretY);
                textBox.Location = new Point(meretAr * 2 + meretFt * 4 + koz * 4, 0);
                txtDarabok.Add(textBox);

                panel.Controls.Add(textBox);

                labelDarab = new Label();
                labelDarab.TextAlign = ContentAlignment.MiddleLeft;
                labelDarab.Text = " darab";
                labelDarab.Location = new Point(meretAr * 2 + meretFt * 4 + meretDb + koz * 5, 0);
                labelDarab.Size = new Size(meretDb, meretY);
                panel.Controls.Add(labelDarab);
            }
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            bool vanKijeloles = false;
            int db, osszeg = 0, ar = 0;
            for (int i = 0; i < jeloloNegyzetek.Count; i++)
            {
                if (jeloloNegyzetek[i].Checked)
                {
                    vanKijeloles = true;
                    try
                    {
                        if (rdBtnKicsiArak[i].Checked) ar = pizzak[i].ArKicsi;
                        else if (rdBtnNagyArak[i].Checked) ar = pizzak[i].ArNagy;
                        else throw new MissingFieldException();

                        db = int.Parse(txtDarabok[i].Text);

                        if (db < 0) throw new Exception();
                        txtDarabok[i].BackColor = Color.White;
                        osszeg += ar * db;
                    }         
                    catch (MissingFieldException mex)
                    {
                        MessageBox.Show("Nem választott méretet!", "Hiba");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hibásan adta meg a darabszámot!", "Hiba");
                        txtDarabok[i].BackColor = Color.Coral;
                        txtDarabok[i].Clear();
                    }      
                }
            }
            if (!vanKijeloles) MessageBox.Show("Nincs kijelölve semmi", "Figyelmeztetés");
            else txtFizetendo.Text = osszeg + " Ft";
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox valasztoGomb = (CheckBox)sender;
            int index = jeloloNegyzetek.IndexOf(valasztoGomb);
            if (valasztoGomb.Checked)
            {
                rdBtnNagyArak[index].Checked = true;
            }
            else
            {
                rdBtnKicsiArak[index].Checked = false;
                rdBtnNagyArak[index].Checked = false;
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in jeloloNegyzetek)
            {
                cb.Checked = false;
            }
            foreach (RadioButton rb in rdBtnKicsiArak)
            {
                rb.Checked = false;   
            }
            foreach (RadioButton rb in rdBtnNagyArak)
            {
                rb.Checked = false;
            }
            foreach (TextBox tb in txtDarabok)
            {
                tb.Clear();
                tb.BackColor = Color.White;
            }
            txtFizetendo.Clear();
        }
    }
    class Pizza
    {
        public string Nev { get; private set; }
        public int ArKicsi { get; set; }
        public int ArNagy { get; set; }

        public Pizza(string nev, int arKicsi, int arNagy)
        {
            Nev = nev;
            ArKicsi = arKicsi;
            ArNagy = arNagy;
        }
        public override string ToString()
        {
            return this.Nev;
        }
    }
}
