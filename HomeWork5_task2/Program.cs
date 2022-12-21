/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-100,100); //для наглядности задачи указан небольшой диапазон
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetSummOddPosition(int [] array)
{
   int summOdds = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(i % 2 != 0) summOdds += array[i];
    }
    return summOdds;
}

Console.WriteLine("Ведите размер массива");
int[] array = GetArray(int.Parse(Console.ReadLine() ?? ""));
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве: {GetSummOddPosition(array)}");
