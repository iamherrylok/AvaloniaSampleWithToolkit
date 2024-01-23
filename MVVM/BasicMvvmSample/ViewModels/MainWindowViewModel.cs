using CommunityToolkit.Mvvm.ComponentModel;

namespace BasicMvvmSample.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(Greeting))]
    private string? _name;

    public string? Greeting 
        =>
        string.IsNullOrEmpty(Name) 
            ? "Hello World from Avalonia.Samples" 
            : $"Hello {Name}";
}