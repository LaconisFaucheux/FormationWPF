using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormationWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Foreground = Brushes.Peru;
            myLabel.FontSize += 1;
        }

        private void myButton_MouseEnter(object sender, MouseEventArgs e)
        {
            myButton.Height += 5;
            myButton.Width += 5;
        }

        private void myButton_MouseLeave(object sender, MouseEventArgs e)
        {
            myButton.Height -= 5;
            myButton.Width -= 5;
        }
    }
}
