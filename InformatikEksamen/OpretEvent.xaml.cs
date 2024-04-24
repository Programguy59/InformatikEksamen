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
    /// Interaction logic for OpretEvent.xaml
    /// </summary>
    public partial class OpretEvent : UserControl
    {
        private readonly MainWindow mainWindow;
        public OpretEvent(MainWindow main)
        {
            InitializeComponent();
            mainWindow = (MainWindow)Application.Current.MainWindow;
        }
    }
}
