using ReactiveUI.Fody.Helpers;

namespace SWA_Example.ViewModels;

public class InfoItemPageViewModel : PageViewModelBase
{
    [Reactive] public string? Item { get; set; }
    
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