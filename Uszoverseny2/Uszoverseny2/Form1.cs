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
        private List<Versenyzo> versenyzok = new List<Versenyzo>();
        private VersenyForm versenyForm = new VersenyForm();
        private EredmenyForm eredmenyForm = new EredmenyForm();
        private void megnyitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBevitel(sr);
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
    }

    class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public string OrszagNev { get; private set; }
        public string ZaszloNev { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        private static int sorSzam;

        public Versenyzo(string nev, string orszagNev, string zaszloNev)
        {
            this.Nev = nev;
            this.OrszagNev = orszagNev;
            this.ZaszloNev = zaszloNev;
            sorSzam++;
            this.Rajtszam = (sorSzam < 10)?("0" + sorSzam): sorSzam.ToString();
        }

        public override string ToString()
        {
            return $"{Nev}";
        }

        public void Versenyez(TimeSpan idoEredmeny)
        {
            this.IdoEredmeny = idoEredmeny;
        }
    }
}
