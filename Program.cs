using System.Net.Http.Headers;

namespace Class_Interihance.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car();
            bmw.Brand = "BMW";
            bmw.Model = "BMW M5";
            bmw.Year = 2022;
            bmw.Color = "Red";
            bmw.FuelCapacity = 18.6d;
            bmw.CurrentFuel = 13.7d;
            bmw.FuelFor1Km = 1.3d;
            bmw.Kilometr = 7d;
            //Console.WriteLine(bmw.ShowInfo());
            Console.WriteLine(bmw.Drive(7,5));
        }
    }
}