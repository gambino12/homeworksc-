
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

int [] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size;i++)
    {
        Console.Write("input " + i + " element ->");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

void NumbersBiggerThenNull(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        count++;
    }
    Console.Write("-> " + count);
}

Console.Write("how many numbers will there be? -> ");
int size = Convert.ToInt32(Console.ReadLine());
int [] Myarr = CreateArray(size);
ShowArray(Myarr);
NumbersBiggerThenNull(Myarr);

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void ConvertFrom10to2 (int a)
{
    int a1 = a;
    int yn;
    int count = 1;
    int result = 0;

    while(a1 > 0)
    {
        a1 = a/2;
        yn = a - a1*2;
        a = a1;
        result = result + yn*count;
        count=count*10;
    }
Console.WriteLine(result);
}

Console.Write("input natural number -> ");
int a = Convert.ToInt32(Console.ReadLine());
ConvertFrom10to2(a);
*/
//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//k1*x+b1=k2*x+b2
//x=(b2-b1)/(k1-k2)
//y=k1(b2-b1)/(k1-k2)+b1
void CrossLineDot(double b1, double k1, double b2, double k2)
{
double x =(b2-b1)/(k1-k2);
double y=k1*(b2-b1)/(k1-k2)+b1;
if(k1==k2&&b1==b2)
{
Console.WriteLine("line is same");
}
else if(k1==k2)
{
Console.WriteLine("line is parallel");
}
Console.WriteLine(x+ "-x "+ y+ "-y");
}
Console.Write("Input b1 -> ");
double bf = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1 -> ");
double kf = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2 -> ");
double bs = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2 -> ");
double ks = Convert.ToInt32(Console.ReadLine());
CrossLineDot(bf,kf,bs,ks);