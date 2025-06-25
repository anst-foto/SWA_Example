using System.Collections.ObjectModel;
using ReactiveUI;

namespace SWA_Example.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<PageViewModelBase> Pages { get; } = 
    [
        new MainPageViewModel(),
        new InfoItemPageViewModel()
    ];
    
    private PageViewModelBase _selectedPage;
    public PageViewModelBase SelectedPage
    {
        get => _selectedPage;
        set => this.RaiseAndSetIfChanged(ref _selectedPage, value);
    }

    public MainWindowViewModel()
    {
        SelectedPage = Pages[0];
    }
}