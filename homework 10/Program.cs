//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
string [] test = { "qwe", "wer", "ert", "rty", "tyu"} ;
char[] symbols = {'a','e','y','u','i','o'};
void TestString (string [] a, char [] b)
{
int count=0;
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(test[i] + " ");
        for(int j = 0; j < a[i].Length; j++)
        {
            for(int c = 0; c < b.Length; c++)
            {
                if (j == 0&&a[i][j] == b[c])
                    {
                        count++;

                    }

            }
        }
    }
    Console.WriteLine(count);
}
TestString(test,symbols);
*/
//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
/*
string[] test = { "qwe", "wer", "ertq", "rty", "tyu", "yui"};
string[] TestString(string[] txt)
{
    string[] bom = new string[txt.Length];
    for (int i = 0; i < txt.Length - 1; i=i+2)
    {
        bom[i] = txt[i] +txt[i+1];
    }
    return bom;
}

void ShowArr(string[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(matrix[i] + " ");
    }
}

ShowArr(TestString(test));
*/