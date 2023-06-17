using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberApp.Classes
{
    internal class Balie
    {
        public List<Maaltijd> Maaltijden { get; set; }

        public Balie()
        {
            Maaltijden = new List<Maaltijd>();
        }

        public bool ErZijnNogMaaltijden()
        {
            if (Maaltijden.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GenereerMaaltijden()
        {
            Random random = new Random();

            for (int i = 0; i < Restaurant.AANTALBESTELLINGEN; i++)
            {
                int rndTafelnummer = random.Next(1, Restaurant.AANTALTAFELS);
                //Console.WriteLine($"Tafel Nummer: {rndTafelnummer}");
                Maaltijd m = new Maaltijd(rndTafelnummer);

                PlaatsMaaltijd(m);
            }
        }

        public Maaltijd PakMaaltijd()
        {
            Maaltijd m = Maaltijden.First();
            Maaltijden.Remove(m);
            return m;
        }

        public void PlaatsMaaltijd(Maaltijd m)
        {
            Maaltijden.Add(new Maaltijd(m.getTafelnummer()));
            string listAsString = string.Join(", ", Maaltijden);
            //Console.WriteLine($"PlaatsMaaltijd Method: {listAsString}");
        }

        public int ToonAantalMaaltijden()
        {
            string listAsString = string.Join(", ", Maaltijden);
            //Console.WriteLine(listAsString);

            return Maaltijden.Count;
        }
    }
}
