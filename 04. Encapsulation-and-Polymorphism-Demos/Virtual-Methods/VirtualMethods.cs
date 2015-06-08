using System;
using Virtual_Methods;

public class VirtualMethods
{
    public static void Main()
    {
        Figure[] figures = 
        {
			new Line(),
			new Circle(),
			new Line(),
			new SpecialFigure(),
			new Line(),
            new WrongFigure()
		};

        foreach (var f in figures)
        {
            f.Draw();
            Console.WriteLine();
        }
    }
}
