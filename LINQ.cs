using System;
using System.Collections.Generic;
using System.Linq;

namespace Name
{
    class person{
        public string Name { get; set;}
        public int Age { get; set;}
        public string City{ get; set;}
    }

    class Program
    {
        static void Main()
        {
            List<person> people  = new List<person> ()
            {
                new person {Name="Anila", Age=29, City="Wayanad"},
                new person {Name="Amala", Age=28, City="Wayanad"},
                new person {Name="AnuMol", Age=24, City="Palakad"},
                new person {Name="Arun Kumar", Age=27, City="Idukki"},
                new person {Name="Amal", Age=29, City="Idukki"},
            };

            string targetCity = "Wayanad";

            // var result=  people .Where (p=> p.Age>25).Select (p=> new {p.Name, p.City} );
            var result = from per in people where (per.Age>25 && per.City == targetCity) select new {per.Name, per.Age};

            foreach( var person in result)
            {
                Console.WriteLine($"The person is {person.Name}, And Age is {person.Age}");
            }

        }
    }
}
