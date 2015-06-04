public class Rectangle : Shape, ISufraceCalculatable
{
    public Rectangle(float width, float height, int x, int y)
        : base(new Point(x, y))
    {
        this.Width = width;
        this.Height = height;
    }

    private float Width { get; set; }

    private float Height { get; set; }

    public float CalculateSurface()
    {
        return this.Width * this.Height;
    }
}
