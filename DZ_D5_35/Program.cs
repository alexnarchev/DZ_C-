// Задача 35: Задайте одномерный массив из 123 случайных чисел 
// в диапазоне [0, 150]. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

// Random random = new Random();

// a[i] = random.Next(0, 150);

int count = 0;

for(int j = 0; j < numbers.Length; j++) // for(int i = 0; i < a.Length; i++)
if(j > 10 && j < 99)
count++;

Console.WriteLine(); // Console.Write($"{a[i], 4}");
Console.WriteLine($"Всего {numbers.Length} чисел в массиве, {count} из них лежат в указанном диапазоне");

void ArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0,150);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}