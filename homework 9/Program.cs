//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNaturalNumbers(int m, int n)
{
    if (n < m)
    {
        if (m == n)
        {
            return n;
        }

        return m + SumOfNaturalNumbers(m-1, n);
    }

    {
        if (m == n)
        {
            return n;
        }
        return m + SumOfNaturalNumbers(m + 1, n);
    }
}

Console.Write("input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(SumOfNaturalNumbers(m, n));

//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int sumNum(int num)
{
    if (num / 10! == 0)
    {
        return num % 10;
    }
    return num % 10 + sumNum(num / 10);
}

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(sumNum(number));
*/
