using System;

public class Pentagon{
    
    private double side;
    
    public Pentagon(double side){
        this.side = side;
    }
    
    public double GetPerimeter(){
        return 5 * side;
    }
     public double GetArea(){
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2))/4 ;
     }

    public void Display(){
        Console.WriteLine("Side Length: {0}  ", side);
        Console.WriteLine("Perimeter: {0:F3}", GetPerimeter());
        Console.WriteLine("Area: {0:F3} ", GetArea());
        Console.WriteLine();
    }
}
public class Program{
    public static void Main(String[] args){
        Console.WriteLine("Pentagon p1: ");
        Pentagon p1 = new Pentagon(0);
        p1.Display();

        Console.WriteLine("Pentagon p2: ");
        Pentagon p2 = new Pentagon(5);
        p2.Display();
    }
}

