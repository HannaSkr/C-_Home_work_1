/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

//получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите число");
}
}

return result;
}

//метод, получает массив путем ввода его элементов пользователем
int[] InitArray(int dimension)
{
int[] array = new int[dimension];

for (int i = 0; i < dimension; i++)
{
Console.WriteLine($"Введите {i}-тый элемент массива ");
array[i] = int.Parse(Console.ReadLine() ?? "");
}

return array;
}

//метод, который будет печатать массив
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

//метод подсчета положительных чисел в массиве
int GetNumbersPositive(int[] array)
{
    int countNumberPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) countNumberPositive += 1;
    }
return countNumberPositive;
}

int dimension = GetNumberFromConsole("Введите количество элементов массива");
int[] startArray = InitArray(dimension);
PrintArray(startArray);
Console.WriteLine($"Количество положительных элементов массива: {GetNumbersPositive(startArray)}");