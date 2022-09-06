// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());

int digit1 = 7;
int digit2 = 23;
if(n % digit1 == 0 && n % digit2 == 0)
{
    Console.WriteLine("ДА"); 
}
else 
{
    Console.WriteLine("Нет");
}