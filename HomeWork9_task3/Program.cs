/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

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
            Console.WriteLine("Ввели не число или число меньше либо равно 1");
        }
    }

    return result;
}
int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0){
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}
int m = GetNumber("Введите число больше 0");
int n = GetNumber("Введите число больше 0");
int akkermanResult = AkkermanFunction(m, n);
Console.WriteLine($"Результат расчета функции Аккермана  {akkermanResult}");