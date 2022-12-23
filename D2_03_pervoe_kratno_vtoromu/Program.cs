// Задача 12: Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит 
// остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("enter two numbers");
int firstN = Convert.ToInt32(Console.ReadLine());
int secondN = Convert.ToInt32(Console.ReadLine());

if (firstN % secondN == 0)
{
    Console.WriteLine("multiply");
}

else
{
    int N = firstN % secondN;
    Console.WriteLine($" repeatedly, остаток{N}");
}