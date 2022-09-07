// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int digit2 = number / 10 % 10; 
    Console.WriteLine($"Вторая цифра трехзначного числа { number } является {digit2}");
// System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

// System.Console.WriteLine(); 
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}