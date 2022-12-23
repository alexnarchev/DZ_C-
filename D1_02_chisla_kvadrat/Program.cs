// Программа на вход принимате 2 числа и проверяет, является ли 1-е квадратом второго
// a = 25, b = 5 -> да; a =2, b = 10 -> - нет;

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");    
}