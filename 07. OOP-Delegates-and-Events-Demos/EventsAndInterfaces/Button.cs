using System;

public class Button : IClickable
{
    private ClickEventHandler click;

    // Implement the event from the interface IClickable
    public event ClickEventHandler Click
    {
        add
        {
            click += value;
            Console.WriteLine("Subscribed to Button.Clicked event.");
        }
        remove
        {
            click -= value;
            Console.WriteLine("Unsubscribed to Button.Clicked event.");
        }
    }

    protected void OnClick()
    {
        if (click != null)
        {
            click(this, EventArgs.Empty);
        }
    }

    public void FireClick()
    {
        Console.WriteLine("Button.FireClick() called.");
        OnClick();
    }
}
