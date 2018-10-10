using System;
using System.Windows;
using System.Windows.Controls;


namespace MainMenu.ModelView
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
        

    }
}
