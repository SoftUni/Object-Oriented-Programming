using System;
using System.Windows.Forms;

class AnonymousMethods
{
    static void Main()
    {
        // Method syntax
        Action<string> action = ShowMsg;

        // Delegate syntax
        action = delegate(string msg)
        {
            MessageBox.Show(msg);
        };

        // Lambda syntax
        action = (msg) =>
        {
            MessageBox.Show(msg);
        };

        action("Hello!");
    }

    static void ShowMsg(string msg)
    {
        MessageBox.Show(msg);
    }
}
