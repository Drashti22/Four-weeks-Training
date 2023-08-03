using System.Diagnostics;

namespace AsyncAwaitBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Call PerformCalculations and measure time taken using Stopwatch
            await PerformCalculations(5);
        }

        static async Task SimulateLongRunningTask(int delayInSeconds)
        {
            // Implement long-running task simulation
            await Task.Delay(delayInSeconds * 1000);
            Console.WriteLine($"Task completed after {delayInSeconds} seconds");
        }

        static async Task PerformCalculations(int numberOfTasks)
        {
            // Start long-running tasks concurrently and wait for them to complete
            Stopwatch stopwatch = Stopwatch.StartNew();

            Task[] tasks = new Task[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++)
            {
                tasks[i] = SimulateLongRunningTask(i + 1);
            }

            await Task.WhenAll(tasks);

            stopwatch.Stop();
            Console.WriteLine($"All tasks completed in {stopwatch.ElapsedMilliseconds} milliseconds");    
        }
    }
}