namespace WpfApplication
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    using SOLIDLogger;
    using SOLIDLogger.Appenders;
    using SOLIDLogger.Formatters;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Logger logger;

        public MainWindow()
        {
            this.InitializeComponent();

            var simpleFormatter = new SimpleFormatter();

            ListBox listBox = (ListBox) this.FindName("ListBox");

            var listBoxAppender = new ListBoxAppender(simpleFormatter, listBox);
            var fileAppender = new FileAppender(simpleFormatter, "simple.txt");
            this.logger = new Logger(fileAppender, listBoxAppender);

            this.KeyDown += this.MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            this.logger.Info(e.Key.ToString());
        }
    }
}
