/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 10000)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели НЕ пятизначное число. Введите корректное число");
        }
    }

    return result;
}

int numberFirst = GetNumber("Введите пятизначное число");
string x1 = Convert.ToString(numberFirst);
char[] arr = x1.ToCharArray();
Array.Reverse(arr);
string x2 = new String(arr);
 
if (x1 == x2) Console.WriteLine("Палиндром");
 else Console.WriteLine("Не палиндром");

