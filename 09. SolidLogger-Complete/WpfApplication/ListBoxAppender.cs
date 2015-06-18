namespace WpfApplication
{
    using System;
    using System.Windows.Controls;
    using SOLIDLogger;
    using SOLIDLogger.Appenders;
    using SOLIDLogger.Interfaces;

    public class ListBoxAppender : Appender
    {
        public ListBoxAppender(IFormatter formatter, ListBox listBox)
            : base(formatter)
        {
            this.ListBox = listBox;
        }

        public ListBox ListBox { get; private set; }

        public override void Append(string msg, ReportLevel level, DateTime date)
        {
            string output = this.Formatter.Format(msg, level, date);

            this.ListBox.Items.Add(output);
        }
    }
}
