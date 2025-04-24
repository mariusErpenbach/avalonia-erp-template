using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Percuro.ViewModels.EnterpriseViewModels.Finance;
using Percuro.Views.EnterpriseViews;

namespace Percuro.ViewModels.EnterpriseViewModels
{
    public partial class FinanceViewModel : ViewModelBase
    {
        [RelayCommand]
        public void ToBilanzView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new BilanzViewModel();
            }
        }

        [RelayCommand]
        public void ToBuchhaltungView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new BuchhaltungViewModel();
            }
        }

        [RelayCommand]
        public void ToBudgetPlanningView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new BudgetPlanningViewModel();
            }
        }

        [RelayCommand]
        public void ToRechnungenView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new RechnungenViewModel();
            }
        }
    }
}