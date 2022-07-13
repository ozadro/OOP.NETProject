using System;
using System.Windows;
using Utility.Manager;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MatchResultWindow.xaml
    /// </summary>
    public partial class MatchResultWindow : Window
    {
        public string code;
        public string awayCode;
        public string language;
        public string gender;
        public MatchResultWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            this.Left = (SystemParameters.WorkArea.Width - Width) / 2 + SystemParameters.WorkArea.Left;
            this.Top = (SystemParameters.WorkArea.Height - Height) / 2 + SystemParameters.WorkArea.Top;
            try
            {
                FillFormWithData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FillFormWithData()
        {
            if (gender == "Muški")
            {
                LoadMaleMatchResult();
            }
            else if (gender == "Ženski")
            {
                LoadFemaleMatchResult();
            }

        }

       public async void LoadMaleMatchResult()
        {
            PlayersManager playersManager = new PlayersManager();

            var data = await playersManager.SpecificMaleMatchData(code, awayCode);

            foreach (var item in data)
            {
                if (item.AwayTeam.Code == awayCode)
                {
                    lbawayTeam.Content = item.AwayTeamCountry;
                    lbawayTeamGoals.Content = item.AwayTeam.Goals;
                    lbhomeTeam.Content = item.HomeTeamCountry;
                    lbhomeTeamGoals.Content = item.HomeTeam.Goals;
                }
                else
                {
                    lbawayTeam.Content = item.HomeTeamCountry;
                    lbawayTeamGoals.Content = item.HomeTeam.Goals;
                    lbhomeTeam.Content = item.AwayTeamCountry;
                    lbhomeTeamGoals.Content = item.AwayTeam.Goals;
                }
                lbWinner.Text = Properties.Resources.winner + item.Winner.ToString();
            }
        }

        public async void LoadFemaleMatchResult()
        {
            PlayersManager playersManager = new PlayersManager();

            var data = await playersManager.SpecificFemaleMatchData(code, awayCode);

            foreach (var item in data)
            {
                if (item.AwayTeam.Code == awayCode)
                {
                    lbawayTeam.Content = item.AwayTeamCountry;
                    lbawayTeamGoals.Content = item.AwayTeam.Goals;
                    lbhomeTeam.Content = item.HomeTeamCountry;
                    lbhomeTeamGoals.Content = item.HomeTeam.Goals;
                }
                else
                {
                    lbawayTeam.Content = item.HomeTeamCountry;
                    lbawayTeamGoals.Content = item.HomeTeam.Goals;
                    lbhomeTeam.Content = item.AwayTeamCountry;
                    lbhomeTeamGoals.Content = item.AwayTeam.Goals;
                }
                lbWinner.Text = Properties.Resources.winner + item.Winner.ToString();
            }
        }
        private void BtnAwayTeam_Click(object sender, RoutedEventArgs e)
        {
            TeamResultWindow newWindow = new TeamResultWindow();
            newWindow.Height = this.Height;
            newWindow.Width = this.Width;
            newWindow.code = awayCode;
            newWindow.gender = gender;
            newWindow.Show();
        }

        private void BtnHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            TeamResultWindow newWindow = new TeamResultWindow();
            newWindow.Height = this.Height;
            newWindow.Width = this.Width;
            newWindow.code = code;
            newWindow.gender = gender;
            newWindow.Show();

        }
    }
}
