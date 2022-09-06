// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировалось случайное число {number}");

int digit3 = number % 10;
int digit1 = number / 100;
// Console.Write(digit1);
// Console.Write(digit3);

//System.Console.WriteLine("Новое число:"+ digit1 + digit3);
int res = digit1 * 10 + digit3;
Console.WriteLine(res);