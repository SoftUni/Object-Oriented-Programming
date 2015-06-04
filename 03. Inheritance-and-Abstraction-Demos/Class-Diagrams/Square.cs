class Square : Shape, ISufraceCalculatable
{
    public Square(float size, int x, int y)
        : base(new Point(x, y))
    {
        this.Size = size;
    }

    private float Size { get; set; }

    public float CalculateSurface()
    {
        return this.Size * this.Size;
    }
}
