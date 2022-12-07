using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AdventOfCode4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\My Drive\c# exercises\input.txt";
            StreamReader reader;

            string line = String.Empty, range = String.Empty, 
                rangeTwo = String.Empty;

            List<int> nums = new List<int>();
            int num;
            bool isNum;

            Console.WriteLine("----------------------------" +
                "\n   Advent of Code: Day 04" +
                "\n----------------------------");

            reader = new StreamReader(path);
            while ((line = reader.ReadLine()) != null)
            {
                range = line.Substring(0, line.IndexOf(','));
                rangeTwo = line.Substring(line.IndexOf(','));

                isNum = range.All(Char.IsDigit);

                //if (isNum == true)
                //{

                //}

                for (int i = 0; i < range.Length; i++)
                {
                    if (Char.IsDigit(range[i]))
                    {
                        nums.Add(range.Where(Char.IsDigit(range) == true);
                    }
                }

                //Console.WriteLine(range + "\t" + rangeTwo);

                nums.ForEach(Console.WriteLine);
            }
        }
    }
}
