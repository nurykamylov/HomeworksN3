/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Enter the natural number:");
int a = int.Parse(Console.ReadLine()!);
double i = 1;
while( i <= a)
{
    Console.Write(Math.Pow(i, 3));
    Console.Write(",");
    i++;
}

