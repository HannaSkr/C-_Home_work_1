/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }

    return result;
}
int X1 = GetNumber("Введите абсциссу первой точки Х1");
int Y1 = GetNumber("Введите ординату первой точки Y1");
int Z1 = GetNumber("Введите аппликату первой точки Z1");
int X2 = GetNumber("Введите абсциссу второй точки Х2");
int Y2 = GetNumber("Введите ординату второй точки Y2");
int Z2 = GetNumber("Введите аппликату первой точки Z2");

/*B = √(xb - xa)**2 + (yb - ya)**2 + (zb - za)**2 */
double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
Console.WriteLine($"Расстояние между точками равно {result : 0.00}");
