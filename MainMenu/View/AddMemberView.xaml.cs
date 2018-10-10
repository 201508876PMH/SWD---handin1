using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MainMenu.View
{
    /// <summary>
    /// Interaction logic for AddMemberView.xaml
    /// </summary>
    public partial class AddMemberView : UserControl
    {
        public AddMemberView()
        {
            InitializeComponent();

            List<string> items = new List<string>();
            items.Add("Anton Sakrias Rørbæk Sihm");
            items.Add("Peter Macus Hoveling");
            items.Add("Rasmus Christensen");
            
            PersonAddToGroupList.ItemsSource = items;
            
        }
        
    }
}
