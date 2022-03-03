using System;
class PascalTringle
{

    public static void Main()
    {
        int[,] arr;
        int rows = 0;
        int loop1 = 0;
        int loop2 = 0;
        int space = 0;

        arr = new int[8, 8];

        Console.Write("Enter the total number of rows to draw Pascal Triangle : ");
        rows = int.Parse(Console.ReadLine());


        for (loop1 = 0; loop1 < rows; loop1++)
        {
            for (space = rows; space > loop1; space--)
            {
                Console.Write(" ");
            }

            for (loop2 = 0; loop2 < loop1; loop2++)
            {
                if (loop2 == 0 || loop1 == loop2)
                {
                    arr[loop1, loop2] = 1;
                }
                else
                {
                    arr[loop1, loop2] = arr[loop1 - 1, loop2] + arr[loop1 - 1, loop2 - 1];
                }
                Console.Write(arr[loop1, loop2] + " ");
            }
            Console.WriteLine();
        }
    }
}
