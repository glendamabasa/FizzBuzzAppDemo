using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Looping through numbers from 1 - 100
            for (int i = 1; i <= 100; i++)
            {
                var output = "";
                if (i % 3 == 0)
                {
                    output += "Fizz";//Adding "Fizz" to the output string
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";//Adding "Buzz" to the output string
                }
                if (output.Length == 0)
                {
                    output = i.ToString();//Adding the value of "i" to the output string
                }
                Console.WriteLine(output);//Writting the output to the console
            }
            Console.ReadLine();
        }
    }
}
