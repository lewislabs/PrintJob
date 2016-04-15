using System;

namespace PrintJob
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var job = Environment.GetEnvironmentVariable("job");
            Console.Out.WriteLine($"Job: {job}");
        }
    }
}
