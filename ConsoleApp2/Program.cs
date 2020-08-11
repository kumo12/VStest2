using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            WriteLine(greeting + "\n");

            WriteLine(greeting.IndexOf("o"));
            WriteLine(greeting.LastIndexOf("0"));

            WriteLine(greeting.Contains("Evening"));
            WriteLine(greeting.Contains("Morning"));

            WriteLine(greeting.Replace("Morning", "Evening"));

            WriteLine(greeting.ToLower());
            WriteLine(greeting.ToUpper());
            WriteLine(greeting.Insert(4, " sunday"));
            WriteLine(greeting.Remove(4,8));
            WriteLine("   Hello Word  ".Trim());

            WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Substring(5));

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}, arr.Length");

            foreach (string element in arr)
                WriteLine("{0}", element);

        }
    }
}
