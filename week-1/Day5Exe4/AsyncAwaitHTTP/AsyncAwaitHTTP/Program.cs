using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        List<string> urls = new List<string>
        {
            "https://www.example.com",
            "https://www.google.com",
            "https://www.microsoft.com"
        };

        List<Task> tasks = new List<Task>();
        foreach (string url in urls)
        {
            Task task = FetchDataAsync(url);
            tasks.Add(task);
        }

        await Task.WhenAll(tasks);

        Console.WriteLine("Web page content lengths:");
        for (int i = 0; i < urls.Count; i++)
        {
            string url = urls[i];
            Task<string> task = tasks[i] as Task<string>;
            Console.WriteLine($"{url}: {task.Result.Length} characters");
        }
    }

    static async Task<string> FetchDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string content = await client.GetStringAsync(url);
            return content;
        }
    }
}