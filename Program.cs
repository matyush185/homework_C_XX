// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNum (int num)
{
    if (num == 1)
    {
        Console.Write($"{num}");
    }
    else
    {
        Console.Write($"{num}, ");
        ShowNum (num - 1);
    }
}

// Console.Write("Input Positive number N ");
// int num1 = Convert.ToInt32(Console.ReadLine ());
// ShowNum(num1);
// Console.WriteLine();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNum (int min, int max)
{
    if (min != max ) return SumNum(min, max-1) + max;
    else return max;
}

// Console.Write("Input Positive number M ");
// int num1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input Positive number N ");
// int num2 = Convert.ToInt32(Console.ReadLine ());

// if (num1 <= num2) Console.WriteLine($"Sum is {SumNum(num1,num2)}");
// else Console.WriteLine($"Sum is {SumNum(num2,num1)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Func_Ackerm(int m, int n)
{
  if (m == 0) return n + 1;
  else
    if ((m != 0) && (n == 0)) return Func_Ackerm(m - 1, 1);
    else return Func_Ackerm(m - 1, Func_Ackerm(m, n - 1));
}

Console.Write("Input Positive number m ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("Input Positive number n ");
int n = Convert.ToInt32(Console.ReadLine ());

if (n <= 0 || m <=0 ) Console.WriteLine("Данные некорректны ");
else Console.WriteLine($"Значение функции Аккермана: {Func_Ackerm(m,n)}");