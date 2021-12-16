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

        static void Main(string[] args)
        {
            Queries.GetReginInfo("Азия");
            Console.WriteLine(new string('-', 32));

            Queries.GetCitiesInfo("Азия");
            Console.WriteLine(new string('-', 32));

            Queries.GetAllInfo();

            Console.ReadKey();
        }
    }
}
