using System;

public class Polymorphism
{
    public static void Main()
    {
        Figure[] figures = { 
            new Square { Size = 3 }, 
            new Circle { Radius = 2 }, 
            new Rectangle { Width = 2, Height = 3 }, 
            new Circle { Radius = 3.5 }, 
            new Square { Size = 2.5 }, 
            new Square { Size = 4 }, 
            new SpecialSquare { Size = 3 } 
        };

        foreach (Figure figure in figures)
        {
            Console.WriteLine(
                "Figure = {0} surface = {1:F2}",
                figure.GetType().Name.PadRight(15, ' '),
                figure.CalcSurface());
        }
    }
}
