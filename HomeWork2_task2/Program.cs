/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Random pkp = new Random();
int number = pkp.Next(); //любое число с любой разрядностью

Console.WriteLine($"{number}");

int digitIndex = 2; //индекс третьей цифры

if(number >  99)
{
    int digit = number.ToString()[digitIndex] - '0';
    Console.WriteLine(digit);
} else {
    Console.WriteLine("Третьей цифры нет");
}


