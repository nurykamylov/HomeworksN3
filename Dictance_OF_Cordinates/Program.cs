/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int x1 = 3, y1 = 5, z1 = 8,
    x2 = 2, y2 = 5, z2 = -7;
   

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

     else if ( x1 < x2 && y1 > y2)
    {
        double distance = Math.Sqrt((x2 - x1)* (x2 -x1) + (y1 - y2)*(y1 - y2));
        Console.WriteLine(distance);
    }

    else if ( x1 > x2 && y1 < y2)
    {
        double distance = Math.Sqrt((x1 - x2)* (x1 -x2) + (y1 - y2)*(y1 - y2));
        Console.WriteLine(distance);
    }
  
}
void DistanceOfPointsThreeCordinate( int x1, int y1, int z1, int x2, int y2, int z2)
{
    
    if ( x1 > x2 && y1 > y2 && z1 > z2 )
    {
       double distance = Math.Sqrt((x1 - x2)* (x1 -x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
      Console.WriteLine(distance);
    }   
    else if ( x1 < x2 && y1 < y2 && z2 > z1 )
    {
        
        double distance = Math.Sqrt((x2 - x1)* (x2 -x1) + (y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));
       Console.WriteLine(distance);
    }
  
}


  if( x1 == x2 && y1 > y2 && z1 > z2 || y2 > y1 && z2 > z1 )
    {
      DistanceOfPoints(y1, z1, y2, z2);
    }
   
    else if ( y1 == y2 && x1 > x2 && z1 > z2 || x2 > x1 && z2 > z1 )
    {
       DistanceOfPoints(x1, z1, x2, z2);
    }
  
   else if ( z1 == z2 && x1 > x2 && y1 > y2 || x2 > x1 && y2 > y1 )
    {
       DistanceOfPoints(x1, y1, x2, y2);
    }

    else if ( x1 == x2 && y1 == y2 && z1 > z2 )
    {
        int distance = z1 - z2;
        Console.WriteLine(distance);
    }

    else if ( x1 == x2 && y1 == y2 && z1 < z2 )
    {
        int distance = z2 - z1;
        Console.WriteLine(distance);
    }

    else if ( x1 == x2 && z1 == z2 && y1 > y2 )
    {
        int distance = y1 - y2;
        Console.WriteLine(distance);
    }

    else if ( x1 == x2 && z1 == z2 && y1 < y2 )
    {
        int distance = y2 - y1;
        Console.WriteLine(distance);
    }

    else if ( y1 == y2 && z1 == z2 && x1 > x2 )
    {
        int distance = x1 - x2;
        Console.WriteLine(distance);
    }

    else if ( y1 == y2 && z1 == z2 && x1 < x2 )
    {
        int distance = x2 - x1;
        Console.WriteLine(distance);
    }

    else 
    {
        DistanceOfPointsThreeCordinate(x1, y1, z1, x2, y2, z2);
    }