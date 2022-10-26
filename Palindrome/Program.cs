/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Enter the five-digit number:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("reaped number: ");
void ChekingPalindrome(int a)
{
while(!int.TryParse(Console.ReadLine(), out a) ||  a <9999 || a > 99999)
{
    Console.WriteLine("type the correct(five-digit) number!");
}
if (a / 10000 == a % 10 || a / 1000 == a /10 % 10)
{
    Console.WriteLine("yep!");
}
else {
    Console.WriteLine("no!");
}
}
ChekingPalindrome(a);