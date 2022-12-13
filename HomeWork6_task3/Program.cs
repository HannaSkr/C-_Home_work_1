/*Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/

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

//метод, который будет выдавать заполненный массив случайными числами
int[] InitArray(int dimension)
{
int[] array = new int[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
array[i] = rnd.Next(1,99);
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

int dimension = GetNumberFromConsole("Введите размерность массива");
int[] startArray = InitArray(dimension);
PrintArray(startArray);
Console.WriteLine();
int[] resultArray = (int[])startArray.Clone();
PrintArray(resultArray);

