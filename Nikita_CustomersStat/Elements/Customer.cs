using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_CustomersStat.Elements
{
    class Customer
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public decimal Sales { get; set; }

        public Customer(string id, string city, string country, string region, decimal sales)
        {
            ID = id;
            City = city;
            Country = country;
            Region = region;
            Sales = sales;
        }

        public override string ToString() => $"ID: {ID} \nГород: {City} \nСтрана: {Country} \nРегион:{Region} \nПродажи:{Sales}";

        public static List<Customer> IniCustomer()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer("A", "Нью Йорк", "США", "Америка", 9999),
                new Customer("B", "Мумбаи", "Индия", "Азия", 8888),
                new Customer("C", "Токио", "Япония", "Азия", 7777),
                new Customer("D", "Дейли", "Индия", "Азия", 6666),
                new Customer("E", "Сан-Пауло", "Бразилия", "Америка", 55),
                new Customer("F", "Москва", "Россия", "Европа", 4444),
                new Customer("G", "Сеул", "Корея", "Азия", 2222),
                new Customer("H", "Минск", "Беларусь", "Европа", 9999),
                new Customer("I", "Берлин", "Германия", "Европа", 500),
                new Customer("J", "Мадрид", "Испания", "Европа", 3000)
            };
            return customers;
        }

    }
}
