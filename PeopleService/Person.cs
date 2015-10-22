using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleService
{
    public class Person
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        public string Middle { get; set; }

    }

    public class Address
    {
        public int Id { get; set; }
        public string  Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }


    public class PeopleConstants
    {
        public static string[] LastNames = new string[] {"Lockrem","Black","Milfert", "Smith", "Jones", "Johnson", "Peterson", "Jameson", "Boyer", "Roy" };
        public static string[] FirstNames = new string[] {"William", "Matt", "Lisa","Arianna", "Kristina","Tyler", "Ryan", "Dylan", "Abby", "Kayla", "Kirsty", "Shayne" };
        public static string[] Middles = new string[] {"S", "E", "T", "H", "A", "C", "L", "D", "M" };
        public static int[] Ages = new int[] { 24, 16, 22, 34, 45, 43, 19, 21, 60 };
        public static string[] Streets = new string[] {"1123 Main St","3456 First Ave","654 Second St","232 Round Way","124 Third Blvd","444 Fourth Ave" };
        public static string[] Cities = new string[] {"Funny", "Purpose", "Brave", "Unknown", "Jedi", "Hero" };
        public static string[] States = new string[] { "FL", "VA", "CA", "WA", "ME", "NY"};
        public static string[] ZipCodes = new string[] { "12345", "34568", "94759", "23444", "28474", "19373", "88774", "21344" };
        public Person CreatePerson()
        {
            Random rnd = RandomProvider.GetThreadRandom();
            var fn = rnd.Next(0, FirstNames.Length);
            var ln = rnd.Next(0, LastNames.Length);
            var a = rnd.Next(0, Ages.Length);
            var m = rnd.Next(0, Middles.Length);

            return new Person() { First = FirstNames[fn], Last = LastNames[ln], Age = Ages[a], Middle = Middles[m] };
        }

        public Address CreateAddress()
        {
            Random rnd = RandomProvider.GetThreadRandom();
            var str = rnd.Next(0, Streets.Length);
            var cty = rnd.Next(0, Cities.Length);
            var state = rnd.Next(0, States.Length);
            

            return new Address() { City = Cities[cty], State = States[state], Street = Streets[str], ZipCode = ZipCodes[state] };
        }
    }


}
