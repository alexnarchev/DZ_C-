// Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите 3х значное число: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    string Number3 = Convert.ToString(Number);   
Console.WriteLine("вторая цифра данного числа: " + Number3[1]);