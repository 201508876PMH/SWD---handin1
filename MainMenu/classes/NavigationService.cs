using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MainMenu.Interfaces;
using NewsStyleUriParser = System.NewsStyleUriParser;

namespace MainMenu.classes
{
    class NavigationService : INavigationService
    {
        public void showView(UserControl view)
        {
            System.Windows.Application.Current.MainWindow.DataContext = view;
           
        }
    }
}
