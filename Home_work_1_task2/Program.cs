/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberThird = Convert.ToInt32(Console.ReadLine());

if(numberFirst > numberSecond && numberFirst > numberThird)
{
    Console.WriteLine($"max = {numberFirst}");
}else if(numberSecond > numberFirst && numberSecond > numberThird)
    {
       Console.WriteLine($"max = {numberSecond}"); 
    } else if(numberThird > numberFirst && numberThird > numberSecond)
    {
       Console.WriteLine($"max = {numberThird}");
    }
else{
        Console.WriteLine("Что-то пошло не так..."); //по условию задачи не требуется что-то предпринимать, если числа равны, но на всякий случай оставляем себе оправдание

}
