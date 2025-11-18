using PansoyWpf.ViewModels;
using System.Windows;

namespace PansoyWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
