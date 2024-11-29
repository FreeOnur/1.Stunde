using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
// eine eltern klasse animal die eine interne variable name hat die klasse leitet von dem tier ab und erbt somit das Attribut Name
namespace MyFirstCat
{
    class Cat : Animal
    {
        
        public string Color  { get; set; }
        public int Age { get { return (DateTime.Now.Year - _BirthDate.Year); } }

        public Cat(DateTime birthDate,string color = "Nicht Verfügbar", string name = "nicht Verfügbar") : base(name,birthDate)
        {
            
            Color = color;          
        }
        public override string ToString()
        {
            return $"Name: {Name}, Farbe: {Color}, Alter: {Age}";
        }
    }
}
 