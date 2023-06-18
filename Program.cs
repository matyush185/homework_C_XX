// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.Write("Input num ");
// int a = Convert.ToInt32(Console.ReadLine ());

// int [] CreateRandomArray (int size, int min, int max) 
// {
//     int [] array1 = new int [size]; // одномерный массив
//     for (int i = 0; i < size; i++)
//     {
//         array1[i] = new Random().Next(min, max+1);
//     }
//     return array1;
// }

// void ShowArray (int [] array)
// {
//     Console.Write($"[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != (array.Length-1))
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         else Console.Write($"{array[i]}] ");
//     }
//     Console.WriteLine($"\b");
// }

// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// int [] GetArray()
// {
//     bool is_exit = false;
//     int [] array1 = new int [1]; // одномерный массив
//     int count = 0;
//     while (is_exit == false)
//     {
//         Console.WriteLine("Введите целое число для наполнения массива или q для выхода ");
//         string a = Convert.ToString(Console.ReadLine ());
//         if (a == "q")
//             is_exit = true;
//         else
//         {
//             if (count > 0) Array.Resize(ref array1, array1.Length + 1);
//             int b = Convert.ToInt32(a);
//             array1[count] = b;
//             count ++; 
//         }
//     }
//     return array1;
// }

// int PosCountArr(int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count ++;
//     }
//     return count;
// }

// int [] array_new = GetArray();
// ShowArray (array_new);
// Console.Write($"Количество положительны чисел: {PosCountArr(array_new)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void GetIntersect(double b1, double k1, double b2, double k2)
{
    Console.WriteLine ($"{b2:f2} , {k2:f2})");
    double x = (b2-b1)/(k1-k2);
    double y = k2*(b2-b1)/(k1-k2) + b2;
    Console.WriteLine ($"Точка перечения (x,y) = ({x:f2} , {y:f2})");
} 

Console.Write("Input num b1 ");
double b1 = Convert.ToDouble(Console.ReadLine ());
Console.Write("Input num k1 ");
double k1 = Convert.ToDouble(Console.ReadLine ());
Console.Write("Input num b2 ");
double b2 = Convert.ToDouble(Console.ReadLine ());
Console.Write("Input num k2 ");
double k2 = Convert.ToDouble(Console.ReadLine ());

GetIntersect(b1, k1, b2, k2);