/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

//получение числа с консоли
int GetNumberFromConsole(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result)&& result>0)
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите число");
}
}

return result;
}

int[] NumberFibonachi(int[] array,int num)
{
array[0]=0;
array[1]=1;
array[2]=1;
for (int i = 3; i < num; i++)
{
array[i]= array[i-1] + array[i-2];
}
return array;
}

//метод, который будет печатать массив
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

int num = GetNumberFromConsole("Введите число");
int[] arra = new int[num];
arra = NumberFibonachi(arra,num);
PrintArray(arra);