using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telefonkkonyv_WinForms;

namespace Telefonkkonyv_WinForms
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        public event EventHandler<PersonAddedEventArgs> PersonAdded;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person p = new Person(TBoxNev.Text, TBoxCim.Text, TBoxFather.Text, TBoxMother.Text, long.Parse(TBoxTel.Text), CBoxNem.Text, TBoxEmail.Text, TBoxSzemelyi.Text);

                PersonAdded?.Invoke(this, new PersonAddedEventArgs { NewPerson = p });

                MessageBox.Show("Személy hozzáadva!", "Siker");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Helyesen töltse ki a mezőket!", "Hiba");
            }
        }
    }
    public class PersonAddedEventArgs : EventArgs
    {
        public Person NewPerson { get; set; }
    }
}
