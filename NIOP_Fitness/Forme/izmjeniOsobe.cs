﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOP_Fitness.Forme
{
    public partial class izmjeniOsobe : Form
    {
        int index;
        public izmjeniOsobe()
        {
            InitializeComponent();
            
        }
        public izmjeniOsobe(int indexPomoc)
        {
            InitializeComponent();
            index = indexPomoc;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nazad button
            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ime osobe
        }

        private void prezimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OIBTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void godineTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void izmjeniButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            PodatkovniKontekst podatkovniKontekstOsobe = new PodatkovniKontekst();
            List<string> popisOsoba = podatkovniKontekstOsobe.DohvacanjeOsoba();
            String variabla = $"{textBox1.Text} - {prezimeTextBox.Text} - {OIBTxtBox.Text} - {godineTxtBox.Text}";

            popisOsoba[index] = variabla;

            podatkovniKontekstOsobe.SpremanjeOsobe(popisOsoba);

        }
       
    }
}
