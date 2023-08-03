using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace LINQOpearationsAPP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            int[] numbers = { 4, 15, 9, 22, 8, 11, 3, 17, 6, 19 };


            //List of even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach ( var number in evenNumbers )
            {
                Console.WriteLine("Even Numbers: " + number);
            }

            // number that greater than 20
            var greaterThan20 = numbers.Where(n => n > 20);

            foreach (var number in greaterThan20)
            {
                Console.WriteLine("Greater than 20: " + number);
            }
            //Sum of all numbers
            var sum = numbers.Sum();
            Console.WriteLine("Sum: " + sum);

            //average of numbers
            var avg = numbers.Average();
            Console.WriteLine("Average: " + avg);

            // MinValue
            var min = numbers.Min();
            Console.WriteLine("Min Value: " + min);

            //Max value
            var max = numbers.Max();
            Console.WriteLine("MAx Value: " + max);
             
        }
    }
}