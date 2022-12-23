// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7

int max = 0;

Console.Write("Write number A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Write number B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Write number C: ");
int NumberC = Convert.ToInt32(Console.ReadLine());

if(NumberA > max)
{
    max = NumberA;
}
if(NumberB > max)
{
    max = NumberB;
}
if(NumberC > max)
{
    max = NumberC;
}

Console.WriteLine("max = " + max);

// опять же, не работает, если числа меньше нуля (да и пожалуйста, не больно то и хотелось)