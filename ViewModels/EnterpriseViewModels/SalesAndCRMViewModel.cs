using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.Controls;
using System;
using CommunityToolkit.Mvvm.Input;
using Percuro.ViewModels.EnterpriseViewModels.SalesAndCRM;

namespace Percuro.ViewModels.EnterpriseViewModels
{
    public partial class SalesAndCRMViewModel : ViewModelBase
    {
        [RelayCommand]
        public void ToCustomerManagementView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new CustomerManagementViewModel();
            }
        }

        [RelayCommand]
        public void ToSalesManagementView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new SalesManagementViewModel();
            }
        }
    }
}