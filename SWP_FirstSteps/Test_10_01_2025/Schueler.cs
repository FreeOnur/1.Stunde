using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10_01_2025
{
    class Schueler : Person
    {
        public string Klasse { get; set; }
        public Schueler(string klasse, DateTime geburtstag, string geschlecht) : base(geburtstag, geschlecht)
        {
            Klasse = klasse;
        }
    }
}
