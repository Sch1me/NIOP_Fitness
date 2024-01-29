using NIOP_Fitness.Forme;
using NIOP_Fitness.Objektni_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOP_Fitness
{
    internal class PodatkovniKontekst
    {

        public List<OsobaModel> osobe;
        public List<VjezbeModel> vjezbe;
        public List<TreningModel> treninzi;
        public List<String> linijaVjezbe;
        private void main(string[] args)
        {
            
        }

//funkcije koje koristimo za ubacivanje novih vjezbi i osoba
        public void DodavanjeVjezbe(String vjezba1)
        {
            List<String> popisVjezbi = new List<string>();

            StreamReader streamReaderVjezbe = new StreamReader("Popis Vjezbi.txt");
            while(!streamReaderVjezbe.EndOfStream) {
                popisVjezbi.Add(streamReaderVjezbe.ReadLine());
            }
            streamReaderVjezbe.Close();
            
            StreamWriter streamWriterVjezbe = new StreamWriter("Popis Vjezbi.txt");
            foreach (string a in popisVjezbi)
            {
                streamWriterVjezbe.WriteLine(a);
            }
            
            streamWriterVjezbe.Close();
        }
        public void DodavanjeOsobe(String osoba1)
        {
            //cita iz datoteke i sprema u polje
            List<String> popisOsoba = new List<string>();
            StreamReader streamReaderOsoba = new StreamReader("Popis Osoba.txt");
            while (!streamReaderOsoba.EndOfStream)
            {
                popisOsoba.Add(streamReaderOsoba.ReadLine());
            }
            streamReaderOsoba.Close();
            //ispisuje iz iz polja u datoteteku
            popisOsoba.Add(osoba1);
            StreamWriter streamWriterOsoba = new StreamWriter("Popis Osoba.txt");
            foreach(string a in popisOsoba)
            {
                streamWriterOsoba.WriteLine(a);
            }
            streamWriterOsoba.Close();
        }
        public void DodavanjeTreninga()
        {
            //upitno kako napraviti
        }
        public List<string> DohvacanjeVjezbe()
        {
            int i = 0;
            List<string> popisVjezbi = new List<string>();
            StreamReader streamReaderVjebze = new StreamReader("Popis Vjezbi.txt");
            while (!streamReaderVjebze.EndOfStream)
            {
                popisVjezbi.Add(streamReaderVjebze.ReadLine());
            }
            streamReaderVjebze.Close();
            return popisVjezbi;
        }
        public List<string> DohvacanjeOsoba()
        {
            int i = 0;
            List<String> popisOsoba = new List<string>();
            StreamReader streamReaderOsoba = new StreamReader ("Popis Osoba.txt");
            while (!streamReaderOsoba.EndOfStream)
            {
                popisOsoba.Add(streamReaderOsoba.ReadLine());
            }
            streamReaderOsoba.Close();
            return popisOsoba;
        }

    }
    
}
