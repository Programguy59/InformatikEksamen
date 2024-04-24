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

namespace InformatikEksamen
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
public partial class HomePage : UserControl
{
    private readonly MainWindow mainWindow;
    public HomePage(MainWindow main)
    {
        InitializeComponent();
        mainWindow = (MainWindow)Application.Current.MainWindow;
    }

        private void OpretEvenetButton_Click(object sender, RoutedEventArgs e)
        {
          mainWindow.ShowOpretEvent();
        }

        private void TilslutButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LånUdstyrButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

