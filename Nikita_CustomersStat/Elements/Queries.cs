using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_CustomersStat.Elements
{
    class Queries
    {
        public static void GetReginInfo(string region)
        {
            var regionStat = from c in Customer.IniCustomer() where c.Region.Equals(region) select c;

            Console.WriteLine($"Статистика по региону {region}");

            foreach (var item in regionStat)
                Console.WriteLine($"{item}");
        }


        public static void GetCitiesInfo(string region)
        {          
            var asiaCitiesStat = from c in Customer.IniCustomer() where c.Region.Equals(region) select c.City;

            Console.WriteLine($"Города из региона {region} в которых проживают покупатели: ");

            var cities = new List<string>();

            foreach (var c in asiaCitiesStat)
            {
                cities.Add(c);
                Console.WriteLine($"{c} ");
            }
        }


        public static void GetAllInfo()
        {
            var regionStat = Customer.IniCustomer().OrderByDescending(x => x.Sales);

            foreach (var region in regionStat)
                Console.WriteLine($"{region.Region} => {region.Sales}");
        }
    }
}
