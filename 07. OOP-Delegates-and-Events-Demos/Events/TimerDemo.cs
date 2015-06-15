using System;

public class TimerDemo
{
    public static void Main()
    {
        Timer timer = new Timer(10, 1000);
        timer.TimeChanged += new TimeChangedEventHandler(Timer_TimeChanged);

        Console.WriteLine("Timer started for 10 ticks at interval 1000 ms.");
        timer.Run();
    }

    private static void Timer_TimeChanged(object sender,
        TimeChangedEventArgs eventArgs)
    {
        Console.WriteLine("Timer! Ticks left = {0}", eventArgs.TicksLeft);
    }
}
