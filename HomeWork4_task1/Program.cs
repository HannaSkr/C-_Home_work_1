/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetNumber(string message)
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
            Console.WriteLine("Ввели не число");
        }
    }
    
    return result;
}

int numberFirst = GetNumber("Введите число");
int numberSecond = GetNumber("Введите число");
int result = 1;

for (int i = 1; i <= numberSecond; i++)
{
    result = result * numberFirst;
}
Console.WriteLine($"Число А {numberFirst} в степени В {numberSecond} равно {result}");