using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Interihance.Models
{
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public double Kilometr;
        public double Fuel;

        public Car()
        {
        }

        public string ShowInfo()
        {
            return $"{Brand} { Model} { FuelCapacity }  { FuelFor1Km }  {CurrentFuel} {Color} {Year}";
            
        }

        public Car(string color, int year, string brand, string model, double fuelcapacity, double fuelfor1km, double currentfuel, double kilometr, double fuel) : base(color, year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelcapacity;
            FuelFor1Km = fuelfor1km;
            CurrentFuel = currentfuel;
            Kilometr = kilometr;
            Fuel = fuel;

        }
        public double Drive(double kilometr,double fuel) 
        {
            if (kilometr == 7d)
            {
                fuel = CurrentFuel - 13d;
            }
            return fuel;
        }    
    }    
}




