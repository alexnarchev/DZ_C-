// Задача №17. Напишите программу, которая принимает 
// на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


Console.WriteLine("Введите координаты точк по X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точк по Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Невозможно определить четверть");
}

else if (x > 0, y > 0)
{
    Console.WriteLine("Точка в 1-й четверти");
}

else if (x < 0, y > 0)
{
    Console.WriteLine("Точка в 2-й четверти");
}

else if (x < 0, y < 0)
{
    Console.WriteLine("Точка в 3-й четверти");
}
else if (x > 0, y < 0)
{
    Console.WriteLine("Точка в 4-й четверти");
}