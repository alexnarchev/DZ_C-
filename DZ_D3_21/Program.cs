// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Coordinate("x", "1");
int y1 = Coordinate("y", "1");
int z1 = Coordinate("z", "1");
int x2 = Coordinate("x", "2");
int y2 = Coordinate("y", "2");
int z2 = Coordinate("z", "2");

int Coordinate(string Coordinate, string Point)
{
    Console.Write($"Введите координату {Coordinate} точки {Point}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2));
}

double FullLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Расстояние между точками {FullLength}");