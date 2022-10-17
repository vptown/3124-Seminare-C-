// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Print1toN (int m, int n)
{
    if(n <= m)
    {
        return;
    }
    else 
    {
        Print1toN(m, n - 1);
        Console.Write(n + " ");
    }
    if(m <= n)
    {
        return;
    }
    else 
    {
        Print1toN(n, m - 1);
        Console.Write(m + " ");
    }
}

int m = ReadNumber( "Введите M");
int n = ReadNumber( "Введите N");
Print1toN(m,n);
Print1toN(n,m);