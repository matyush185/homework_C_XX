// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] ChangeDecrRow2dArray (int [,] array2d) 
{
    int count = 0;
    int max = 0;

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        count = 0;
        while (count < array2d.GetLength(1))
        {
            max = array2d[i,count];
            for (int j = count; j < array2d.GetLength(1); j++)
            {             
               if (max < array2d[i,j])
               {
                    array2d[i,count] = array2d[i,j];
                    array2d[i,j] = max;
                    max = array2d[i,count];
               }
            } 
            array2d[i,count] = max;
            count ++;
        }
    }
    return array2d;
}

// int [,] new2dArray = Create2dArray();
// Show2dArray (new2dArray);
// int [,] new2dArray_2 = ChangeDecrRow2dArray(new2dArray);
// Show2dArray (new2dArray_2);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void GetMinSumRow2dArray(int [,] array2d)
{
    int min_sum = 0;
    int min_row = 0;
    int row = 0;

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
            min_row += array2d[i,j];
        if (i == 0 || min_sum > min_row)
        {
            min_sum = min_row;
            row = i;        
        }
        min_row = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {row+1} (сумма {min_sum})");
}

// int [,] new2dArray = Create2dArray();
// Show2dArray (new2dArray);
// GetMinSumRow2dArray(new2dArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] Multi2Array (int [,] array2d1, int [,] array2d2)
{
    int [,] newarray2d = new int[array2d1.GetLength(0),array2d1.GetLength(1)];
    if (array2d1.GetLength(0) != array2d2.GetLength(0) || array2d1.GetLength(1) != array2d2.GetLength(1))
    {
        Console.WriteLine($"Данные некорректны");      
    }
    else
    {
        for (int i = 0; i < newarray2d.GetLength(0); i++)
        {
            for (int j = 0; j < newarray2d.GetLength(1); j++)
                newarray2d[i,j] = array2d1[i,j] * array2d2[i,j];
        }
    }
    return newarray2d;
} 

// int [,] new2dArray1 = Create2dArray();
// Show2dArray (new2dArray1);
// int [,] new2dArray2 = Create2dArray();
// Show2dArray (new2dArray2);
// int [,] new2dArray3 = Multi2Array(new2dArray1, new2dArray2);
// Show2dArray (new2dArray3);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// bool is_unique (int [,] create3Array, int num)
// {
//     bool flag = false;
//     for (int i = 0; i < rows; i++)
//        for (int j = 0; j < columns; j++)
//           for (int k = 0; k < highs; k++)
//           {
//             if (num ==  create3Array[i,j,K])
//             {
//                 flag = true;
//             }
//           }
//     return flag;
// }

int [,,] Create3dArray () 
{
    Console.Write("Input num of rows ");
    int rows = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input num of columns ");
    int columns = Convert.ToInt32(Console.ReadLine ());
    Console.Write("Input num of high ");
    int highs = Convert.ToInt32(Console.ReadLine ());  
    // Console.Write("Input min num ");
    // int min = Convert.ToInt32(Console.ReadLine ());
    // Console.Write("Input max num");
    // int max = Convert.ToInt32(Console.ReadLine ());

    int [,,] create3Array = new int [rows, columns, highs];

    // if ((min => max) || (min < 10) || (max > 99))
    // {
    //    Console.WriteLine($"Данные некорректны");      
    // }
    // else
    // {
        // int temp = new Random().Next(10, 100);
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                for (int k = 0; k < highs; k++)
                {
                    create3Array[i,j,k] = new Random().Next(10, 100);
                }
        
    // }
    return create3Array;
}

void Show3dArray (int [,,] array3d)
{
    // Console.Write($"[");
    for (int i = 0; i < array3d.GetLength(0); i++)
        for (int j = 0; j < array3d.GetLength(1); j++)
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i,j,k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        Console.WriteLine();
    Console.WriteLine();
    // Console.WriteLine($"\b");
}

// int [,,] new3dArray = Create3dArray();
// Show3dArray (new3dArray);
// int [,] new2dArray_2 = ChangeDecrRow2dArray(new2dArray);
// Show2dArray (new2dArray_2);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] SpiralArray () 
{
    // Console.Write("Input num of rows ");
    // int rows = Convert.ToInt32(Console.ReadLine ());
    // Console.Write("Input num of columns ");
    // int columns = Convert.ToInt32(Console.ReadLine ());
    // Console.Write("Input min ");
    // int min = Convert.ToInt32(Console.ReadLine ());
    // Console.Write("Input max ");
    // int max = Convert.ToInt32(Console.ReadLine ());

    int [,] create2Array = new int [4, 4];

    int step = 4;
    int count = 1;

    // if (rows < 0 || rows != columns)
    // {
    //     Console.WriteLine($"Данные некорректны"); 
    // }
    // else
    // {
        for (int j = 0; j < 4; j++)
        {
                create2Array[0,j] = count;
                count ++;
        }
        // int last_y = j;
        for (int i = 1; i < 4; i++)
        {
                create2Array[i,3] = count;
                count ++;
        }
        // int last_x = i;
        for (int j = 2; j >= 0; j--)
        {
                create2Array[3,j] = count;
                count ++;
        }        
        for (int i = 2; i >= 1; i--)
        {
                create2Array[i,0] = count;
                count ++;
        }    
        for (int j = 1; j <= 2; j++)
        {
                create2Array[1,j] = count;
                count ++;
        } 
        // for (int i = 2; i >= 2; i++)
        // {
                create2Array[2,2] = count;
                count ++;
        // } 
        // for (int j = 1; j >= 1; j--)
        // {
                create2Array[2,1] = count;
        //         count ++;
        // }   
    return create2Array;
}


int [,] new2dArray = SpiralArray();
Show2dArray (new2dArray);
// int [,] new2dArray_2 = ChangeDecrRow2dArray(new2dArray);
// Show2dArray (new2dArray_2);
