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

namespace Uszoverseny2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Versenyzo> versenyzok = new List<Versenyzo>();
        private VersenyForm versenyForm = new VersenyForm();
        private EredmenyForm eredmenyForm = new EredmenyForm();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBevitel(sr);
                    raceToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "hibaüzenet a fejlesztő számára");
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

        private void AdatBevitel(StreamReader sr)
        {
            string sor;
            string[] tordelt;
            string nev, orszag, zaszlo;

            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                if (sor != "")
                {
                    tordelt = sor.Split(';');
                    nev = tordelt[0];
                    orszag = tordelt[1];
                    zaszlo = tordelt[2];
                    versenyzok.Add(new Versenyzo(nev, orszag, zaszlo));
                }
            }
        }
        private void nevjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keszito = "Bitbajnok";
            NevjegyForm about = new NevjegyForm(keszito);
            about.ShowDialog();
        }

        private void kilépésAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void raceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            versenyForm.Fogad(versenyzok);

            this.Hide();
            versenyForm.ShowDialog();
            this.Show();

            resultToolStripMenuItem.Enabled = true;
            raceToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = true;
            int tav = versenyForm.Tav;
            string uszasNem = versenyForm.UszasNem;
            eredmenyForm.EredmenyHirdetes(uszasNem, tav, versenyzok);
        }
        
        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eredmenyForm.ShowDialog();
            this.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    sw = new StreamWriter(fajlNev);
                    FajlbaIr(sw);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl írásakor", "Hiba");
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
        }
        private void FajlbaIr(StreamWriter sw)
        {
            foreach (var versenyzo in versenyzok)
            {
                sw.WriteLine(versenyzo.Rajtszam + ";" + versenyzo.Nev + ";"
                             + versenyzo.OrszagNev + ";" + versenyzo.IdoEredmeny);
            }
        }
    }
}
