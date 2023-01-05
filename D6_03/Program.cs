﻿// Задача 42: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int number = 45;

PrintBinaryView(number);

void PrintBinaryView(int n)
{
    if (n <= 0) return;
    PrintBinaryView(n / 2);
    Console.Write(n % 2);
}
