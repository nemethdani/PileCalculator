using System;

using PileCalculator.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PileCalculator.Views
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
