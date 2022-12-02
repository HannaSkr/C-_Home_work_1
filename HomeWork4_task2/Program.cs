/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

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

int GetSumDigit(int number)
{
    if (number < 10)
    return number;

    int digit = number % 10;
    int nextNumber = number / 10;
    return digit + GetSumDigit(nextNumber);
}

int number = GetNumber("Введите число");
int sumDigit = GetSumDigit(number);
Console.WriteLine($"Сумма цифр введенного числа равна {sumDigit}");
