using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDistances
{
    class CityDistances
    {
        private LinkedList<City> cities;

        public CityDistances()
        {
            cities = new LinkedList<City>();
            cities.AddLast(new City { Name = "Kiev", Distance = 0 });
            cities.AddLast(new City { Name = "Borispol", Distance = 38 });
            cities.AddLast(new City { Name = "Piryatin", Distance = 127 });
            cities.AddLast(new City { Name = "Lubny", Distance = 47 });
            cities.AddLast(new City { Name = "Horol", Distance = 41 });
            cities.AddLast(new City { Name = "Reshetylivka", Distance = 73 });
            cities.AddLast(new City { Name = "Poltava", Distance = 39 });
            cities.AddLast(new City { Name = "Chutovo", Distance = 52 });
            cities.AddLast(new City { Name = "Valki", Distance = 38 });
            cities.AddLast(new City { Name = "Lubotin", Distance = 37 });
            cities.AddLast(new City { Name = "Pisochyn", Distance = 15 });
            cities.AddLast(new City { Name = "Kharkov", Distance = 11 });
        }

        public int GetDistance(string cityFrom, string cityTo)
        {
            var i = cities.First;
            var res = 0;
            string end = default;
            var inRange = false;

            while (i != null)
            {
                if (inRange)
                {
                    res += i.Value.Distance;

                    if (i.Value.Name == end)
                        break;
                }
                else
                {
                    if (i.Value.Name == cityFrom)
                    {
                        end = cityTo;
                        inRange = true;
                    }
                    if (i.Value.Name == cityTo)
                    {
                        end = cityFrom;
                        inRange = true;
                    }
                }

                i = i.Next;
            }

            return res;
        } 
    }

}
