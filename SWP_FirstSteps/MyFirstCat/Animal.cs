using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
    class Animal : Lebewesen
    {
        public Animal(string name, DateTime birthDate, string color) : base(birthDate, color, name)
        {
            
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
