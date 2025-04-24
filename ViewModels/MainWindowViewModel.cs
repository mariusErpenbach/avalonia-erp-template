using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Percuro.Services;

namespace Percuro.ViewModels;
public partial class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase? _currentViewModel;
    
    public ViewModelBase? CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel = value;
            
            // Automatisch Parent setzen bei jedem Wechsel
            if (_currentViewModel is ViewModelBase vm)
            {
                vm.Parent = this;
            }
            
            OnPropertyChanged();
        }
    }
     private readonly DatabaseService _databaseService;
    public MainWindowViewModel()
    {
          _databaseService = new DatabaseService();
        CurrentViewModel = new WelcomeViewModel { Parent = this, DatabaseService = _databaseService };
    }
}