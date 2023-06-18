// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Задача по созданию матрицы с вещественными значениями
double [,] CreateDouble2dArray () //int rows, int columns, int min, int max) 
{
    Console.Write("Input num of rows ");
    int rows = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input num of columns ");
    int columns = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input min ");
    int min = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input max ");
    int max = Convert.ToInt32(Console.ReadLine ());

    double [,] create2Array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            create2Array[i,j] = Math.Round((new Random().Next(min, max+1)) + (new Random().NextDouble()), 2) ;//Дробная часть - new Random().NextDouble()
        }
    }
    return create2Array;
}

void ShowDouble2dArray (double [,] array2d)
{
    // Console.Write($"[");
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
            Console.Write($"{array2d[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
    // Console.WriteLine($"\b");
}

// double [,] new2dArray = CreateDouble2dArray();
// ShowDouble2dArray (new2dArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int [,] Create2dArray () 
{
    Console.Write("Input num of rows ");
    int rows = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input num of columns ");
    int columns = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input min ");
    int min = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input max ");
    int max = Convert.ToInt32(Console.ReadLine ());

    int [,] create2Array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            create2Array[i,j] = new Random().Next(min, max+1);
        }
    }
    return create2Array;
}

void Show2dArray (int [,] array2d)
{
    // Console.Write($"[");
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
            Console.Write($"{array2d[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
    // Console.WriteLine($"\b");
}

void GetNum2dArray (int [,] array2d)
{
    Console.Write("Input row ");
    int row = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input column ");
    int column = Convert.ToInt32(Console.ReadLine ());
    if (array2d.GetLength(0) < row || array2d.GetLength(1) < column || row < 0 || column < 0)
    {
        Console.WriteLine($"такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"{row}, {column} -> {array2d[row-1,column-1]}");
    }
}

// int [,] new2dArray = Create2dArray();
// Show2dArray (new2dArray);
// GetNum2dArray (new2dArray);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ShowDoubleArray (double [] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != (array.Length-1))
        {
            Console.Write($"{array[i]}, ");
        }
        else Console.Write($"{array[i]}] ");
    }
    Console.WriteLine($"\b");
}

void GetAvrgColumn2dArray (int [,] array2d)
{   
    double [] avrgAr = new double[array2d.GetLength(1)];
    double sum = 0;

    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            sum += array2d[i,j];
        }
        avrgAr[j] = sum / array2d.GetLength(1);
        
    }
    ShowDoubleArray(avrgAr);
}
int [,] new2dArray = Create2dArray();
Show2dArray (new2dArray);
GetAvrgColumn2dArray (new2dArray);