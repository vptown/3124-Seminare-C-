// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



int[] GetArray(int size,int leftRange,  int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int Max (int[] arr)
{
     int max = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
        max = arr[i]; 
        }
    }
    return max;
}

int Min (int[] arr)
{
     int min = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
        min = arr[i]; 
        }
    }
    return min;
}
int [] array = GetArray( 10, 1, 30);
 Console.WriteLine(string.Join(", ", array));
int maxArray =  Max(array);
//Console.WriteLine($"максимальное число {maxArray}");
int minArray =  Min(array);
//Console.WriteLine($"минимальное число {minArray}");
Console.WriteLine($"Максимальное число массива {maxArray}, минимальное число {minArray}");
Console.WriteLine($"Разница между максимальным числом и минимальным равна {maxArray - minArray}");