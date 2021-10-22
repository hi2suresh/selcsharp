using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //var numbers = new List<int> {10,20,50,60,15,29 };
            //numbers.ForEach(num => Console.WriteLine(num));

            var cities = new List<City> { new City(1, "Delhi"), new City(2, "Perth"), new City(3, "Brisbane"), new City(4, "Sydney"), new City(5, "Bangalore") };

            var results = from c in cities
                          where c.Name.StartsWith("B")
                          select c;

            foreach (var item in results)
            {
                Console.WriteLine(item.Id + " : " + item.Name);
            }

        }
    }

    class City
    {
        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
