// Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

//считывает целое число от пользователя
int ReadInt(string message)
{
    Console.WriteLine(message); //введите число
    return Convert.ToInt32(Console.ReadLine());
}
// возвращает произведение от 1 до Number
int GetSumToNumber(int number)
{
    int multy = 1;
    for (int i = 1; i <= number; i++)
    {
        multy *= 1; // multy = multi * i
    }
    return multy;
}

int a = ReadInt("Введите число: ");
int result = GetSumToNumber(a);
Console.WriteLine($"Произведение чисел от 1 до {a} = {result}");