﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
 
int NumberOfDigits(int n)
{
    int i = 0;
    for (i = 0; n>0; i++)
    {
        n = n/10;
    }
    return i;
}

int number = ReadNumber("Введите число:");
int digits = NumberOfDigits(number);
Console.WriteLine(digits);






// int GetCountOfDigits(int num)
// {
//     int count = 0; //число цифр (количество итераций цикла)
//     if (num == 0) count = 1;
//     while(num != 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// int number = ReadNumber("Введите число:");
// int count = GetCountOfDigits(number);
// Console.WriteLine(count);