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
    /// Interaction logic for TeamResultWindow.xaml
    /// </summary>
    public partial class TeamResultWindow : Window
    {
        public string code;
        public string gender;
        public TeamResultWindow()
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
                LoadMaleTeamResult();
            }
            else if (gender == "Ženski")
            {
                LoadFemaleTeamResult();
            }
        }



        public async void LoadMaleTeamResult()
        {
            PlayersManager playersManager = new PlayersManager();
            IList<OrderedTeam> orderedTeams = new List<OrderedTeam>();
            var data = await playersManager.GetSpecificMaleTeamResults(code);
            data.ToList().ForEach(t => orderedTeams.Add(t));

            foreach (var item in orderedTeams)
            {
                lbNameFifaCode.Content = item.Country.ToString() + ", " + item.FifaCode.ToString();
                lbWonGames.Content = Properties.Resources.won + item.Wins.ToString();
                lbPlayedGames.Content = Properties.Resources.played  + item.GamesPlayed.ToString();
                lbLostGames.Content = Properties.Resources.lost + item.Losses.ToString();
                lbUndecidedGames.Content = Properties.Resources.undecided + item.Draws.ToString();
                lbScoredGoals.Content = Properties.Resources.scored+ item.GoalsFor.ToString();
                lbTakenGoals.Content = Properties.Resources.taken + item.GoalsAgainst.ToString();
                lbDiffGoals.Content = Properties.Resources.difference + item.GoalDifferential.ToString();

            }

        }

        public async void LoadFemaleTeamResult()
        {
            PlayersManager playersManager = new PlayersManager();
            IList<OrderedTeam> orderedTeams = new List<OrderedTeam>();
            var data = await playersManager.GetSpecificFemaleTeamResults(code);
            data.ToList().ForEach(t => orderedTeams.Add(t));

            foreach (var item in orderedTeams)
            {
                lbNameFifaCode.Content = item.Country.ToString() + ", " + item.FifaCode.ToString();
                lbWonGames.Content = Properties.Resources.won + item.Wins.ToString();
                lbPlayedGames.Content = Properties.Resources.played + item.GamesPlayed.ToString();
                lbLostGames.Content = Properties.Resources.lost + item.Losses.ToString();
                lbUndecidedGames.Content = Properties.Resources.undecided + item.Draws.ToString();
                lbScoredGoals.Content = Properties.Resources.scored + item.GoalsFor.ToString();
                lbTakenGoals.Content = Properties.Resources.taken + item.GoalsAgainst.ToString();
                lbDiffGoals.Content = Properties.Resources.difference + item.GoalDifferential.ToString();

            }

        }
    }
}
