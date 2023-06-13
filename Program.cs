// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int num;

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPalindrome(int num5)
{
    int a1 = num5 / 10000;
    int a2 = num5 % 10;

    int b1 = num5 / 1000;
    b1 = b1 % 10;
    int b2 = num5 / 10;
    b2 = b2 % 10;

    if (a1 == a2 && b1 == b2)
    {
        Console.WriteLine($"{num5} is palindrome ");
    }   
    else
    {
        Console.WriteLine($"{num5} is not palindrome ");
    } 
}

// Console.Write("Input Number: ");
// num = Math.Abs(Convert.ToInt32(Console.ReadLine ()));
// CheckPalindrome(num);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistAB (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lengthAB = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return Math.Round(lengthAB, 2);
}

// Console.Write("Input x of A ");
// int x1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input y of A ");
// int y1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input z of A ");
// int z1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input x of B ");
// int x2 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input y of B ");
// int y2 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Input z of B ");
// int z2 = Convert.ToInt32(Console.ReadLine ());

// Console.WriteLine($"{DistAB(x1,y1,z1,x2,y2,z2):f2} is dist of AB ");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube (int from, int till, int expon)
{
    int i;
    double res;
    for (i = from; i <= till; i++)
    {
        res = Math.Pow (i,expon);
        Console.Write($"{res:f0}, ");
    }
    Console.WriteLine($"\b\b.");
}

Console.Write("Input number From: ");
int from = Convert.ToInt32(Console.ReadLine ());
Console.Write("Input number Till: ");
int till = Convert.ToInt32(Console.ReadLine ());
Console.Write("Input number Exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine ());
Cube (from,till,exponent);