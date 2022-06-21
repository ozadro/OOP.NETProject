using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utility.Manager;
using Utility.Model;

namespace GLForma
{
    public partial class PlayerRankForm : Form
    {
        public string code;
        public string gender;
        public IList<StartingEleven> formPlayers;

        public PlayerRankForm()
        {
            InitializeComponent();
        }

        private void PlayerRankForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                LoadApiData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private async void LoadApiData()
        {
            PlayersManager eventRecievedData = new PlayersManager();

            PlayerRank plr = new PlayerRank();

            if (gender == "Muški")
            {
                var maleEventData = await eventRecievedData.GetMaleTeamEvent(code);
                var maleEvent = EventControlsList(maleEventData);
                foreach (var item in maleEvent)
                {
                    flpRankPlayers.Controls.Add(item);
                }
            }
            else if (gender == "Ženski")
            {
                var femaleEventData = await eventRecievedData.GetFemaleEvent(code);
                var femaleEvenet = EventControlsList(femaleEventData);
                foreach (var item in femaleEvenet)
                {
                    flpRankPlayers.Controls.Add(item);
                }
            }
           
        }


        IList<PlayerRank> EventControlsList(IList<TeamEvent> data)
        {


           

            IList<PlayerRank> players = new List<PlayerRank>();


            foreach (var item in formPlayers)
            {
                bool exists = true;

                PlayerRank plr = new PlayerRank();
                for (int i = 0; i < data.Count; i++)
                {
                    
                    if (item.Name == data[i].Player)
                    {
                        exists = false;
                        plr.name = data[i].Player;
                        if (data[i].TypeOfEvent == "goal")
                        {
                            plr.goals = data[i].TypeOfEvent;
                            plr.countGoals++;
                            
                        }
                        if (data[i].TypeOfEvent == "yellow-card")
                        {
                            plr.cards = data[i].TypeOfEvent;
                            plr.countCards++;
                        }

                       
                    }
                    if (exists)
                    {
                        plr.name = item.Name;
                    }

                   
                    
                }

                players.Add(plr);

            }

            

            


            return players;
        }

    }
}
