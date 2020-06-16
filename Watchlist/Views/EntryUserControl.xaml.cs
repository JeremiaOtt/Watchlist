using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Watchlist.ViewModels;

namespace Watchlist.Views
{
    /// <summary>
    /// Interaction logic for EntryUserControl.xaml
    /// </summary>
    public partial class EntryUserControl : UserControl
    {
        //private EntryViewModel _viewModel;

        public EntryUserControl()   //EntryViewModel viewModel)
        {
            InitializeComponent();

            //_viewModel = viewModel;
            //DataContext = _viewModel;
        }
    }
}
