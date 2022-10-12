// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


void ReverseArray(int[,] matrix)
{
    int temp;
    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           
            
                temp = matrix[0, j];
                matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
                matrix[matrix.GetLength(0) - 1, j] = temp;
            
        }
        Console.WriteLine();
    }
    


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
ReverseArray(matrix);
PrintMatrix(matrix);



// void ReverseArray(int[] array)
// {
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }