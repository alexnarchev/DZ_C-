// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.Write("Write number from 1 to 7: ");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);

if (a1==6||a1==7)
{ 
    Console.WriteLine ("HOLIDAY!");
}

if (a1>7||a1<1)
{
    Console.WriteLine ("Sorry, that day not from our planet"); 
}

else
{ 
    Console.WriteLine ("Go to the work, lazzy ass"); 
}

