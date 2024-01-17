using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOP_Fitness.Objektni_Model
{
    internal class TreningModel : IComparable
    {
        OsobaModel osoba { get; set; }
        VjezbeModel vjezbe { get; set; }
        public string opisTreninga { get; set; }
        public DateTime trajanjeTreninga { get; set; }
        public string nazivTreninga { get; set; }
        

        public override string ToString()
        {
            return "NAZIV TRENINGA - "+nazivTreninga+"\nOsoba: "+osoba+"\nOpis treninga: "+opisTreninga+"\nTrajanje Treninga: "+trajanjeTreninga;
        }

        public int CompareTo(object obj)
        {
            int rez = nazivTreninga.CompareTo(((TreningModel)obj).nazivTreninga);
            return rez;
        }


    }
}
