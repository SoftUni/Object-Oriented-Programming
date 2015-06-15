using System;

public class TimeChangedEventArgs : EventArgs
{
    private int ticksLeft;

    public TimeChangedEventArgs(int ticksLeft)
    {
        this.ticksLeft = ticksLeft;
    }

    public int TicksLeft
    {
        get { return this.ticksLeft; }
    }
}
