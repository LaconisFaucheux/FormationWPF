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
            myTextBlock.Foreground = Brushes.Red;
            myTextBlock.FontSize = 50;

            TextBlock myTB = new TextBlock();
            myTB.Text = "Hello World! ";
            myTB.Inlines.Add("New text with Inlines!");
            myTB.TextWrapping = TextWrapping.Wrap;
            myTB.Foreground = Brushes.Coral;

            //TextBlock[] contentArray = new TextBlock[] { myTextBlock, myTB };
            this.Content = myTB;



        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
