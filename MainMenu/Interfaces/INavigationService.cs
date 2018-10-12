using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MainMenu.Interfaces
{
    interface INavigationService
    {
        // The 'showView' method take a UserControl object type argument, reason our views implement UserControl
        void showView(UserControl view);
    }
}
