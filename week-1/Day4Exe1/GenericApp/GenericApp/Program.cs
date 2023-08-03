using System.Runtime.InteropServices;

namespace GenericApp
{

    class Stack<T>
    {
        private List<T> list;
        public Stack()
        {
            list = new List<T>();
        }

        public void Push(T item)
        {
            list.Add(item);
            Console.WriteLine(item);
        }
        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty !!");
            }
            int lastElement = list.Count - 1;
            T item = list[lastElement];
            //list.RemoveAt(lastElement);
            return item;
        }
        public bool Contains()
        {
            return list.Count == 0;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);

            intStack.Push(2);

            intStack.Push(3);

            Console.WriteLine("Pop:" + intStack.Pop());

            Stack<string> strStack = new Stack<string>();
            strStack.Push("Hey");

            strStack.Push("Drashti");

            strStack.Push("Here");
            Console.WriteLine("Pop:" + strStack.Pop());

            Stack<animals> objStack = new Stack<animals>();
            {
                animals animal1 = new animals("Kangaroo", "Huppy" , "Australlia");
                animals animal2 = new animals("Elephant",  "Gray" ,"Africa");
                animals animal3 = new animals("Lion", "Simba" , "India");
                objStack.Push(animal1);
                objStack.Push(animal2);
                objStack.Push(animal3);

                Console.WriteLine("Pop: " + objStack.Pop());

            }
          


        }
        class animals
        {
            public string Animal { get; set; }
            public string Name { get; set; }
            public string Country { get; set; }

            public animals(string animal, string name, string country)
            {
                Animal = animal;
                Name = name;
                Country = country;
            }
            public override string ToString()
            {
                return $"Animal: {Animal}, Name: {Name}, Country: {Country}";
            }


        }
    }
}