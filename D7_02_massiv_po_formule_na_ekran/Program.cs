// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
using System;
namespace S7
{
class Program
{
    static void TransformArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i + j;
            }
        }
    }

    static void PrintArray(in int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }

        static void Main(string[] args)
    {
        int [,] myArray = new int[3, 4];

        TransformArray(myArray);
        PrintArray(myArray);
    }
}
}