// Задача 35: Задайте одномерный массив из 123 случайных чисел 
// в диапазоне [0, 150]. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] RandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 150);
    }
    return array;
}

for(int i = 0; i < array.Length; i++)
Console.Write($"{array[i], 4}");

int count = 0;

for(var i = 0; i < array.Length; i++)
{
    if(i > 10 && i < 99)
    count++;
}

Console.WriteLine();
Console.WriteLine($"Значения элементов массива, которые лежат в отрезке [10,99]: {count}");

