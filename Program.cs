// using System;

// public class Program
// {
//     public static void Main()
//     {
//         int m = 3; 
//         int n = 4; 

       
//         double[,] arr = new double[m, n];

        
//         Random rand = new Random();
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 double randNum = rand.NextDouble() * 20 - 10; 
//                 arr[i, j] = Math.Round(randNum, 2); 
//             }
//         }

//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(arr[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         int[] arr = new int[4];

        
//         Random rand = new Random();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = rand.Next(-100, 100); 
//         }

        
//         int sum = 0;
//         for (int i = 1; i < arr.Length; i += 2) 
//         {
//             sum += arr[i];
//         }

        
//         Console.WriteLine("Массив: " + string.Join(", ", arr));
//         Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);
//     }
// }

using System;

public class Program
{
    public static void Main()
    {
        double[] arr = { 3.2, 7.5, 22.1, 2.7, 78.9 }; 

        
        double max = arr[0];
        double min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        
        double diff = max - min;

        
        Console.WriteLine("Массив: " + string.Join(", ", arr));
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
    }
}
