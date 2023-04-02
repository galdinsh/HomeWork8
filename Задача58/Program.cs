﻿void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [0, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
void ProizvMatrix(int[,] matrix, int[,] matrix1, int[,] matrix2)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {  
        int sum = 0;
        for(int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum = sum + matrix1[i, k] * matrix2[k, j];
        }
      matrix[i, j] = sum;
      }
    }
}
Console.Clear();
Console.Write("Введите размеры первого массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
Console.Write("Введите размеры второго массива: ");
int[] size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size1[0], size1[1]];
while(size1[0] != size[1])
{
Console.WriteLine("Вы ошиблись. Число столбцов в первой матрице должно быть равно числу строк во второй матрице");
Console.Write("Введите размеры второго массива: ");
size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
matrix2 = new int[size1[0], size1[1]];
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
ProizvMatrix(matrix, matrix1, matrix2);
Console.WriteLine("Произведение матриц равно:");
PrintMatrix(matrix);

