using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainMenu
{
    /// <summary>
    /// Interaction logic for AccountSettingsView.xaml
    /// </summary>
    public partial class AccountSettingsViewModel : UserControl
    {
        public AccountSettingsViewModel()
        {
            InitializeComponent();
        }

        //DER MAGLER CHECKS FOR OM USERNAME OG PASSWORD ER DET SAMME SOM DER ALLEREDE STÅR I DB. DERUDOVER MANGLER VI OGSÅ EN 
        //FUNCTION DER SLØRRE SAVE BTN INDTIL DER ER INDTASTET NYT DATA I ENTEN USERNAME CHANGE ELLER PASSWORD CHANGE

        

        private void DeleteBtn_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (DeleteBtn.Focus())
            {
                DeleteBtn.Background = Brushes.Red;
            }
        }
    }
}
