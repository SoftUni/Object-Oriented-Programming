public class FilledRectangle : Rectangle
{
    public FilledRectangle(float width, float height, int x, int y, Color color)
        : base(width, height, x, y)
    {
        this.Color = color;
    }

    private Color Color { get; set; }
}
