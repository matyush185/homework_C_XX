// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void RandDigit ()
{
    int number;
    // Console.Write("Input minVal: ");
    // int minVal = Convert.ToInt32(Console.ReadLine ());
    // Console.Write("Input maxVal: ");
    // int maxVal = Convert.ToInt32(Console.ReadLine ());    
    // if (minVal >= maxVal)
    // {
    //     Console.WriteLine($"{maxVal} should be bigger {minVal}");
    //     number = new Random().Next(maxVal, minVal+1);
    // }
    // else
    // {
    //     number = new Random().Next(minVal, maxVal+1);
    // }

    number = new Random().Next(100, 1000);
    Console.WriteLine($"Random num is {number} ");
    int dec = number / 10;
    int ed  = dec % 10;
    Console.WriteLine($"Second digit is {ed} ");
}

// RandDigit();

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdDigit ()
{
    // int number;
    Console.Write("Input Number: ");
    string num_str1 = Console.ReadLine ();
    // Console.Write("Input maxVal: ");
    // int maxVal = Convert.ToInt32(Console.ReadLine ());    
    // if (minVal >= maxVal)
    // {
    //     Console.WriteLine($"{maxVal} should be bigger {minVal}");
    //     number = new Random().Next(maxVal, minVal+1);
    // }
    // else
    // {
    //     number = new Random().Next(minVal, maxVal+1);
    // }

    // number = new Random().Next(100, 1000);
    // Console.WriteLine($"Random num is {number} ");
    int num1 = Convert.ToInt32(num_str1);
    int len = num_str1.Length;
    int count_i = 0;
    int count_r = len-3;
    int num2 = num1;
    int ed;

    Console.WriteLine($"{len} is number of digits");

    if (len < 3)
    {
        Console.WriteLine($"Third digit is null ");        
    }
    else if (len == 3)
    {
        ed = num2 % 10;
        Console.WriteLine($"Third digit is {ed} ");
    }
    else
    {   
        while (count_i < count_r)
        {
            count_i ++;
            num2 = num2 / 10;
        }
        ed = num2 % 10;
        Console.WriteLine($"Third digit is {ed} ");
    }

    // int dec = num1 / 100;
    // int ed  = dec % 10;
    // if (dec == 0)
    // {
    //     Console.WriteLine($"Third digit is null ");        
    // }
    // else
    // {
    //     Console.WriteLine($"Third digit is {ed} ");
    // }
}

// ThirdDigit ();

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void WeekendDay (int number)
{
if (number > 7 || number <= 0)
{
    Console.WriteLine($"{number} -> нет");
}
else if (number > 5 && number <= 7)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");    
}
}

Console.Write("Input Digit: ");
int weekendDay = Convert.ToInt32(Console.ReadLine ());

WeekendDay (weekendDay);