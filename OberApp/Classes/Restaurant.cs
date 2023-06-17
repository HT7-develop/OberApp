using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberApp.Classes
{
    internal class Restaurant
    {
        public const int AANTALBESTELLINGEN = 10;
        public const int AANTALTAFELS = 15;
        public Balie Balie { get; set; }
        public Ober Ober { get; set; }

        public Restaurant()
        {
            Balie = new Balie();
            Balie.GenereerMaaltijden();

            Ober = new Ober(Balie);
        }

        public void start()
        {
            Ober.BezorgMaaltijden();
        }

    }
}
