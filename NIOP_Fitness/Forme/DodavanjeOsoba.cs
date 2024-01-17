using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NIOP_Fitness.Forme
{
    public partial class DodavanjeOsoba : Form
    {
        public DodavanjeOsoba()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //nazad button
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dodaj osobu button
            PodatkovniKontekst podatkovniKontekstOsoba = new PodatkovniKontekst();
            if (textBox1.Text.ToString()=="" || textBox3.Text.ToString()== ""|| textBox4.Text.ToString() == "" || textBox5.Text.ToString() == "")
            {
                MessageBox.Show("Nisi unio sve");
            }
            else
            {
                String varijabla = $"{textBox1.Text} - {textBox3.Text} - {textBox4.Text} - {textBox5.Text}";
                podatkovniKontekstOsoba.DodavanjeOsobe(varijabla);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //unesi ime textBox
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //unesi prezime textBox
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //unesi OIB textBox
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //unesi godine textBNox
        }
    }
}
