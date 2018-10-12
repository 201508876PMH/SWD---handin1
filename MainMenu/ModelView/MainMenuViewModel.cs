using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MainMenu.classes;
using MainMenu.Interfaces;
using MainMenu.View;

namespace MainMenu.ModelView
{
    class MainMenuViewModel : ViewModelCore
    {
        private INavigationService _iNavigationService;
        private ICommand _iCommandChangeWindowToAccountSettings;
        private ICommand _iCommandChangeWindowToAddMember;

        public MainMenuViewModel(INavigationService InavigationService)
        {
            _iNavigationService = InavigationService;

        }

        // Account Settings window
        public ICommand changeWindowToAccountSettingsCommand
        {
            get { return _iCommandChangeWindowToAccountSettings ?? (_iCommandChangeWindowToAccountSettings = new RelayCommand(changeWindowToAccountSettingsCommandExe)); }
        }
        public void changeWindowToAccountSettingsCommandExe()
        {
            _iNavigationService.showView(new AccountSettingsView());
        }
        // Account Settings window


        // Add members window
        public ICommand changeWindowToAddMember
        {
            get { return _iCommandChangeWindowToAddMember ?? (_iCommandChangeWindowToAddMember = new RelayCommand(changeWindowToAddmemberExe)); }
        }
        public void changeWindowToAddmemberExe()
        {
            _iNavigationService.showView(new AddMemberView());
        }
        // Add members window

    }
}
