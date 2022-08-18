// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 5);
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
        if(j == 0) Console.Write("[");
        if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},");
        else Console.Write($"{matrix[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

void SumNumbers (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double average = 0;
        for (int t = 0; i < matrix.GetLength(1); i++)
        {
            average += matrix[t, i];
        }
        double result = average/matrix.GetLength(0);
        result = Math.Round(result, 1);
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {result}");
    }
}
    

int[,] matrixRes = GetMatrix(3, 6);
PrintMatrix(matrixRes);
Console.WriteLine();
SumNumbers(matrixRes);
