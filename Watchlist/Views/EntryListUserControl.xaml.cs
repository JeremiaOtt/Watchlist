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
using Watchlist.Enum;
using Watchlist.ViewModels;

namespace Watchlist.Views
{
    /// <summary>
    /// Interaction logic for EntryListUserControl.xaml
    /// </summary>
    public partial class EntryListUserControl : UserControl
    {
        public ICommand UpdateViewCommand
        {
            get { return (ICommand)GetValue(UpdateViewCommandProperty); }
            set { SetValue(UpdateViewCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TestCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UpdateViewCommandProperty =
            DependencyProperty.Register("UpdateViewCommand", typeof(ICommand), typeof(EntryListUserControl), new PropertyMetadata(null));

        public EntryListUserControl()
        {
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (UpdateViewCommand != null)
            {
                UpdateViewCommand.Execute(UpdateView.EntryList_EditEntry);
            }
        }
    }
}
