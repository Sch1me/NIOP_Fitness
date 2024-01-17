using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace NIOP_Fitness.Objektni_Model
{
    internal class OsobaModel : IComparable
    {
        public string ime { get; set; }
        public string prezime { get; set;}
        public string OIB { get; set;}
        public int godine { get; set;}


        public override string ToString()
        {
            return "Ime: " + ime + "\nPrezime: " + prezime + "\nGodine: " + godine.ToString();
        }
        public int CompareTo(object obj)
        {
            int rez = this.prezime.CompareTo(((OsobaModel)obj).prezime);
            return rez;
        }

    }
}
