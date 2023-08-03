namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    class StringToIntProcessor : IProcessor<string, int>
    {
        // Implement Process method
        public int Process(string input)
        {
            return input.Length;
        }
    }

    class DoubleToStringProcessor : IProcessor<double, string>
    {
        // Implement Process method
        public string Process(double input)
        {
            return input.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IProcessor<string, int> stringToIntProcessor = new StringToIntProcessor();
            IProcessor<double, string> doubleToStringProcessor = new DoubleToStringProcessor();

            string inputString = "Hello, World!";
            int stringLength = stringToIntProcessor.Process(inputString);
            Console.WriteLine($"Length of the input string: {stringLength}");

            double inputDouble = 3.14;
            string doubleString = doubleToStringProcessor.Process(inputDouble);
            Console.WriteLine($"String representation of the input double: {doubleString}");
        }
    }
}