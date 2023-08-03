using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace LINQMethod
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("Drashti", 21, "Surat"));
            people.Add(new Person("Rushi", 22, "Godhra"));
            people.Add(new Person("Nandani", 21, "Vadodara"));
            people.Add(new Person("Nikhil", 23, "Pune"));
            people.Add(new Person("Anushka", 21, "Delhi"));


            int ageFilter = 21;
            List<Person> peopleAboveAge = people.Where(p => p.Age > ageFilter).ToList();

            List< Person > sortedName = people.OrderBy(p => p.Name).ToList();

            var sortedList = people.Select (p=> new { p.Name, p.City }).ToList();

            foreach (var obj in sortedList)
            {
                Console.WriteLine($"Name: {obj.Name}");
                Console.WriteLine($"City: {obj.City}");
                Console.WriteLine();
            }
        }
    }
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Person (string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }
}