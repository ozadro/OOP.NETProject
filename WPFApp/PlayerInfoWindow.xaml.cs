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
    /// Interaction logic for PlayerInfoWindow.xaml
    /// </summary>
    public partial class PlayerInfoWindow : Window
    {
        public string code;
        public string awayCode;
        public string position;
        public bool captain;
        public string name;
        public long number;
        private string goals;
        private string cards;
        private int countGoals;
        private int countCards;
        public string gender;


        public PlayerInfoWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


           
            try
            {
                if (captain)
                {
                    lbCaptain.Content = "C";
                }
                else
                {
                    lbCaptain.Content = " ";
                }
                lbName.Content = name;
                lbNumber.Content = number.ToString();
                lbPosition.Content = position;
                goals = Properties.Resources.goals;
                cards = Properties.Resources.yellowcards;
                lbGoals.Content = goals;
                lbCards.Content = cards;
                if (gender == "Muški")
                {
                    LoadWithMaleEvents();
                }
                else if (gender == "Ženski")
                {
                    LoadWitFemaleEvents();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        public async void LoadWithMaleEvents()
        {
            PlayersManager playersManager = new PlayersManager();
            IList<TeamEvent> allEvents = new List<TeamEvent>();
            var data = await playersManager.GetMaleGameTeamEvent(code, awayCode);
            foreach (var item in data)
            {
                allEvents.Add(item);
            }



            for (int i = 0; i < allEvents.Count; i++)
            {
                
                if (name == data[i].Player)
                {

                    name = data[i].Player;
                    if (allEvents[i].TypeOfEvent == "goal")
                    {

                        countGoals++;

                    }
                    else if (allEvents[i].TypeOfEvent == "goal-own")
                    {
                        countGoals++;
                    }
                    else if (data[i].TypeOfEvent == "goal-penalty")
                    {
                        countGoals++;
                    }
                    if (allEvents[i].TypeOfEvent == "yellow-card")
                    {

                        countCards++;
                    }


                }

            }  
            lbCountCards.Content = countCards.ToString();
            lbCountGoals.Content = countGoals.ToString();

        }

        public async void LoadWitFemaleEvents()
        {
            PlayersManager playersManager = new PlayersManager();
            IList<TeamEvent> allEvents = new List<TeamEvent>();
            var data = await playersManager.GetFemaleGameTeamEvent(code, awayCode);
            foreach (var item in data)
            {
                allEvents.Add(item);
            }

            for (int i = 0; i < allEvents.Count; i++)
            {
                goals = Properties.Resources.goals;
                cards = Properties.Resources.yellowcards;
                if (name == data[i].Player)
                {

                    name = data[i].Player;
                    if (allEvents[i].TypeOfEvent == "goal")
                    {

                        countGoals++;

                    }
                    else if (allEvents[i].TypeOfEvent == "goal-own")
                    {
                        countGoals++;
                    }
                    else if (data[i].TypeOfEvent == "goal-penalty")
                    {
                        countGoals++;
                    }
                    if (allEvents[i].TypeOfEvent == "yellow-card")
                    {

                        countCards++;
                    }


                }

            }
            lbCountCards.Content = countCards.ToString();
            lbCountGoals.Content = countGoals.ToString();

        }
    }
}


