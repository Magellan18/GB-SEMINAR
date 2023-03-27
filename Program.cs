// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         PrintNumbers(n);
//     }

//     static void PrintNumbers(int n)
//     {
//         if (n == 1)
//         {
//             Console.Write("1");
//         }
//         else
//         {
//             Console.Write("{0}, ", n);
//             PrintNumbers(n - 1);
//         }
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         int sum = SumNumbers(m, n);
//         Console.WriteLine("Сумма натуральных чисел от {0} до {1}: {2}", m, n, sum);
//     }

//     static int SumNumbers(int m, int n)
//     {
//         int sum = 0;
//         for (int i = m; i <= n; i++)
//         {
//             sum += i;
//         }
//         return sum;
//     }
// }
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
