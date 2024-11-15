using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstCat
{
    class Cat
    {
        private string? _Color;
        private DateTime _BirthDate;
        public string setColor
        {
            get
            {
                return _Color;
            }
            
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }
        public string setName { get; set; }
        public int setAge { get { return (DateTime.Now.Year - _BirthDate.Year); } }
        public Cat(DateTime birthdate, string color = "Nicht Verfügbar", string name1 = "Nicht Verfügbar")
        {
            _BirthDate = birthdate;
            _Color = color;
            setName = name1;
        }
        public override string ToString()
        {
            return $"Name: {setName}, Farbe: {setColor}, Alter: {setAge}";
        }
    }
}
 