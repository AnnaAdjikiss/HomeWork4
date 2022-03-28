// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// пример:     3, 5 -> 243 (3⁵)        2, 4 -> 16
/*
int Degree (int valueA, int valueB)
{
    int result = 1;
    for (int i = 1; i <= valueB; i++) 
    {
        result = result * valueA;
    }
    return result;
}
Console.WriteLine("Введите целое число, которое будем возводить в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число, которое будет степенью: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB > 0)
{
int degree = Degree(numberA, numberB);
Console.Write(numberA + " в степени " + numberB + " получится " + degree);
}
if (numberB == 0)
{
Console.Write("Любое число в нулевой степени - это еденица");
}
*/

// Задача2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример:  452 -> 11   82 -> 10    9012 -> 12
/*
int Summ (int value)
{
    int result = 0;
    while (value > 9) 
    {
        result = result + value % 10;
        value = value / 10;
    }
    return result + value;
}
Console.WriteLine("Введите целое натуральное число, состоящее из нескольких цифр: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма цифр в числе будет " + Summ(number));
*/

//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример:  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]      6, 1, 33 -> [6, 1, 33]

void Array ()
{
    int [] massiv = new int [8];

    for (int i = 0; i < 8; i++)
    {
        massiv[i] = new Random().Next(0,100);
        Console.Write(massiv[i] + " ");
    }
}
Array ();














