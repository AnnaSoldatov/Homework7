// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     double[,] array = new double[rows,cols];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = new Random().NextDouble() * (max - min) + min;
//     return array;
// }

// void Show2dArray(double[,] array){
//     for(int i =0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(Math.Round(array[i,j], 1) + " ");
//         }
//     }
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] array = CreateRandom2dArray(rows,cols, min, max);
// Show2dArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i =0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// void Position(int[,] array, int i, int j){
    
//     if(i>array.GetLength(0) || j>array.GetLength(1)) Console.WriteLine("The input position doesn't exist");
//     else {
//         int number = array[i,j];
//         Console.WriteLine(number);
//         }
    
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input i: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input j: ");
// int j = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// Position(array, i, j);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i =0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// void Average(int[,] array){
//     for(int j = 0; j<array.GetLength(1); j++){
//             double av = 0;
//             double sum = 0;
//             for(int i = 0; i<array.GetLength(0); i++){
//             sum += array[i,j];
//             }
//         av = sum / array.GetLength(0);
//         Console.Write(Math.Round(av, 2) + " ");
//     }
        
// }


// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// Console.WriteLine();
// Average(array);

