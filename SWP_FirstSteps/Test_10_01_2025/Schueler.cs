using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10_01_2025
{
    public class Schueler : Person
    {
        public string Klasse { get; set; }
        public List<string> klassen = new List<string>();
        DateTime Geburtstag;

        public void AddKlasse(string klasse)
        {
            if (!klassen.Contains(klasse)) 
            {
                klassen.Add(klasse);
            }
        }
        public int Alter
        {
            get
            {
                int alter = DateTime.Today.Year - Geburtstag.Year;
                return alter;
            }
            set { }
        }
        public void ZähleSchülerProKlasse(List<Schueler> schuelerListe)
        {
            foreach (Schueler schueler in schuelerListe)
            {
                if (!klassen.Contains(schueler.Klasse))
                {
                    klassen.Add(schueler.Klasse);
                }
            }
            foreach (string klasse in klassen)
            {
                int anzahl = 0;
                foreach (Schueler schueler in schuelerListe)
                {
                    if (schueler.Klasse == klasse)
                    {
                        anzahl++;
                    }
                }
                Console.WriteLine($"Klasse {klasse}: {anzahl} Schüler");
            }
        }
        public Schueler(string klasse, DateTime geburttag, string geschlecht) : base(geburttag, geschlecht)
        {
            Geburtstag = geburttag;
            Klasse = klasse;
            AddKlasse(klasse);
        }
    }
}
