/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i,j] = matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return resultMatrix;
}

int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов");
int[,] matrix1 = GetMatrix(m,n);
PrintMatrix(matrix1);
Console.WriteLine();
int a = GetNumber("Введите количество строк:");
int b = GetNumber("Введите количество столбцов");
int[,] matrix2 = GetMatrix(a,b);
PrintMatrix(matrix2);
Console.WriteLine();
if (n != a)
    {
        Console.WriteLine("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы!");
    } else {
        int[,] resultMatrix = GetMatrixMultiplication(matrix1, matrix2);
        PrintMatrix(resultMatrix);
    }

