using System;
using System.Collections.ObjectModel;
using ReactiveUI;

namespace SWA_Example.ViewModels;

public class MainPageViewModel : PageViewModelBase
{
    public ObservableCollection<string> Items { get; set; } = [];
    
    private string? _item;
    public string? Item
    {
        get => _item;
        set => this.RaiseAndSetIfChanged(ref _item, value);
    }
    
    public MainPageViewModel() : base()
    {
        Title = "Главная";
        
        Items.Add("Элемент 1");
        Items.Add("Элемент 2");
        Items.Add("Элемент 3");
        
        this.WhenAnyValue(vm => vm.Item)
            .Subscribe(item => App.Item = item);
    }
}