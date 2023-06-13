// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void AInExponB (int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++ )
    {
        res = res * a;
    }
    Console.WriteLine($"{res} is req number");
}

// Console.Write("Input Number a: ");
// int a = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input Possitive Exponent b: ");
// int b = Convert.ToInt32(Console.ReadLine ());

// if (b <= 0)
// {
//     Console.Write($"{b} must be possitive number");
// }
// else AInExponB (a, b);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits (int num)
{
    int sum = 0;
    int len = (int)Math.Log10(num) + 1; //Количество символов числа

    for (int i = 0; i < len; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    return sum;
}

// Console.Write("Input Number: ");
// int a = Math.Abs(Convert.ToInt32(Console.ReadLine ())); //Положителоьно число берем

// Console.Write($"{SumDigits(a)} is a sum of number {a}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateNewArray (int size, int min, int max) 
{
    int [] array1 = new int [size]; // одномерный массив
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(min, max+1);
    }
    return array1;
}

void ShowArray (int [] array1)
{
    Console.Write($"[");
    for (int i = 1; i <= array1.Length; i++)
    {
        if (i != array1.Length)
        {
            Console.Write($"{array1[i]}, ");
        }
        else Console.Write($"{array1[i-1]}] ");
    }
    Console.WriteLine($"\b");
}

Console.Write("Input Size of Array: ");
int size1 = Convert.ToInt32(Console.ReadLine ());
Console.Write("Input Min Possible Value of Array: ");
int min1 = Convert.ToInt32(Console.ReadLine ());
Console.Write("Input Max Possible Value of Array: ");
int max1 = Convert.ToInt32(Console.ReadLine ());

ShowArray (CreateNewArray (size1, min1, max1));
