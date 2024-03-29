﻿using NIOP_Fitness.Objektni_Model;
using System;
using System.CodeDom.Compiler;
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
    public partial class Vjezbe : Form
    {
        public int itemIndex;
        public Vjezbe()
        {
            InitializeComponent();
            PodatkovniKontekst podatkovniKontekstVjezbe = new PodatkovniKontekst();
            IEnumerable<string> vjezbe = podatkovniKontekstVjezbe.DohvacanjeVjezbe();

            foreach (string a in vjezbe) listBox1.Items.Add(a);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dodaj vjezbu button
            new DodavanjeVjezbe().ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //obrisi button
            PodatkovniKontekst podatkovniKontekstVjezbe = new PodatkovniKontekst();
            IEnumerable<string> vjezbe = podatkovniKontekstVjezbe.DohvacanjeVjezbe();
            List<String> listaVjezbi = new List<String>();
            int indexOsobe;
            int i = 0;
            indexOsobe = listBox1.SelectedIndex;

            foreach (String a in vjezbe)
            {

                if (i != indexOsobe)
                {
                    listaVjezbi.Add(a);
                }
                i++;
            }
            podatkovniKontekstVjezbe.SpremanjeVjezbe(listaVjezbi);
            Close();
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
                new izmjeniVjezbe(itemIndex).ShowDialog();
                Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //nazad button
            Close();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista, popis vjezbi
        }
    }
}
