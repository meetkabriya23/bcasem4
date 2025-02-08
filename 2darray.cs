 using System;
namespace array
{
    class array1
    {
        public static void Main()
        {
            int[,] arr = new int[2, 3]; // Corrected array initialization
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine()); // Added parentheses to ReadLine()
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]); // Fixed print format
                }
            }
        }
    }
}
