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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MatchResultWindow.xaml
    /// </summary>
    public partial class MatchResultWindow : Window
    {
        public string code;
        public string awayCode;
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

        private async void FillFormWithData()
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
                lbWinner.Text  = "WINNER: " + item.Winner.ToString();
            }
            

            

        }

       

        private void BtnAwayTeam_Click(object sender, RoutedEventArgs e)
        {
            TeamResultWindow newWindow = new TeamResultWindow();
            newWindow.Height = this.Height;
            newWindow.Width = this.Width;
            newWindow.code = awayCode;
            newWindow.Show();
        }

        private void BtnHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            TeamResultWindow newWindow = new TeamResultWindow();
            newWindow.Height = this.Height;
            newWindow.Width = this.Width;
            newWindow.code = code;
            newWindow.Show();

        }
    }
}
