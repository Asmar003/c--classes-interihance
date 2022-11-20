using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Class_Interihance.Models
{
    internal class Vehicle
    {
        public string Color;
        public int Year;

        public Vehicle()
        {
        }

        public Vehicle(string color, int year)
        {
            Color = color;
            Year = year;
        }
    }
}
