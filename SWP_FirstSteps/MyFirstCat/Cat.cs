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
        private string? _Color = null;
        private DateTime _BirthDate;
        private string name;
        public string Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
            }
        }
            

        public int Age { get { return (DateTime.Now.Year - _BirthDate.Year); } }
        public Cat(DateTime birthdate, string color = "Nicht Verfügbar", string name1 = "Nicht Verfügbar")
        {
            _BirthDate = birthdate;
            _Color = color;
            name = name1;

        }
        

    }
}
