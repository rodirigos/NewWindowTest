using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NewWindowTest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var window = new Window();
                StackPanel mainContent = new StackPanel()
                {
                    Background = new SolidColorBrush(Colors.Black),

                };
                var text = new TextBlock
                {
                    Text = $"Test {i}",
                    IsColorFontEnabled = true,
                    Foreground = new SolidColorBrush(Colors.White),
                };
                mainContent.Children.Add(text);
                window.Content = mainContent;
                window.Activate();
            }
        }
    }
}
