using System.Windows;

namespace medFactory.UI.Styles
{
    partial class Window
    {
        public Window()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = WindowState.Minimized;

        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window)((FrameworkElement)sender).TemplatedParent;

            if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
            else
                window.WindowState = WindowState.Maximized;
            // MaximizeButton.Click += (sender, e) => WindowState = (WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }
    }
}
