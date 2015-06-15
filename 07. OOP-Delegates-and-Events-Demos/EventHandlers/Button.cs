using System;

public class Button
{
    public event EventHandler Click;
    //public event EventHandler GotFocus;
    //public event EventHandler TextChanged;

    protected void OnClick()
    {
        if (this.Click != null)
        {
            this.Click(this, new EventArgs());
        }
    }

    public void FireClick()
    {
        this.OnClick();
    }
}
