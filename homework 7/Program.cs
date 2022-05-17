//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Write("input size row: ");
int sizeRow = Convert.ToInt32(Console.ReadLine());
Console.Write("input size column: ");
int sizeColumn = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[sizeRow,sizeColumn];

void CreateMatrixDouble(double[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteMatrix(double[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double Number = Math.Round(array[i, j], 1);
            Console.Write(Number + "");
        }
        Console.WriteLine();
    }
}
CreateMatrixDouble(matrix);
WriteMatrix(matrix);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int FindNumMatrix(int[,] matrix, int i1, int j1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i1 < matrix.GetLength(0) && j1 < matrix.GetLength(1))
                return matrix[i1, j1];
            else
            {
                Console.WriteLine("there is no such number in the array");

            }  

        }
    }
  return 0;

}

Console.Write("input size row-> ");
int sizeRow = Convert.ToInt32(Console.ReadLine());
Console.Write("input size column-> ");
int sizeСolumn = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[sizeRow, sizeСolumn];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("input  row-> ");
int findRow = Convert.ToInt32(Console.ReadLine());
Console.Write("input  column-> ");
int findColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumMatrix(matrix, findColumn, findRow));
//я не знал как решать,как смог(((



//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце
void averageOfNUmbersColumn(int[,] matrix)
{
    double sum = 0;
    double average = 0;
    double count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            count++;
        }
        Math.Round(average = sum / count);
        Console.Write(average + "; ");
        count = 0;
        sum = 0;
    }
}

Console.Write("input size row: ");
int sizeRow = Convert.ToInt32(Console.ReadLine());
Console.Write("input size column: ");
int sizeСolumn = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[sizeRow, sizeСolumn];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
averageOfNUmbersColumn(matrix);
*/