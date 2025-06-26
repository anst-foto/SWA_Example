using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using ReactiveUI.Fody.Helpers;

namespace SWA_Example.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<TogglePaneItemTemplate> Pages { get; } = 
    [
        new(new MainPageViewModel(), "HomeIcon"),
        new(new InfoItemPageViewModel(), "InfoIcon")
    ];
    
    [Reactive] public TogglePaneItemTemplate SelectedPage { get; set; }

    public MainWindowViewModel()
    {
        SelectedPage = Pages[0];
    }
}

public class TogglePaneItemTemplate(PageViewModelBase viewModel, string iconKey)
{
    public string Title => ViewModel.Title;
    public PageViewModelBase ViewModel { get; init; } = viewModel;
    public StreamGeometry Icon { get; init; } = (StreamGeometry)Application.Current!.FindResource(iconKey)!;
}