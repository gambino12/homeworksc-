/*
//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("input A-> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input B-> ");
int b = Convert.ToInt32(Console.ReadLine());

    int NaturalDegree = 1;
    int count = 0;
    while (count < b)
    {
     NaturalDegree = a * NaturalDegree;
     count++;
    }
Console.Write(NaturalDegree );

//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        if (num%10 == 0)
            num = num/10;
        sum = num%10 + sum;
        num = num / 10;
    }
    return sum;

}
Console.Write(sumOfDigits(1206020));

//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateRandomArray(int size, int min,int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size;i++)
    {
        array[i] = new Random().Next(min, max+1); 
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
int[] myarr = CreateRandomArray(8,-100,100);
ShowArray(myarr);
*/