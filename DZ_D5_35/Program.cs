﻿// Задайте одномерный массив из 123 случайных чисел 
// в диапазоне [0, 150]. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int Array = 123;
int[] a = new int[Array];
Random Random = new Random();

for(int i = 0; i < a.Length; i++)
a[i] = Random.Next(0, 100);

for(int i = 0; i < a.Length; i++)
System.Console.Write($"{a[i], 4}");

int count = 0;

for(var i = 0; i<a.Length; i++)
{
    if(i > 10 && i < 99)
    count++;
}

System.Console.WriteLine();
System.Console.WriteLine($"Значения элементов массива, которые лежат в отрезке [10,99]: {count}");

