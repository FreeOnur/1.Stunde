using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10_01_2025
{
    class Schule
    {
        public List<Schueler> Schueler = new List<Schueler>();

        public void AddSchuelerToSchule(Schueler schueler)
        {
            Schueler.Add(schueler);
            Console.WriteLine("Es wurde neues Schüler hinzugefügt");
        }
    }
}
