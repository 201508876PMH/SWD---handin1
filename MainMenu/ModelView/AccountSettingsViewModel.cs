using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MainMenu.classes;
using MainMenu.Model;
using MainMenu.ModelView;


namespace MainMenu.ModelView
{
    public class AccountSettingsViewModel : ViewModelCore
    {
        private UserAccount _currentUserAccount;
        private readonly AccountSettingsModel _accountSettingsModel;

        public AccountSettingsViewModel()
        {
            _currentUserAccount = new UserAccount();
            _accountSettingsModel = new AccountSettingsModel();

            _currentUserAccount.Username = "MrMaxCoolUsernameBoy2321";
            _currentUserAccount.Email = "ThisShouldNotWorkAsAnEmail";
            _currentUserAccount.Password = "ThisShouldBeConfidential123";
        }

        public UserAccount UserAccount
        {
            get => _currentUserAccount;
            set => _currentUserAccount = value;
        }

        public string Username
        {
            get => _currentUserAccount.Username;
            set
            {
                if (_currentUserAccount.Username == value) return;
                _currentUserAccount.Username = value;
                RaisePropertyChanged(_currentUserAccount.Username);
            }
        }

        public string Email
        {
            get => _currentUserAccount.Email;
            set
            {
                if(_currentUserAccount.Email == value) return;
                _currentUserAccount.Email = value;
                RaisePropertyChanged(_currentUserAccount.Email);
            }
        }

        public string Password
        {
            get => _currentUserAccount.Password;
            set
            {
                if (_currentUserAccount.Password == value) return;
                _currentUserAccount.Password = value;
                RaisePropertyChanged(_currentUserAccount.Password);
            }
        }

        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand
            }
        }

    }
    
}
