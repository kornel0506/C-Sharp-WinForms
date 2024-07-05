using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diakok2 { 

    public partial class Form1 : Form
    {
        List<Button> btnEvek = new List<Button>();
        List<int> evek = new List<int>();

        private int kezdoX = 10;
        private int kezdoY = 10;
        private int btnXKoz = 80;
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
            lblDiak.Text = "";
        }
        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
        }
        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    Adatbeolvasas(fajlNev);
                    FelrakEvek();
                    GombBeallitas(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor!", "Hiba");
                }
            }
        }
        private void Adatbeolvasas(string fajlNev)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fajlNev);

                while (!sr.EndOfStream)
                {
                    string adat = sr.ReadLine();
                    Feldolgoz(adat);
                }
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
        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');

            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            lstDiakok.Items.Add(diak);
            if (!evek.Contains(diak.Szuletesi_ev)) evek.Add(diak.Szuletesi_ev);
        }

        private void FelrakEvek()
        {
            pnlEvek.Controls.Clear();
            Button btn;
            evek.Sort();
            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXKoz, kezdoY);
                btn.Text = evek[i].ToString();
                btn.BackColor = Color.White;

                btn.Click += new System.EventHandler(Kivalaszt);

                pnlEvek.Controls.Add(btn);

                btnEvek.Add(btn);
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            Adatbevitel();
        }
        private void Kivalaszt(object sender, EventArgs e)
        {
            int ev = int.Parse((sender as Button).Text);

            lstEredmeny.Items.Clear();
            foreach (Diak diak in lstDiakok.Items)
            {
                if (diak.Szuletesi_ev == ev) lstEredmeny.Items.Add(diak);
            }
        }

        private void lstEredmeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstEredmeny.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.Szuletesi_ev;
        }
    }

    class Diak
    {
        public string Nev;
        public string Tanulmanyi_kod;
        public int Szuletesi_ev;

        public Diak(string nev, string tanulmanyi_kod, int szuletesi_ev)
        {
            this.Nev = nev;
            this.Tanulmanyi_kod = tanulmanyi_kod;
            this.Szuletesi_ev = szuletesi_ev;
        }

        public override string ToString()
        {
            return $"{this.Nev} ({this.Tanulmanyi_kod})";
        }
    }
}
