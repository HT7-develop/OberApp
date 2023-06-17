using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberApp.Classes
{
    internal class Maaltijd
    {
        public int Tafelnummer { get; set; }

        public Maaltijd(int tafelnummer)
        {
            Tafelnummer = tafelnummer;
        }

        public int getTafelnummer()
        {
            return Tafelnummer;
        }

        public override string ToString()
        {
            return $"voor tafel {Tafelnummer}";
        }
    }
}
