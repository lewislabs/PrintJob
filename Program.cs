using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintJob
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.Out.WriteLine($"Job: {string.Join(",",args)}");
                return;
            }
            Console.Out.WriteLine("No Input!!!");
        }
    }
}
