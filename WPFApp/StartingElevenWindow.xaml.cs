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
using System.Windows.Shapes;
using Utility.Manager;
using Utility.Model;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for StartingElevenWindow.xaml
    /// </summary>
    public partial class StartingElevenWindow : Window
    {

        public string code;
        public string awayCode;

        public StartingElevenWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                FillWithHomeTeam();
                FillWithAwayTeam();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public async void FillWithHomeTeam()
        {
            Player player;
            PlayersManager playersManager = new PlayersManager();
            var data = await playersManager.GetMalePlayers(code);
            IList<StartingEleven> se = new List<StartingEleven>();
            foreach (var item in data)
            {
                se.Add(item);
            }

            foreach (var item in se)
            {
                if (item.Position == "Goalie")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                       
                    };
                    pnlHomeGoalie.Children.Add(player);
                }
                else if (item.Position == "Defender")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                    };
                    pnlHomeDefense.Children.Add(player);
                }
                else if (item.Position == "Midfield")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                    };
                    pnlHomeMiddle.Children.Add(player);
                }
                else if (item.Position == "Forward")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                    };
                    pnlHomeAttack.Children.Add(player);
                }

            }

        }
        public async void FillWithAwayTeam()
        {
            Player player;
            PlayersManager playersManager = new PlayersManager();
            var data = await playersManager.GetMalePlayers(awayCode);
            IList<StartingEleven> se = new List<StartingEleven>();
            foreach (var item in data)
            {
                se.Add(item);
            }

            foreach (var item in se)
            {
                if (item.Position == "Goalie")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                    };
                    pnlAwayGoalie.Children.Add(player);
                }
                else if (item.Position == "Defender")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                    };
                    pnlAwayDefense.Children.Add(player);
                }
                else if (item.Position == "Midfield")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                    };
                    pnlAwayMiddle.Children.Add(player);
                }
                else if (item.Position == "Forward")
                {
                    player = new Player
                    {
                        name = item.Name,
                        number = item.ShirtNumber,
                        position = item.Position,
                        captain = item.Captain,
                        awayCode = awayCode,
                        code = code
                    };
                    pnlAwayAttack.Children.Add(player);
                }

            }



        }
    }
}
