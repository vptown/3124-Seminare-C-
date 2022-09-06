// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число 1:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int numberB = Convert.ToInt32(Console.ReadLine());
// int mod = numberA % numberB
//if (mod == o)
if(numberA % numberB == 0)
{
    Console.WriteLine($"Число {numberA} и число {numberB} кратны");
}
else
{
    Console.WriteLine($"Число{numberA} и {numberB} не кратное, остаток от деления {numberA % numberB} ");
}
