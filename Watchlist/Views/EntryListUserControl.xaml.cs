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
    /// Interaction logic for EntryListUserControl.xaml
    /// </summary>
    public partial class EntryListUserControl : UserControl
    {
        //private EntryListViewModel _viewModel;

        public EntryListUserControl()   //EntryListViewModel viewModel)
        {
            InitializeComponent();

            //_viewModel = viewModel;
            //DataContext = viewModel;

            //DataContextChanged += GetDataContext;
        }

        // This seems more like a hack
        //private void GetDataContext(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    if (_viewModel != null) { return; } // ToDo:- Log if true

        //    if (DataContext is EntryListViewModel viewModel)
        //    {
        //        _viewModel = viewModel;
        //    }
        //}

        // Not needed any more
        //private void Add_Entry_Click(object sender, RoutedEventArgs e)
        //{
        //    _viewModel.AddEntry();
        //}
    }
}
