// Программа на входе принимает число N, а на выходе
// показывает все целые числа в промежутке от -N до N
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}

// int i = -N
// while(i <= N)
// { 
//       Console.Write(i + " "); 
//       i++;
// }