using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sizeof(int): {0}", sizeof(int));
            Console.WriteLine("sizeof(float): {0}", sizeof(float));
            Console.WriteLine("sizeof(char): {0}", sizeof(char));
            Console.WriteLine("sizeof(double): {0}", sizeof(double));
            Console.WriteLine("sizeof(bool): {0}", sizeof(bool));
            Console.ReadLine();
        }
    }
}
