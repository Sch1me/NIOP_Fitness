using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOP_Fitness.Forme
{
    public partial class izmjeniVjezbe : Form
    {
        public izmjeniVjezbe()
        {
            InitializeComponent();
        }

        private void izmjeniButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            PodatkovniKontekst podatkovniKontekstVjezbe = new PodatkovniKontekst();
            List<string> popisVjezbi = podatkovniKontekstVjezbe.DohvacanjeVjezbe();
            String variabla = $"{imeTextBox.Text} - {ponavljanjaTextBox.Text} - {serijeTextBox.Text} - {vrstaVjezbeTextBox.Text}";

            int index = uzmiIndex();

            while(i != index)
            {
                //izjednaci i sa indexom
                i++;
            }
            if(i == index)
            {
                popisVjezbi[i] = variabla;
            }
            j = i;
            i = 0;
            while (j >= 0)
            {
                podatkovniKontekstVjezbe.DodavanjeVjezbe(popisVjezbi[i]);
                i++;
                j--;
            }
        }
        private int uzmiIndex()
        {
            Vjezbe vjezbe = new Vjezbe();
            int itemIndex = vjezbe.itemIndex;
            return itemIndex;
        }
        private void nazadButton_Click(object sender, EventArgs e)
        {

        }

        private void imeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ponavljanjaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serijeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vrstaVjezbeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
