using ReactiveUI;

namespace SWA_Example.ViewModels;

public class InfoItemPageViewModel : PageViewModelBase
{
    private string? _item;
    public string? Item
    {
        get => _item; 
        set => this.RaiseAndSetIfChanged(ref _item, value);
    }
    
    public InfoItemPageViewModel() : base()
    {
        Title = "Информация об элементе";

        Item = App.Item;
    }

    public void Clear()
    {
        Item = null;
    }

    public void Save()
    {
        
    }
}