using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Watchlist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Manager manager;

        public MainWindow()
        {
            InitializeComponent();

            manager = new Manager(new XmlFile());
            DataContext = manager;
        }

        private void Add_Entry_Click(object sender, RoutedEventArgs e)
        {
            manager.AddEntry();
        }
    }
}
