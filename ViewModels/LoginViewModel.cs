using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Threading.Tasks;
using Percuro.Services;
using BCrypt.Net;
using Percuro.Views;

namespace Percuro.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    // Stores the username entered by the user
    [ObservableProperty]
    private string _username = "";

    // Stores the password entered by the user
    [ObservableProperty]
    private string _password = "";

    // Stores the currently selected role
    [ObservableProperty]
    private string _selectedRole = "Role A";

    // List of available roles for selection
    [ObservableProperty]
    private List<string> _availableRoles = new() { "Role A", "Role B" };

    // Reference to the database service for user authentication and account creation
    private readonly DatabaseService _databaseService;

    // Constructor initializes the database service and clears the password field
    public LoginViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService ?? throw new ArgumentNullException(nameof(databaseService));
        Password = ""; // Clear password field
    }

    // Stores error messages to display to the user
    [ObservableProperty]
    private string _errorMessage = "";

    // Handles the login process
    [RelayCommand]
    private async Task Login()
    {
        try
        {
            ErrorMessage = ""; // Reset error message

            // Validate that username and password are not empty
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Please enter a username and password.";
                return;
            }

            // Fetch user details from the database
            var user = await _databaseService.GetUserByUsernameAsync(Username);

            // Check if the user exists
            if (user is null)
            {
                ErrorMessage = "Username not found.";
                return;
            }

            // Verify the entered password against the stored hash
            if (BCrypt.Net.BCrypt.Verify(Password, user.PasswordHash))
            {
                Console.WriteLine("Login successful!");
                var session = UserSession.Current;
                session.Username = Username;
                session.Role = SelectedRole;

                // Clear the password from memory
                Password = "";

                // Navigate to the dashboard view
                await Avalonia.Threading.Dispatcher.UIThread.InvokeAsync(() =>
                {
                    (Parent as MainWindowViewModel)!.CurrentViewModel = new DashboardViewModel();
                });
            }
            else
            {
                ErrorMessage = "The entered password is incorrect.";
                Password = ""; // Clear the password from memory
            }
        }
        catch (Exception ex)
        {
            // Log the error for developers and show a generic error message to the user
            Console.WriteLine($"Login error: {ex.Message}");
            ErrorMessage = "An unexpected error occurred. Please try again later.";
        }
        finally
        {
            // Ensure the password is cleared from memory
            Password = "";
        }
    }

    // Handles the account creation process
    [RelayCommand]
    private async Task CreateAccount()
    {
        // Validate that username and password are not empty
        if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
        {
            ErrorMessage = "Username and password cannot be empty.";
            return;
        }

        // Attempt to create a new account in the database
        bool success = await _databaseService.CreateAccountAsync(Username, Password, SelectedRole);

        if (success)
        {
            Console.WriteLine($"Account for {Username} created successfully!");
            ErrorMessage = "Account created successfully!";
        }
        else
        {
            Console.WriteLine("Error creating account!");
            ErrorMessage = "Error creating account.";
        }

        // Clear the password from memory
        Password = "";
    }
}