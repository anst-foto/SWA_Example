using Avalonia.Controls;
using SWA_Example.ViewModels;

namespace SWA_Example.Views;

public partial class MainPageView : UserControl
{
    public MainPageView()
    {
        InitializeComponent();
        
        DataContext = new MainPageViewModel();
    }
}