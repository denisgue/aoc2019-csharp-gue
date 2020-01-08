using System;

namespace day1
{
    class Program
    {
        /// <summary>
        /// reads file from path
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] inputFile = System.IO.File.ReadAllLines("input.txt");
            Console.WriteLine(Part1(inputFile));
            Console.WriteLine(Part2(inputFile));
            Console.ReadLine();
        }

        /// <summary>
        /// </summary>
        /// <param name="inputFile"></param> input numbers as a string array 
        /// <returns></returns> final number thats calc. by adding all the numbers divided by 3 and sub. by 2 
        static int Part1(string[] inputFile)
        {
            int erg = 0;
            foreach (string s in inputFile)
            {
                int fuel = int.Parse(s);
                erg += (fuel/3)-2;
            }
            return erg;
        }

        /// <summary>
        /// </summary>
        /// <param name="inputFile"></param> input numbers as a string array
        /// <returns></returns> final number thats calc. like part1 but till its 0 or neg
        static int Part2(string[] inputFile)
        {
            int erg = 0;
            foreach (string s in inputFile)
            {
                int fuel = int.Parse(s);

                while ((fuel/3)-2 > 0)
                {
                    fuel = (fuel/3)-2;
                    erg += fuel;
                }
            }
            return erg;
        }
    }
}
