/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

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

int SumInterval (int n, int m)
{
    if (n > m)
    {
        if (n == m) return n;
        return SumInterval(n-1, m) + n;
    } else {
        if (n == m) return n;
        return SumInterval(n-1, m) + n;
    }     
}
  
int m = GetNumber("Введите число больше 0");
int n = GetNumber("Введите число больше 0");
int resultSumm = SumInterval(n, m);
Console.WriteLine($"Сумма чисел в интервале от  {m}  до {n} равна  {resultSumm}");
