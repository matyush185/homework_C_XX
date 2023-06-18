// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int [] CreateRandomArray (int size, int min, int max) 
{
    int [] array1 = new int [size]; // одномерный массив
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(min, max+1);
    }
    return array1;
}

void ShowArray (int [] array)
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

Console.Write("Input Size of Array: ");
int size1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input Min Possible Value of Array: ");
// int min1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input Max Possible Value of Array: ");
// int max1 = Convert.ToInt32(Console.ReadLine ());

// int [] array1 = CreateRandomArray (size1, min1, max1);
// ShowArray (array1);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int CountHonestOfArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

// Console.WriteLine($"{CountHonestOfArray (array1)} is counter of honest numbers of Array");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int SumOfElemOfOddPostOfArray (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum +=  array[i];
//            // Console.WriteLine($"{sum},{array[i]}, {i}"); Testing
        }
    }
    return sum;
}

// Console.WriteLine($"{SumOfElemOfOddPostOfArray (array1)} is sum of elements of Array on odd positions");
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double [] CreateRandomDoubleArray (int size) //, double min, double max) 
{
    double [] array1 = new double [size]; // одномерный массив
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().NextDouble();
    }
    return array1;
}

void ShowDoubleArray (double [] array1)
{
    Console.Write($"[");
    for (int i = 1; i <= array1.Length; i++)
    {
        if (i != array1.Length)
        {
            Console.Write($"{array1[i]:f3}, ");
        }
        else Console.Write($"{array1[i-1]:f3}] ");
    }
    Console.WriteLine($"\b");
}

void DifMinMax (double [] array1)
{
    double min = array1[0];
    double max = array1[0];

    for (int i = 0; i < array1.Length ; i++)
    {
        if (min > array1[i])
            min = array1[i];
        if (max < array1[i])
            max = array1[i];
    }

    Console.WriteLine($"max is {max:f3}, min is {min:f3} ");

    double dif = max - min;
    Console.WriteLine($"dif is {dif:f3}");

}

Console.Write("Input Size of Array: ");
int size1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input Min Possible Value of Array: ");
// double min1 = Convert.ToDouble(Console.ReadLine ());
// Console.Write("Input Max Possible Value of Array: ");
// double max1 = Convert.ToDouble(Console.ReadLine ());

double [] array1 = CreateRandomDoubleArray (size1); //, min1, max1);
ShowDoubleArray (array1);
DifMinMax(array1);
