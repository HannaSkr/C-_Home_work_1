/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GetArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100,1000);
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

int GetEvenNumbers(int[] array)
{
    int countEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) countEvenNumbers += 1;
    }
    return countEvenNumbers;
}

Console.WriteLine("Ведите размер массива");
int[] array = GetArray(int.Parse(Console.ReadLine()?? ""));

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {GetEvenNumbers(array)}");