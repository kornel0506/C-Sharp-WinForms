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

namespace Retoxikalo
{
    public partial class Form1 : Form
    {
        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image>();
        private int kepekSzama = 1;

        private ItalLapForm italForm = new ItalLapForm();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "arlap.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "konyveles.txt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a képek létrehozásakor", "Hiba");
            }
            MessageBox.Show("Nem sikerült befejeznem a feladatot ezért akadnak még benne hibák.");
        }
        private void KepBetoltes()
        {
            Image kep;
            for (int i = 0; i <= kepekSzama; i++)
            {
                kep = Image.FromFile("kep" + i + ".jpg");
                kepek.Add(kep);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBevitel(sr);

                    itallapToolStripMenuItem.Enabled = true;
                    SaveToolStripMenuItem.Enabled = true;

                    italForm.ArlapotIr(italok);
                    italForm.ShowDialog();
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
            string sor = sr.ReadLine();
            string[] adatok;
            while (sor != null)
            {
                adatok = sor.Split(';');
                italok.Add(new Ital(adatok[0], int.Parse(adatok[1])));
                sor = sr.ReadLine();
            }
        }

        private void itallapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italForm.ArlapotIr(italok);
            italForm.ShowDialog();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
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
            foreach(Ital item in italok)
            {
                sw.WriteLine(item.Konyvelesbe());
            }
        }

        private void GaleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaleriaForm galeriaForm = new GaleriaForm();
            galeriaForm.Atad(kepek);
            galeriaForm.Show();
        }
    }
    class Ital
    {
        public string ItalNev { get; set; }
        public int EgysegAr { get; set; }
        public int Mennyiseg { get; private set; }
        public int OsszMennyiseg { get; private set; }
        public string Bevetel { get; private set; }

        public Ital(string italNev, int egysegAr)
        {
            ItalNev = italNev;
            EgysegAr = egysegAr;
        }

        public void Rendel(int db)
        {
            Mennyiseg += db;
        }

        public int Fizetendo()
        {
            return Mennyiseg * EgysegAr;
        }

        public void Fizet()
        {
            OsszMennyiseg += Mennyiseg;
            Bevetel += Mennyiseg * EgysegAr;
            Mennyiseg = 0;
        }

        public string Arlistaba()
        {
            return ItalNev + " (" + EgysegAr + " Ft)";
        }

        public string Konyvelesbe()
        {
            return ItalNev + ";" + OsszMennyiseg + ";" + Bevetel;
        }

        public override string ToString()
        {
            return Mennyiseg.ToString().PadLeft(4) + " " + ItalNev.PadRight(35) +
                   Fizetendo().ToString().PadLeft(10) + " Ft";
        }
    }
}
