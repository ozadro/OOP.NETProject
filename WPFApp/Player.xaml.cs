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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : UserControl
    {
        public string name;
        public long number;
        public string code;
        public string awayCode;
        public string position;
        public bool captain;
        public string gender;
        


        public Player()
        {
            InitializeComponent();
        }

        private void Player_Loaded(object sender, RoutedEventArgs e)
        {
            lbName.Content = name.ToString();
            lbNumber.Content = number.ToString();
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlayerInfoWindow newWindow = new PlayerInfoWindow()
            {
                code = code,
                awayCode = awayCode,
                name = name,
                position = position,
                captain = captain,
                gender = gender,
                number = number

            };
            
            newWindow.Show();
        }
    }
}
