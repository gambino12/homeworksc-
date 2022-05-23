/*
// Задайте двумерный массив. Напишите программу, которая упорядочит
// по возрастанию элементы каждой строки двумерного массива.
int[,] CreateMatrix(int sizeRow, int sizeColumn)
{
    int[,] matrix = new int[sizeRow, sizeColumn];
    for (int i = 0; i < sizeRow; i++)
    {
        for (int j = 0; j < sizeColumn; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int[,] ChangeRowAndCol(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int q = 0; q < matrix.GetLength(1); q++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

    Console.Write("input size row: ");
    int sizeRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("input size column: ");
    int sizeColumn = Convert.ToInt32(Console.ReadLine());

    int[,] mymat = CreateMatrix(sizeRow, sizeColumn);
    ShowMatrix(mymat);
    Console.WriteLine("--------");
    int[,] change = ChangeRowAndCol(mymat);
    ShowMatrix(change);
 
//Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов

int[,] CreateMatrix(int sizeRow, int sizeColumn)
{
    int[,] matrix = new int[sizeRow, sizeColumn];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void LittleSumNum(int[,] matrix)
{
    int minCol = 0;
    int sum = 0;
    int minNum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += matrix[i, j];
                minNum += matrix[i, j];
            }
            else
                sum += matrix[i, j];
        }
        if (sum < minNum)
        {
            minCol = i;
            minNum = sum;
        }
        sum = 0;
    }

    Console.Write(minCol + " ");
}

Console.Write("input size row: ");
int sizeRow = Convert.ToInt32(Console.ReadLine());
Console.Write("input size column: ");
int sizeColumn = Convert.ToInt32(Console.ReadLine());
if (sizeColumn == sizeRow)
    Console.Write("error404");
else
{
    int[,] mymat = CreateMatrix(sizeRow, sizeColumn);
    ShowMatrix(mymat);
    Console.WriteLine("-------------------");
    LittleSumNum(mymat);
}
 
//Задача 62. Заполните спирально массив 4 на 4.

int[,] CreateSpiralMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int num = 0;

    for (int i = 0; i < size ; i++)
    {
        for (int j = i; j < size - i; j++)
        {
            matrix[i, j] = num;
            num++;
        }
        for (int q = i + 1; q < size - i; q++)
        {
            matrix[q, size - i - 1] = num;
            num++;
        }
        for (int j = size - i - 2; j > i; j--)
        {
            matrix[size - i -1, j] = num;
            num++;
        }
        for (int q = size - 1 - i; q > i; q--)
        {
            matrix[q, i] = num;
            num++;
        }
    }
    return matrix;

}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}


Console.Write("input size matrix->");
int sizematrix = Convert.ToInt32(Console.ReadLine());
int[,] myMat = CreateSpiralMatrix(sizematrix);
ShowMatrix(myMat);

*/