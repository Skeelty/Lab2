using System;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText("input.txt");

            var n = Convert.ToInt32(file);

            var result = (n * (n + 1) / 2) + 1;

            File.WriteAllText("output.txt", result.ToString());
        }
    }
}
