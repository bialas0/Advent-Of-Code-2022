using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;

namespace AdventOfCode01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"";
            string line = String.Empty;

            StreamReader reader;

            int x = 0;
            List<int> elfCalories = new List<int>();

            Console.WriteLine("----------------------------" +
                "\n   Advent of Code: Day 01" +
                "\n----------------------------");

            reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                while ((line = reader.ReadLine()) != null)
                {

                    if (String.IsNullOrEmpty(line))
                    {
                        elfCalories.Add(x);
                        x = 0;
                    }
                    else
                    {
                        x += Convert.ToInt32(line.ToString());
                    }
                }
            }
            //Console.WriteLine("Total Elf Calories: ");
            //elfCalories.ForEach(Console.WriteLine);

            Console.WriteLine($"Top 3 Calories" +
                $"\n1: {elfCalories.Max()}\n");

            x = 0;

            for (int i = 0; i < 3; i++)
            {
                x += elfCalories.Max();
                elfCalories.RemoveAt(elfCalories.IndexOf(elfCalories.Max()));
            }
            Console.WriteLine($"Top 3 Elf Calorie: {x}");
        }
    }
}
