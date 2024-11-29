using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
    class Lebewesen
    {
        public DateTime _BirthDate { get; set; }

        public Lebewesen(DateTime birthDate)
        {
            
            _BirthDate = birthDate;
        }
    }
}
