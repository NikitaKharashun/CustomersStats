using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_CustomersStat.Elements;

namespace Nikita_CustomersStat
{
    class Program
    {
        static void CustomersFromAsia()
        {
            var asiaStat = from c in Customer.IniCustomer() where c.Region.Equals("Азия") select c;

            foreach (var c in asiaStat)
                Console.WriteLine(c);
        }

        static void AsianCities()
        {
            var asiaCitiesStat = from c in Customer.IniCustomer() where c.Region.Equals("Азия") select c.City;

            var cities = new List<string>();
            foreach (var c in asiaCitiesStat)
            {
                cities.Add(c);
                Console.WriteLine(c);
            }
        }

        static void GetRegionStat()
        {
            var regionStat = Customer.IniCustomer().OrderByDescending(x => x.Sales);

            foreach (var region in regionStat)        
                Console.WriteLine($"{region.Region} => {region.Sales}");          
        }

        static void Main(string[] args)
        {
            CustomersFromAsia();
            Console.WriteLine(new string('-', 32));
            AsianCities();
            Console.WriteLine(new string('-', 32));
            GetRegionStat();

            Console.ReadKey();
        }
    }
}
