// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Write A please: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write B please, different from A: ");
int b = Convert.ToInt32(Console.ReadLine());
// не знаю как сделать чтобы работало с отрицательными числами
if (a > b)
{
Console.WriteLine("max A");
}

if (a == b)
{
Console.WriteLine("Are you stupid? Write number DIFFERENT FROM NUMBER A. Different, my friend! Please");
}

else
{
Console.WriteLine("max B");    
}