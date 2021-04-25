using System;

namespace CityDistances
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new CityDistances();
            Console.WriteLine(c.GetDistance("Kiev", "Kharkov"));
        }
    }
}
