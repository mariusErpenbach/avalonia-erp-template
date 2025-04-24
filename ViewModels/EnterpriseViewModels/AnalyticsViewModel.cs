using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Percuro.ViewModels.EnterpriseViewModels.Analytics;

namespace Percuro.ViewModels.EnterpriseViewModels
{
    public partial class AnalyticsViewModel : ViewModelBase
    {
        [RelayCommand]
        public void ToAnalysenView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new AnalysenViewModel();
            }
        }

        [RelayCommand]
        public void ToReportsView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new ReportsViewModel();
            }
        }

        [RelayCommand]
        public void ToStatistikenView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new StatistikenViewModel();
            }
        }
    }
}