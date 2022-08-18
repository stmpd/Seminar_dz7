// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 >>> такого числа в массиве нет


Console.WriteLine("Введите номер строки: ");
int posString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int posColumn = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;   
}

int NumberSearch (int[,] matrix)
{
    int num = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == posString - 1 && j == posColumn - 1)
            {
                num = matrix[i,j];
            }
        }
    }
    return num;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},");
            else Console.Write($"{matrix[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

int[,] matrixRes = GetMatrix(3, 5);
PrintMatrix(matrixRes);
Console.WriteLine();
int numberSearch = NumberSearch(matrixRes);

if (numberSearch == 0)
    {
        Console.WriteLine($"{posString}, {posColumn} >>> такой позиции нет в массиве");
    }
else if (numberSearch > 0)
    {
        Console.WriteLine($"{posString}, {posColumn} >>> {numberSearch}");
    }
