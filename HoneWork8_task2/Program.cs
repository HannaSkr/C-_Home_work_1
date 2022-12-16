/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/

//получить числа с консоли
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

//задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j ] = rnd.Next(1, 10);
        }
    }

    return matrix;
}
//распечатать матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

//найти строку с минимальной суммой элементов
void GetRowMinSum(int[,] matrix)
{
    int minsum = 0, row = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minsum += matrix[0,i];
    }        
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum; row = i;
        }             
    }
    Console.WriteLine($"Наименьшая сумма в строке = {minsum}");
    Console.WriteLine($"Номер строки с наименьшей суммой {row + 1}");
}

int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов");

int[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
GetRowMinSum(matrix);
