using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Avalonia.Threading;
using Percuro.ViewModels.EnterpriseViewModels;

namespace Percuro.ViewModels;
public partial class EnterpriseViewModel : ViewModelBase
{
    public EnterpriseViewModel()
    {
    
    }

    [RelayCommand]
    public void ToFinanceView()
    {
        if (Parent is MainWindowViewModel mainVm)
        {
            mainVm.CurrentViewModel = new FinanceViewModel();
        }
    }

    [RelayCommand]
    public void ToHRView()
    {
        if (Parent is MainWindowViewModel mainVm)
        {
            mainVm.CurrentViewModel = new HRViewModel();
        }
    }

    [RelayCommand]
    public void ToProductionView()
    {
        if (Parent is MainWindowViewModel mainVm)
        {
            mainVm.CurrentViewModel = new ProductionViewModel();
        }
    }

    [RelayCommand]
    public void ToSalesAndCRMView()
    {
        if (Parent is MainWindowViewModel mainVm)
        {
            mainVm.CurrentViewModel = new SalesAndCRMViewModel();
        }
    }

    [RelayCommand]
    public void ToAnalyticsView()
    {
        if (Parent is MainWindowViewModel mainVm)
        {
            mainVm.CurrentViewModel = new AnalyticsViewModel();
        }
    }
}