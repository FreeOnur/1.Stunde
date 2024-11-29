using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
    class Animal : Lebewesen
    {
        public string Name { get; set; }
        public Animal(string name, DateTime birthDate) : base(birthDate)
        {
            
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
