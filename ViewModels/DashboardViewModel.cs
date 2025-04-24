using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Avalonia.Threading;

namespace Percuro.ViewModels;
public partial class DashboardViewModel : ViewModelBase
{
    public string WelcomeMessage => $"Willkommen, {UserSession.Current.Username}, {UserSession.Current.Role}!";

    public DashboardViewModel()
    {
        NavigateToEnterpriseViewCommand = new RelayCommand(NavigateToEnterpriseView);
    }

    public IRelayCommand NavigateToEnterpriseViewCommand { get; }

    private void NavigateToEnterpriseView()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            (Parent as MainWindowViewModel)!.CurrentViewModel = new EnterpriseViewModel();
        });
    }
}