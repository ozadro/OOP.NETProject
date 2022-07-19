using System;
using System.Collections.Generic;
using System.Windows;
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
        public string gender;

        public StartingElevenWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                FillWithData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void FillWithData()
        {
            if (gender == "Muški")
            {
                FillWithMaleHomeTeam();
                FillWithMaleAwayTeam();
            }
            else if (gender == "Ženski")
            {
                FillWithFemaleHomeTeam();
                FillWithFemaleAwayTeam();
            }
        }
        public async void FillWithMaleHomeTeam()
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
                        code = code
                    };
                    pnlHomeAttack.Children.Add(player);
                }

            }

        }
        public async void FillWithMaleAwayTeam()
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
                        code = code
                    };
                    pnlAwayAttack.Children.Add(player);
                }

            }



        }

        public async void FillWithFemaleHomeTeam()
        {
            Player player;
            PlayersManager playersManager = new PlayersManager();
            var data = await playersManager.GetFemalePlayers(code);
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
                        code = code
                    };
                    pnlHomeAttack.Children.Add(player);
                }

            }

        }

        public async void FillWithFemaleAwayTeam()
        {
            Player player;
            PlayersManager playersManager = new PlayersManager();
            var data = await playersManager.GetFemalePlayers(awayCode);
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
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
                        gender = gender,
                        code = code
                    };
                    pnlAwayAttack.Children.Add(player);
                }

            }



        }
    }
}
