/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

//ввести данные с консоли
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

int b1 = GetNumberFromConsole("введите b1");
int k1 = GetNumberFromConsole("введите k1");
int b2 = GetNumberFromConsole("введите b2");
int k2 = GetNumberFromConsole("введите k2");
//вычислить координаты точки пересечения
double x = (b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 Console.WriteLine($"Пересечение в точке: ({x};{y})");


