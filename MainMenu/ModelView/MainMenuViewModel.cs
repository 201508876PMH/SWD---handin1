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

        public MainMenuViewModel(INavigationService InavigationService)
        {
            _iNavigationService = InavigationService;

        }

        public ICommand changeWindowToAccountSettingsCommand
        {
            get { return _iCommandChangeWindowToAccountSettings ?? (_iCommandChangeWindowToAccountSettings = new RelayCommand(changeWindowToAccountSettingsCommandExe)); }
        }

        public void changeWindowToAccountSettingsCommandExe()
        {
            _iNavigationService.showView(new AddMemberView());
        }
    }
}
