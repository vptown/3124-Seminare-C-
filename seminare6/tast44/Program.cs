// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



 //f(n) = f(n-1) + f(n-2)

int Fibo(int num)
{
    int a = 0;
    int b = 1;
    int c = 1;
    Console.Write(a);
    Console.Write(b);
        
  
    for (int i = 2; i < num; i++)
    {
       c = a + b;
       a = b;
       b = c;
        Console.Write(c);
    }
    return c;
}

int number = ReadNumber("Введите число:");
int digits = Fibo(number);
//Console.WriteLine(digits);