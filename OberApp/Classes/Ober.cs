using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberApp.Classes
{
    internal class Ober
    {
        public Balie Balie { get; set; }
        public Medewerker Medewerker { get; set; }

        public Ober(Balie balie)
        {
            Balie = balie;
            Medewerker = new Medewerker();
        }

        public Maaltijd BezorgMaaltijd(Maaltijd m)
        {
            Console.WriteLine($"De ober {Medewerker.Naam} bezorgt de maaltijd {m}.");
            return m;
        }


        public void BezorgMaaltijden()
        {
            int aantalTeBezorgenMaaltijden = Balie.ToonAantalMaaltijden();
            int bezorgdeMaaltijden = 0;

            while (bezorgdeMaaltijden < aantalTeBezorgenMaaltijden)
            {
                Console.WriteLine($"Aantal te bezorgen maaltijden: {aantalTeBezorgenMaaltijden - bezorgdeMaaltijden}");
                Maaltijd nieuweMaaltijd = BezorgMaaltijd(Balie.PakMaaltijd());
                Balie.PlaatsMaaltijd(nieuweMaaltijd);
                bezorgdeMaaltijden++;
            }
        }

    }
}
