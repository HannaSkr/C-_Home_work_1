/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

//получить размер матрицы с консоли
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}
int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");

int s =1;
int[,] spiralArray = new int[m, n];

//заполняем периметр
for (int y = 0; y < n; y++)
{
    spiralArray[0,y] = s;
    s++;
}
for (int x = 1; x < m; x++)
{
    spiralArray[x, n - 1] = s;
    s++;
}
for (int y = n - 2; y >= 0; y--)
{
    spiralArray[m - 1, y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--)
{
    spiralArray[x, 0] = s;
    s++;
}

//заполнение внутри периметра
int a = 1;
int b = 1;
while (s < m * n)
{
    //идем вправо
    while (spiralArray[a, b+1] == 0)
    {
        spiralArray[a,b] = s;
        s++;
        b++;
    }
    //идем вниз
    while (spiralArray[a+1, b] == 0)
    {
        spiralArray[a,b] = s;
        s++;
        a++;
    }
    //идем влево
    while (spiralArray[a, b-1] == 0)
    {
        spiralArray[a,b] = s;
        s++;
        b--;
    }
    //идем вверх
    while (spiralArray[a-1, b] == 0)
    {
        spiralArray[a,b] = s;
        s++;
        a--;
    }
}
//заполняем последнюю ячейку
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (spiralArray[i,j] == 0)
        {
            spiralArray[i,j] = s;
        }
    }
}
//распечатать матрицу
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(String.Format("{0,3}", spiralArray[i, j]));
    }
    Console.WriteLine();
}




