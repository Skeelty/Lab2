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
            var array = new int[n+1];
            array[1] = 2;
            array[2] = 4;

            if (n == 1 || n == 2)
            {
                File.WriteAllText("output.txt", array[n].ToString());
            }
            else
            {
                for (int i = 3; i < n+1; i++)
                {
                    array[i] = array[i - 1] + i;
                }

                File.WriteAllText("output.txt", array[n].ToString());
            }

        }
    }
}
