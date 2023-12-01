using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdventOfCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int result = 0;
            foreach (string line in input)
            {
                string val = Regex.Replace(line, "[A-Za-z ]", "");
                val = $"{val[0]}{val[val.Length-1]}";
                Console.WriteLine(val);
                result += int.Parse(val);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
