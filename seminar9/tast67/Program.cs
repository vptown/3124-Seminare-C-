// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNunber (int n)
{
    if(n / 10 == 0)
    {
        return n;
    }
    else
    {
        int sum = 0;
        sum += SumNunber( n / 10) + n % 10;
        return sum;
    }
}

int number = ReadNumber("Введите число: ");
int sum = SumNunber(number);
Console.WriteLine(sum);