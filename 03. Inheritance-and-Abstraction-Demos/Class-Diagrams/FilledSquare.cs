public class FilledSquare : Square
{
    public FilledSquare(float size, int x, int y, Color color)
        : base(size, x, y)
    {
        this.Color = color;
    }

    private Color Color { get; set; }
}
