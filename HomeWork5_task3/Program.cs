/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
 и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] GetArray(int length)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10,10); //для наглядности задачи указан небольшой диапазон
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(double, double) GetMinAndMaxValue(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue) minValue = array[i];

        else if(array[i] > maxValue) maxValue = array[i];
    }
    return (minValue, maxValue);
}

Console.WriteLine("Ведите размер массива");
double[] array = GetArray(Convert.ToInt32(Console.ReadLine() ?? ""));
PrintArray(array);
Console.WriteLine();
(double minVal, double maxVal) = GetMinAndMaxValue(array);
Console.WriteLine($"Минимальное значение в массиве: {minVal}");
Console.WriteLine($"Максимальное значение в массиве: {maxVal}");
double result = maxVal - minVal;
Console.WriteLine($"Разница между максимальным и минимальным значением: {result}");