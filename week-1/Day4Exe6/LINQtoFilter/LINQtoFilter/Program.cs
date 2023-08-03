namespace LINQtoFilter
{
    internal class Program
    {
        public class Person
        {
            public int Age { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public Person(string firstName, string lastName, int age)
            {

                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
            static void Main(string[] args)
            {
                List<Person> people = new List<Person>();

                people.Add(new Person("Drashti", "Sataki", 17));
                people.Add(new Person("Rushi", "Sheth", 22));
                people.Add(new Person("Nandani", "Katwal", 18));
                people.Add(new Person("Nikhil", "Dhone", 23));
                people.Add(new Person("Anushka", "Saxena", 21));

                int ageFilter = 18;
                List<Person> filteredList = people.Where(p => p.Age >+ageFilter).ToList();

                List<Person> sortedList = filteredList.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();


                foreach (var obj in filteredList)
                {
                    Console.WriteLine($"Name: {obj.LastName} {obj.FirstName} {obj.Age}");
                }
               foreach (var obj in sortedList) { 
                Console.WriteLine($"Name:  { obj.LastName} {obj.FirstName}");
                }
            }
        }
    }
}