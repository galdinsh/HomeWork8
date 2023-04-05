void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
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

int SumLine(int[,] matrix, int i)
{
  int sum = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sum += matrix[i,j];
  }
  return sum;
}

Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
int min = 0;
int sum = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumLine(matrix, i);
  if (sum > temp)
  {
    sum = temp;
    min = i;
  }
}
Console.WriteLine($"\n{min+1}-я строкa с наименьшей суммой ({sum})");


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//     }
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// int ReleaseMatrix(int[,] matrix)
// {
//     int minRow = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//         minRow += matrix[0, i];

//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sumRow += matrix[i, j];
//         }
//         if (minRow > sumRow)
//             minRow = sumRow;
//     }
//     return minRow;
// }


// Console.Clear();
// Console.Write("Введите размер прямоугольного двумерного массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// while (size[0] == size[1])
// {
//     Console.Write("Вы ошиблись!\nВведите размер прямоугольного двумерного массива: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный двумерный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine();
// Console.WriteLine($"Результат: {ReleaseMatrix(matrix)}");