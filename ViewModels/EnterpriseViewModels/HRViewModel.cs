using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Avalonia.Controls;
using System;
using Percuro.ViewModels.EnterpriseViewModels.HR;

namespace Percuro.ViewModels.EnterpriseViewModels
{
    public partial class HRViewModel : ViewModelBase
    {
        [RelayCommand]
        public void ToArbeitszeitView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new ArbeitszeitViewModel();
            }
        }

        [RelayCommand]
        public void ToGehaltsabrechnungView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new GehaltsabrechnungViewModel();
            }
        }

        [RelayCommand]
        public void ToMitarbeiterView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new MitarbeiterViewModel();
            }
        }

        [RelayCommand]
        public void ToRecruitingView()
        {
            if (Parent is MainWindowViewModel mainVm)
            {
                mainVm.CurrentViewModel = new RecruitingViewModel();
            }
        }
    }
}