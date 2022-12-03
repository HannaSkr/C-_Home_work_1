/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


Console.Write("Введите количество элементов массива:\t");
int elementsNumber = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsNumber];
Random asd = new Random();

for(int i = 0; i < myArray.Length; i++)
{
        myArray[i] = asd.Next(0, myArray.Length);             
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", myArray));
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", myArray)}]");