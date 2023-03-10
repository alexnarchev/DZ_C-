// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

int [] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

// 1. сумма положительных элементов
// 2. сумма отрицательных элементов
(int, int) SumPositiveAndNegative(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) //что элемент положительный
        {
            sumPositive += array[i]; // копить + сумму
        }
        else //иначе элемент отриц-й (или == 0)
        {
            sumNegative += array[i]; // копить - сумму
        }
    }
    return (sumPositive, sumNegative);
}
const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");

(int sumP, int sumN) = SumPositiveAndNegative(massive);
Console.WriteLine($"Сумма + элементов = {sumP}, сумма - = {sumN}");