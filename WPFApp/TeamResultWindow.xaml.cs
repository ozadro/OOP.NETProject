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
            LoadApiTeamResult();
        }



        public async void LoadApiTeamResult()
        {
            PlayersManager playersManager = new PlayersManager();
            IList<OrderedTeam> orderedTeams = new List<OrderedTeam>();
            var data = await playersManager.GetSpecificMaleTeamResoults(code);
            data.ToList().ForEach(t => orderedTeams.Add(t));

            foreach (var item in orderedTeams)
            {
                lbNameFifaCode.Content = item.Country.ToString() + ", " + item.FifaCode.ToString();
                lbWonGames.Content = "Pobjede: "+ item.Wins.ToString();
                lbPlayedGames.Content ="Odigrano: " +item.GamesPlayed.ToString();
                lbLostGames.Content ="Izgubljeno: " +item.Losses.ToString();
                lbUndecidedGames.Content ="Neodluceno: " +item.Draws.ToString();
                lbScoredGoals.Content = "Zabijeno: "+item.GoalsFor.ToString();
                lbTakenGoals.Content = "Primljeno: "+item.GoalsAgainst.ToString();
                lbDiffGoals.Content = "Razlika: "+item.GoalDifferential.ToString();

            }

        }
    }
}
