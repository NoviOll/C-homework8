// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int m = 3;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine("Массив равен");
PrintArray(array);
SortArray(array);
Console.WriteLine("Строки отсортированы по убыванию");
PrintArray(array);
void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
void SortArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] > numbers[i, z + 1])
                {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
}


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int m = 3;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
int minsum = Int32.MaxValue;
int index = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов - " + index);
void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int a = 2;
int b = 2;
int m = 2;
int n = 2;
int[,] array1 = new int[a, b];
int[,] array2 = new int[m, n];
FillArray(array1);
FillArray(array2);
int c = a;
int d = b;
if (a > m)
{
    c = m;
} 
if (b > n) 
{
    d = n;
}
int[,] array3 = new int[c, d];
for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = array1[i, j] * array2[i, j];
        }
Console.WriteLine("Первая матрица");
PrintArray(array1);
Console.WriteLine("Вторая матрица");
PrintArray(array2);    }
Console.WriteLine("Итоговая матрица");
PrintArray(array3);
void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine("");
    }
}