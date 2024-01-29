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

namespace NIOP_Fitness.Forme
{
    public partial class Osoba : Form
    {
        public int itemIndex;
        public Osoba()
        {

            InitializeComponent();

            PodatkovniKontekst podatkovnikontekstOsobe = new PodatkovniKontekst();
            IEnumerable<string> osobe = podatkovnikontekstOsobe.DohvacanjeOsoba();

            foreach (string osoba in osobe) listBox1.Items.Add(osoba);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dodaj osobu
            Close();
            new DodavanjeOsoba().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //obrisi osobu
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //izmjeni button
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                itemIndex = listBox1.SelectedIndex;
                new izmjeniOsobe().ShowDialog();
                Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //nazad button
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista, popis osoba
        }
    }
}
