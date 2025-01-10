using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test_10_01_2025
{
    class Person
    {
        public string Geschlecht {  get; set; }
        public DateTime Geburtstag { get; set; }

        public Person(DateTime geburtstag, string geschlecht)
        {
            Geburtstag = geburtstag;
            Geschlecht = geschlecht;
        }
    }
}
