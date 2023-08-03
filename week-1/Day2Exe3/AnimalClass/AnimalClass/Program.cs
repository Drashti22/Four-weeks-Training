namespace AnimalClass
{
    internal class Program
    {
        abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public abstract void MakeSound();
        }
       
        class Dog: Animal, IMovable {
          public override void MakeSound() {
                Console.WriteLine("Woof Woof");
            }
            public void Move()
            {
                Console.WriteLine("Dog moves like a plane.");
            }

            }
        class Cat : Animal, IMovable { 
    
            public override void MakeSound()
            {
                Console.WriteLine("Meow Meow");
            }
            public void Move()
            {
                Console.WriteLine("Cat moves like a attacker.");
            }
        }

        interface IMovable
        {
            void Move();
        }
        

        static void Main(string[] args)
        {
            List<Animal> animals =new List<Animal>();
            Dog dog = new Dog();
            animals.Add(new Dog { Name = "Guppy" , Age = 5});
            Cat cat = new Cat();
            animals.Add(new Dog { Name = "Toasty", Age = 2 });
            animals.Add(cat);

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Name : {animal.Name}");
                Console.WriteLine($"Name : {animal.Age}");

                animal.MakeSound();

                if (animal is IMovable movable)
                {
                    movable.Move();
                }
            }
        }
    }
}