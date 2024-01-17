using NIOP_Fitness.Forme;
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

namespace NIOP_Fitness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //osoba button
            new Osoba().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //vjezbe button
            new Vjezbe().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pokreni button

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //prekini button
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //izmjeni button
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista, popis treninga
            
        }
    }
}
