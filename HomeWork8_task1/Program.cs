/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

//отсортировать строки в массиве по убыванию
int[,] GetOrderInRow(int[,] matrix)
{
    int s = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,j]*s < matrix[i,k]*s)
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
         }  
    }
return matrix;
}

int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов");

int[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
int[,]resultMatrix = GetOrderInRow(matrix);
PrintMatrix(resultMatrix);