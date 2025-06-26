using System;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace SWA_Example.ViewModels;

public class MainPageViewModel : PageViewModelBase
{
    public ObservableCollection<string> Items { get; set; } = [];
    
    [Reactive] public string? Item { get; set; }
    
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