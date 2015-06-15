using System;

class ButtonTest
{
    private static void Button_Click(object sender, EventArgs eventArgs)
    {
        Console.WriteLine("Button_Click() event called.");
    }

    static void Main()
    {
        Button button = new Button();
        button.Click += new ClickEventHandler(Button_Click);
        button.FireClick();
        button.Click -= new ClickEventHandler(Button_Click);
    }
}
