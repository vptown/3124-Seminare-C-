// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3int ReadNumber(string message)
Console.WriteLine("Введите число: ");
Console.WriteLine("Чтобы остановить цикл введите: stop ");
int count = 0;
while (true)
{

    string s = Console.ReadLine();
    if (s == "stop") break;
    

    else
    {
        int x = Convert.ToInt32(s);

        if (x > 0)
        {
            count++;
        }
    }
}
Console.Write($"Количество положительных чисел равно {count}");


