namespace Virtual_Methods
{
    using System;

    public class WrongFigure : Figure
    {
        public new void Draw()
        {
            Console.WriteLine("This method hides inherited member, does not override it!");
        }
    }
}
