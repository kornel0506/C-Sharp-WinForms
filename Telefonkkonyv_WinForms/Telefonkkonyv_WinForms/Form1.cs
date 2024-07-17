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

namespace Telefonkkonyv_WinForms
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
            formadd.PersonAdded += OnPersonAdded;
            beolvas();
            Kiir();
        }
        public List<Person> emberek = new List<Person>();
        FormAdd formadd = new FormAdd();
        public void beolvas()
        {
            StreamReader sr = new StreamReader("Telefonkönyv.txt");

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] r = sor.Split(';');
                Person p = new Person(r[0], r[1], r[2], r[3], long.Parse(r[4]), r[5], r[6], r[7]);
                emberek.Add(p);
            }
            sr.Close();
        }
        public void Kiir()
        {
            foreach (Person p in emberek)
            {
                listBox1.Items.Add(p);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            TBoxNev.Text = emberek[index].Nev;
            TBoxCim.Text = emberek[index].Cim;
            TBoxFather.Text = emberek[index].ApjaNeve;
            TBoxMother.Text = emberek[index].AnyjaNeve;
            TBoxTel.Text = emberek[index].TelNum.ToString();
            TBoxEmail.Text = emberek[index].Email;
            TBoxSzemelyi.Text = emberek[index].SzemelyiSzam;
            if (emberek[index].Nem == "Férfi")
            {
                CBoxNem.Text = "Férfi";
            }
            else
            {
                CBoxNem.Text = "Nő";
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            formadd.ShowDialog();     
        }
        private void OnPersonAdded(object sender, PersonAddedEventArgs e)
        {
            emberek.Add(e.NewPerson);
            Kiir();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            emberek[index].Nev = TBoxNev.Text;
            emberek[index].Cim = TBoxCim.Text;
            emberek[index].ApjaNeve = TBoxFather.Text;
            emberek[index].ApjaNeve = TBoxMother.Text;
            emberek[index].TelNum = long.Parse(TBoxTel.Text);
            emberek[index].Nem = CBoxNem.SelectedText;
            emberek[index].Email = TBoxEmail.Text;
            emberek[index].SzemelyiSzam = TBoxSzemelyi.Text;

            Kiir();
            MessageBox.Show("Sikeres Módosítás!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            emberek.RemoveAt(listBox1.SelectedIndex);
            Kiir();
        }
        private void mentes()
        {
            StreamWriter sw = new StreamWriter("Telefonkönyv.txt");

            foreach (Person p in emberek) 
            {
                sw.WriteLine($"{p.Nev};{p.Cim};{p.ApjaNeve};{p.AnyjaNeve};{p.TelNum};{p.Nem};{p.Email};{p.SzemelyiSzam}");
            }
            sw.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mentes();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes)
            {
                mentes();
                this.Close();
            }
        }
    }
    public class Person
    {
        public string Nev;
        public string Cim;
        public string ApjaNeve;
        public string AnyjaNeve;
        public long TelNum;
        public string Nem;
        public string Email;
        public string SzemelyiSzam;

        public Person(string nev, string cim, string apjaNeve, string anyjaNeve, long telNum, string nem, string email, string szemelyiSzam)
        {
            Nev = nev;
            Cim = cim;
            ApjaNeve = apjaNeve;
            AnyjaNeve = anyjaNeve;
            TelNum = telNum;
            Nem = nem;
            Email = email;
            SzemelyiSzam = szemelyiSzam;
        }

        public override string ToString()
        {
            return $"{Nev}  {TelNum}";
        }
    }

}
