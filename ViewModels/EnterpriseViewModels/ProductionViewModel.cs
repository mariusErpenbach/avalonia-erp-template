using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Percuro.ViewModels.EnterpriseViewModels.Production;

namespace Percuro.ViewModels.EnterpriseViewModels
{
    public partial class ProductionViewModel : ViewModelBase
    {
        [RelayCommand]
        public void ToInventoryView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new InventoryViewModel();
            }
        }

        [RelayCommand]
        public void ToEinkaufView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new EinkaufViewModel();
            }
        }

        [RelayCommand]
        public void ToProduktionsPlanungView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new ProduktionsPlanungViewModel();
            }
        }
    }
}