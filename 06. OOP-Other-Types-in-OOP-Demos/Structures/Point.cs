public struct Point
{
	public int X { get; set; }
	public int Y { get; set; }

    public void Move(int x, int y)
    {
        this.X += x;
        this.Y += y;
    }
}
