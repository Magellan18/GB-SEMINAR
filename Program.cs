// using System;

// class Program {
//     static void Main() {
//         int[,] arr = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4}
//         };

//         int rows = arr.GetLength(0);
//         int cols = arr.GetLength(1);

//         for (int i = 0; i < rows; i++) {
//             for (int j = 0; j < cols - 1; j++) {
//                 for (int k = j + 1; k < cols; k++) {
//                     if (arr[i,j] < arr[i,k]) {
//                         int temp = arr[i,j];
//                         arr[i,j] = arr[i,k];
//                         arr[i,k] = temp;
//                     }
//                 }
//             }
//         }

//         for (int i = 0; i < rows; i++) {
//             for (int j = 0; j < cols; j++) {
//                 Console.Write(arr[i,j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// using System;

// class Program {
//     static void Main() {
//         int[,] arr = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4},
//             {5, 2, 6, 7}
//         };

//         int rows = arr.GetLength(0);
//         int cols = arr.GetLength(1);

//         int minSum = int.MaxValue;
//         int minIndex = -1;

//         for (int i = 0; i < rows; i++) {
//             int sum = 0;
//             for (int j = 0; j < cols; j++) {
//                 sum += arr[i,j];
//             }
//             if (sum < minSum) {
//                 minSum = sum;
//                 minIndex = i;
//             }
//         }

//         Console.WriteLine("Наименьшая сумма элементов в строке {0}", minIndex + 1);
//     }
// }

// using System;

// class Program {
//     static void Main() {
//         int[,] matrix1 = {
//             {4, 5},
//             {3, 1}
//         };
//         int[,] matrix2 = {
//             {4, 5},
//             {3, 1}
//         };
//         int rows1 = matrix1.GetLength(0);
//         int cols1 = matrix1.GetLength(1);
//         int rows2 = matrix2.GetLength(0);
//         int cols2 = matrix2.GetLength(1);
//         if (cols1 != rows2) {
//             Console.WriteLine("Невозможно выполнить умножение матриц");
//             return;
//         }
//         int[,] result = new int[rows1, cols2];
//         for (int i = 0; i < rows1; i++) {
//             for (int j = 0; j < cols2; j++) {
//                 int sum = 0;
//                 for (int k = 0; k < cols1; k++) {
//                     sum += matrix1[i,k] * matrix2[k,j];
//                 }
//                 result[i,j] = sum;
//             }
//         }
//         Console.WriteLine("Результирующая матрица:");
//         for (int i = 0; i < rows1; i++) {
//             for (int j = 0; j < cols2; j++) {
//                 Console.Write("{0} ", result[i,j]);
//             }
//             Console.WriteLine();
//         }
//     }
// }

// using System;

// class Program {
//     static void Main() {
//         int[,,] array = new int[2, 2, 2];
//         int count = 10;
//         for (int i = 0; i < 2; i++) {
//             for (int j = 0; j < 2; j++) {
//                 for (int k = 0; k < 2; k++) {
//                     array[i,j,k] = count;
//                     count++;
//                 }
//             }
//         }
//         Console.WriteLine("Массив:");
//         for (int i = 0; i < 2; i++) {
//             for (int j = 0; j < 2; j++) {
//                 for (int k = 0; k < 2; k++) {
//                     Console.Write("{0}({1},{2},{3}) ", array[i,j,k], i, j, k);
//                 }
//                 Console.WriteLine();
//             }
//             Console.WriteLine();
//         }
//     }
// }
// using System;

// class Program {
//     static void Main() {
//         int[,] array = new int[4, 4];
//         int n = 4;
//         int count = 1;
//         int i, j;
//         int k = 0;
//         int l = 0;
//         while (k < n && l < n) {
//             for (i = l; i < n; i++) {
//                 array[k,i] = count++;
//             }
//             k++;
//             for (i = k; i < n; i++) {
//                 array[i,n-1] = count++;
//             }
//             n--;
//             if (k < n) {
//                 for (i = n-1; i >= l; i--) {
//                     array[n-1,i] = count++;
//                 }
//                 n--;
//             }
//             if (l < n) {
//                 for (i = n-1; i >= k; i--) {
//                     array[i,l] = count++;
//                 }
//                 l++;
//             }
//         }
//         Console.WriteLine("Массив:");
//         for (i = 0; i < 4; i++) {
//             for (j = 0; j < 4; j++) {
//                 Console.Write("{0:D2} ", array[i,j]);
//             }
//             Console.WriteLine();
//         }
//     }
// }
