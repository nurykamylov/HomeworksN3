/*Дополнительно.
Напишите программу, которая принимает на вход число (N) 
и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11*/

Console.WriteLine("Enter natural number: ");
int a = int.Parse(Console.ReadLine()!);
  bool isSimple(int N)
   {
            
      for (int i = 2; i <= (int)(N / 2); i++)
       {
         if (N % i == 0)
         return false;
       }
      return true;
   }
void Main(int a)
{

      
for (int i = 1; i <= a; i++)
{
   if (isSimple(i))
   {
   Console.Write($"{i},");
   }
}
}
  
    
Main(a);
