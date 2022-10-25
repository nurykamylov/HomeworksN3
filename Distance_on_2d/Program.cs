/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

int x1 = 1, y1 = -3,
    x2 = 3, y2 = 9;

void DistanceOfPoints( int x1, int y1, int x2, int y2)
{
    
    if ( x1 > x2 && y1 > y2 )
    {
       double distance = Math.Sqrt((x1 - x2)* (x1 -x2) + (y1 - y2)*(y1 - y2));
      Console.WriteLine(distance);
    }   
    else if ( x1 < x2 && y1 < y2 )
    {
        
        double distance = Math.Sqrt((x2 - x1)* (x2 -x1) + (y2 - y1)*(y2 - y1));
       Console.WriteLine(distance);
    }
  
}

  if( x1 == x2 && y2 > y1 )
    {
        int distance = y2 - y1;
        Console.WriteLine(distance);
    }
    
    else if( x1 == x2 && y2 < y1)
    {
        int distance = y1 - y2;
        Console.WriteLine(distance);
    }

    else if ( y1 == y2 && x2 < x1)
    {
        int distance = x1 - x2;
        Console.WriteLine(distance);
    }
  
    else if ( y1 == y2 && x2 > x1)
    {
        int distance = x2 - x1;
       Console.WriteLine(distance);
    }
    else 
    {
        DistanceOfPoints(x1, y1, x2, y2);
    }