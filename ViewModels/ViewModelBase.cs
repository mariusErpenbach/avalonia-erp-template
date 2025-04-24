using CommunityToolkit.Mvvm.ComponentModel;

namespace Percuro.ViewModels;

public abstract class ViewModelBase : ObservableObject
{
    public MainWindowViewModel? Parent { get; set; }
}