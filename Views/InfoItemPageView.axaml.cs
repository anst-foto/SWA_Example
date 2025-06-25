using Avalonia.Controls;
using SWA_Example.ViewModels;

namespace SWA_Example.Views;

public partial class InfoItemPageView : UserControl
{
    public InfoItemPageView()
    {
        InitializeComponent();
        
        DataContext = new InfoItemPageViewModel();
    }
}