public abstract class Shape
{
    protected Shape(Point position)
    {
        this.Position = position;
    }

    protected Point Position { get; set; }
}