// ViewModels/WelcomeViewModel.cs
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using Percuro.Services;

namespace Percuro.ViewModels;

public partial class WelcomeViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _welcomeMessage = "Herzlich willkommen";
     [ObservableProperty]
    private string _appName = "Percuro - ERP/CMS System";
    public DatabaseService? DatabaseService { get; set; }
    [RelayCommand]
    private void toLogin()
    {
        if (Parent is MainWindowViewModel mainVm && DatabaseService != null)
        {
            mainVm.CurrentViewModel = new LoginViewModel(DatabaseService);
        }
    }
   
}