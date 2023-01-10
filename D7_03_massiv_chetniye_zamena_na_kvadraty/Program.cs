// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы 
// на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , 
// как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

    static void TransformArray_2(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i +=2)
        {
            for (int j = 0; j < array.GetLength(1); j +=2)
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
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

        System.Console.WriteLine();

        TransformArray_2(myArray);
        PrintArray(myArray);
    }
}
}