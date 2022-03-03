using System;
class Program
{
    static void Main(string[] args)
    {
        int binNum = 0;
        int decNum = 0;
        int i = 0;
        int rem = 0;
        Console.Write("Enter a binary number: ");
        binNum = int.Parse(Console.ReadLine());
        while (binNum > 0)
        {
            rem = binNum % 10;
            decNum = decNum + rem * (int)Math.Pow(2, i);
            binNum = binNum / 10;
            i++;
        }
        Console.WriteLine("\nDecimal number: " + decNum);
    }
}

