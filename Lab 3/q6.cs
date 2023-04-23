//Write a program in C# Sharp for joining the two different objects data using LINQ
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectJoinExample
{
    class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> persons = new List<Person>
            {
                new Person { PersonId = 1, Name = "Dawa", Age = 25 },
                new Person { PersonId = 2, Name = "Ashmin", Age = 30 },
                new Person { PersonId = 3, Name = "Bibek", Age = 35 }
            };

            
            List<City> cities = new List<City>
            {
                new City { CityId = 1, CityName = "KTM", Country = "Nepal" },
                new City { CityId = 2, CityName = "Berlin", Country = "Germany" },
                new City { CityId = 3, CityName = "Paris", Country = "France" }
            };

            
            var result = from person in persons
                join city in cities on person.PersonId equals city.CityId
                select new { person.Name, person.Age, city.CityName, city.Country };

            
            Console.WriteLine("Person Name\tAge\tCity Name\tCountry");
            foreach (var data in result)
            {
                Console.WriteLine($"{data.Name}\t\t{data.Age}\t{data.CityName}\t\t{data.Country}");
            }

            Console.ReadLine();
        }
    }
}
