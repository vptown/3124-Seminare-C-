// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (number > 5) txtResult = $" выходной день";
else txtResult = $", рабочий день.";


Console.WriteLine($"{number}-й день недели - это {Days[number - 1]}{txtResult}");
