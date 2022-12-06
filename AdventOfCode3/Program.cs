using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = @"G:\My Drive\c# exercises\rucksack.txt";
            StreamReader reader;

            string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string line = String.Empty;
            string first = String.Empty, last = String.Empty;

            int prioritySum = 0;

            Console.WriteLine("----------------------------" +
                "\n   Advent of Code: Day 03" +
                "\n----------------------------");

            reader = new StreamReader(path);
            while ((line = reader.ReadLine()) != null)
            {
                first = line.Substring(0, line.Length / 2);
                last = line.Substring(line.Length / 2, line.Length / 2);

                //Console.WriteLine(first + " - " + last);

                foreach (char c in first)
                {
                    if (last.Contains(c))
                    {
                        prioritySum += alpha.IndexOf(c) + 1;
                        break;
                    }
                }
            }
            Console.WriteLine($"\n-------------------------\n" +
                $"Priority Item Sum: {prioritySum}" +
                $"\n-------------------------\n");
            prioritySum = 0;
            List<string> group = new List<string>();

            reader = new StreamReader(path);
            while ((line = reader.ReadLine()) != null)
            {
                string line2 = reader.ReadLine();
                string line3 = reader.ReadLine();

                foreach (char c in line)
                {
                    if (line2.Contains(c) && line3.Contains(c))
                    {
                        prioritySum += alpha.IndexOf(c) + 1;
                        break;
                    }
                }
            }
            Console.WriteLine($"\n-------------------------\n" +
                $"Priority Item Sum: {prioritySum}" +
                $"\n-------------------------\n");
        }
    }
}
