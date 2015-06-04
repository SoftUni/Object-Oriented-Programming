public struct Color
{
    public Color(byte redValue, byte greenValue, byte blueValue)
        : this()
    {
        this.RedValue = redValue;
        this.GreenValue = greenValue;
        this.BlueValue = blueValue;
    }

    public byte RedValue { get; set; }

    public byte GreenValue { get; set; }

    public byte BlueValue { get; set; }
}
