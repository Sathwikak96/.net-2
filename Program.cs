using System;

class CubeRoot
{
    static int Main()
    {
        int number = 0;
        double cubeRoot = 0;

        Console.Write("Enter the value of number: ");
        number = Convert.ToInt32(Console.ReadLine());

        cubeRoot = Math.Ceiling(Math.Pow(number, (double)1 / 3));
        Console.WriteLine("Cube Root is : " + cubeRoot);

        return 0;
    }
}
