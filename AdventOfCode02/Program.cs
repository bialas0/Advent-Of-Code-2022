using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode02
{
    internal class Program
    {
        // rock += 1        |   win += 6
        // paper += 2       |   draw += 3
        // scissors += 3    |   loss += 0

        // A = rock(r), B = paper(p), C = scissors(s)
        // X = rock(r), Y = paper(p), Z = scissors(s)

        static void Main(string[] args)
        {
            string path = @"";
            StreamReader reader;

            List<string> matches = new List<string>();

            int score = 0;
            string line = String.Empty;

            Console.WriteLine("----------------------------" +
                "\n   Advent of Code: Day 02" +
                "\n----------------------------");

            reader = new StreamReader(path);
            while ((line = reader.ReadLine()) != null)
            {
                switch (line[0])
                {
                    case 'A':
                        switch (line[2])
                        {
                            case 'X':
                                score += 3;
                                break;
                            case 'Y':
                                score += 4;
                                break;
                            case 'Z':
                                score += 8;
                                break;
                        }
                        break;
                    case 'B':
                        switch (line[2])
                        {
                            case 'X':
                                score += 1;
                                break;
                            case 'Y':
                                score += 5;
                                break;
                            case 'Z':
                                score += 9;
                                break;
                        }
                        break;
                    case 'C':
                        switch (line[2])
                        {
                            case 'X':
                                score += 2;
                                break;
                            case 'Y':
                                score += 6;
                                break;
                            case 'Z':
                                score += 7;
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine($"Score: {score}");
        }
    }
}
