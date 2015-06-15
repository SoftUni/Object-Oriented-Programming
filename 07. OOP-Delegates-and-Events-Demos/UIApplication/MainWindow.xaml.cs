namespace UIApplication
{
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.MouseDown += this.MainWindow_MouseClick;

            var button = (Button) this.FindName("DownloadButton");
            button.Click += this.Button_Click;
        }

        private void MainWindow_MouseClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(string.Format("Mouse clicked at ({0}, {1})",
                e.MouseDevice.GetPosition(this).X, e.MouseDevice.GetPosition(this).Y));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox) this.FindName("UrlBox");
            string url = textBox.Text;

            var progress = (Label) this.FindName("Progress");

            using (var client = new WebClient())
            {
                progress.Content = "Downloading...";
                await client.DownloadFileTaskAsync(url, "../../site.html");

                progress.Content = "Done!";
            }
        }
    }
}
