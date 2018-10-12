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
        public UserAccount _currentUserAccount;
        public AccountSettingsModel _accountSettingsModel;

        public AccountSettingsViewModel()
        {
            _currentUserAccount = new UserAccount();
            _accountSettingsModel = new AccountSettingsModel();

            _currentUserAccount.Username = "MrMaxCoolUsernameBoy2321";
            _currentUserAccount.Email = "ThisShouldNotWorkAsAnEmail";
            _currentUserAccount.Password = "ThisShouldBeConfidential123";
        }

        public AccountSettingsViewModel(UserAccount currentUserAccount, AccountSettingsModel accountSettingsModel)
        {
            _currentUserAccount = currentUserAccount;
            _accountSettingsModel = accountSettingsModel;
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

        ICommand _saveCommand;

        public ICommand SaveCommand => _saveCommand ?? (_saveCommand = new RelayCommand<object>(Save_OnClick));

        public void Save_OnClick(object parameter)
        {
            var values = (object[]) parameter;

            //_currentUserAccount.Email = values[1].ToString();
            //_currentUserAccount.Password = values[3].ToString();

            var new_username = values[0].ToString();
            var current_email = values[1].ToString();
            var repeated_email = values[2].ToString();
            var current_password = values[3].ToString();
            var new_password = values[4].ToString();
            var repeated__new_password = values[5].ToString();
            
            if (_accountSettingsModel.Check_if_username_is_the_same(_currentUserAccount.Username, new_username) ||
                _accountSettingsModel.Check_if_emails_are_identical(_currentUserAccount.Email, repeated_email))
            {
                _currentUserAccount.Username = new_username;
                RaisePropertyChanged("Username");
            }
            else
            {
                Console.WriteLine("Something didn't match");
            }
            
        }

    }
    
}
