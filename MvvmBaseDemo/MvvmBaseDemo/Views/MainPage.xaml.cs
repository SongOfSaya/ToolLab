using MvvmBaseDemo.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MvvmBaseDemo.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
        }
    }
}