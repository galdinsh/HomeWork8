void InputMatrix(int[,,] matrix)
{
    Console.Write("Введите число начального элемента массива: ");
    int temp = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                 matrix[i, j, k] = temp;
                 temp++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) \t");
        }
    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);
PrintMatrix(matrix);

// void InputMatrix(int[,,] ThreeMatrix)
// {
//     int number = 10;
//     for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
//                 ThreeMatrix[i, j, k] = number++; 
//         }
//     }
// }


// void PrintMatrix(int[,,] ThreeMatrix)
// {
//     for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
//                 Console.WriteLine($"{ThreeMatrix[i, j, k]} ({i}, {j}, {k})");
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите размер трехмерного массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// while (size[0] * size[1] * size[2] > 90)
// {
//     Console.Write("Значения введены некорректные!\nВведите размер трехмерного массива: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,,] ThreeMatrix = new int[size[0], size[1], size[2]];
// InputMatrix(ThreeMatrix);
// PrintMatrix(ThreeMatrix);