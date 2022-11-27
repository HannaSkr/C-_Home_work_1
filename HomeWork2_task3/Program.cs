/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/
Console.WriteLine("Введите номер сегодняшнего дня недели: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

if(numberFirst == 6 || numberFirst == 7)
{
    Console.WriteLine("Поздравляем! Сегодня - выходной");
} else if(numberFirst > 1 && numberFirst < 5)
{
    Console.WriteLine("К сожалению, сегодня - рабочий день");
} else {
    Console.WriteLine("Вы ввели не день недели");
}

