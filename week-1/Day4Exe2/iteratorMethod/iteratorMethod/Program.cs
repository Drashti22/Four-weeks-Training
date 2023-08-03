using iteratorMethod;
using System.Collections;

namespace iteratorMethod
{
        public class FibbonacciMethod : IEnumerable<int>
        {   
        private int count;
        private IEnumerable<int> GetNumbers()
        {
            int last = 0;
            int next = 1;
            count  = 0;

            while (count < 10)
            {
                if (count == 0)
                {
                    yield return last;
                }
                else if (count == 1)
                {
                    yield return next;
                }
                else
                {
                    int num = last + next;
                    last = next;
                    next = num;
                    yield return num;
                }
                    count++;
                }
            }
        public IEnumerator<int> GetEnumerator()
        {
            return GetNumbers().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
            FibbonacciMethod fibobonacci = new FibbonacciMethod();
            foreach (int n in fibobonacci)
        {
            Console.WriteLine(n);
        }

        }
    }
    