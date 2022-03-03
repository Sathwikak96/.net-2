using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
     
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            float div = (float)a / (float)b;
            int rem = a % b;

            Console.WriteLine("Addition of {0} and {1} is = {2}", a, b, sum);
            Console.WriteLine("Subtraction of {0} and {1} is = {2}", a, b, sub);
            Console.WriteLine("Multiplication of {0} and {1} is = {2}", a, b, mul);
            Console.WriteLine("Division of {0} and {1} is = {2}", a, b, div);
            Console.WriteLine("Remainder of {0} and {1} is = {2}", a, b, rem);
            Console.ReadLine();
        }
    }
}
