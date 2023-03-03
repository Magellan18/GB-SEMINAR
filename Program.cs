// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[4];
//         Random rnd = new Random();

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = rnd.Next(100, 1000);
//         }
//         int count = 0;
//         foreach (int number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество четных чисел в массиве: {count}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[4];
//         Random rnd = new Random();
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = rnd.Next(-100, 100);
//         }
//         int sum = 0;
//         for (int i = 1; i < array.Length; i += 2)
//         {
//             sum += array[i];
//         }

//         Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
//     }
// }
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] array = { 3.0, 7.0, 22.0, 2.0, 78.0 };
        double max = array[0];
        double min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

        double diff = max - min;

        Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
    }
}
