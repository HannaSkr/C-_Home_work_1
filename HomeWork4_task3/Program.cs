/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


Console.Write("Введите количество элементов массива:\t");
int elementsNumber = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsNumber];

for(int i = 0; i < myArray.Length; i++)
{
        myArray[i] = new Random().Next(0, myArray.Length);
        Console.Write($"{myArray[i]} ");
}

