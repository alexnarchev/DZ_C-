// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и единицами 
// в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = new int[8]; //массив из 8 элементов целых чисел
// int num = new Random().Next(0,2);
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0,2);
}

Console.WriteLine(string.Join(", " , array));


// int [] array = new int[16]; 
// for (int i = 0; i < array.Lenth; i++)
// {
//     array[i] = new Random().Next(0,2);
// }
// Console.WriteLine(string.Join(", " , array)); или
// Console.Write(array[i] + " ");