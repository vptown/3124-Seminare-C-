// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//  в которой находится эта точка.

Console.WriteLine("Введите координату точки по X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по Y:");
int y = Convert.ToInt32(Console.ReadLine());

if ( x > 0 && y > 0 )
{
    Console.WriteLine("Точка находиться в первой координатной плоскости");
}

else if ( x < 0 && y > 0 )
{
    Console.WriteLine("Точка находиться в второй координатной плоскости");
}

else if ( x < 0 && y < 0 )
{
    Console.WriteLine("Точка находиться в третьей координатной плоскости");
}

else if ( x > 0 && y < 0 )
{
    Console.WriteLine("Точка находиться в четвертой координатной плоскости");
}

else 
{
    Console.WriteLine("Введена нулевая координата по X и/или Y");
}