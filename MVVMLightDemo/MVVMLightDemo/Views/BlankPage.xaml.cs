using System;

using MVVMLightDemo.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MVVMLightDemo.Views
{
    public sealed partial class BlankPage : Page
    {
        private BlankViewModel ViewModel
        {
            get { return DataContext as BlankViewModel; }
        }

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
