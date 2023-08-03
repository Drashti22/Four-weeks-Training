namespace SumDebugApp
{
    internal class Program
    {
        static int MultiplyMethod(int num1, int num2)
        {
            int total;
            total = num1*num2;
            return total;
        }
        static int SumMethod(int num1, int num2)
        {
            int total;
            total = num1 - num2;
            return total;
        }
        static void Main(string[] args)
        {
            Console.Write("\n\nPlease, calculate the sum of two numbers :\n");
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", SumMethod(n1, n2));
            Console.Write("\n\nPlease, calculate the multiplication of two numbers :\n");
            Console.Write("Enter a number: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe multiplication of two numbers is : {0} \n", MultiplyMethod(m1, m2));
            Console.ReadLine();

        }
    }
}