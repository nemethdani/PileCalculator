using System;

using PileCalculator.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PileCalculator.Views
{
    public sealed partial class TabbedPivotPage : Page
    {
        public TabbedPivotViewModel ViewModel { get; } = new TabbedPivotViewModel();

        public TabbedPivotPage()
        {
            InitializeComponent();
        }
    }
}
