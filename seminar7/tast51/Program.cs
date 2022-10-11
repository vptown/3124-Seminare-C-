// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
 

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
   for(int i = 0;  i < matrix.GetLength(0); i++ )
   {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
   }
   return matrix;
}

void PrintMatrix(int[,] matrix)
{
for(int i = 0;  i < matrix.GetLength(0); i++ )
   {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
   }
}

void PosMatrix(int[,] matrix)
{
for(int i = 0;  i < matrix.GetLength(0); i+= 2)
   {
        for(int j = 0; j < matrix.GetLength(1); j+= 2)
        {
           matrix[i,j] = matrix[i,j] * matrix[i,j];
          
        }

        Console.WriteLine();
        
   }
   
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
PosMatrix(matr);
PrintMatrix(matr);