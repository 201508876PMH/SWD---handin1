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
    public class MainMenuViewModel : ViewModelCore
    {
        private INavigationService _iNavigationService;
        private ICommand _iCommandChangeWindowToAccountSettings;

        public MainMenuViewModel()
        {
            _iNavigationService = new NavigationService();
        }

        public MainMenuViewModel(INavigationService InavigationService)
        {
            _iNavigationService = InavigationService;

        }

        public ICommand changeWindowToAccountSettingsCommand => _iCommandChangeWindowToAccountSettings ?? (_iCommandChangeWindowToAccountSettings = new RelayCommand(changeWindowToAccountSettingsCommandExe));

        public void changeWindowToAccountSettingsCommandExe()
        {
            _iNavigationService.ShowView(new AddMemberView());
        }
    }
}
