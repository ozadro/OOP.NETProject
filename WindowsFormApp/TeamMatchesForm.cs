using GLForma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utility.Manager;
using Utility.Model;

namespace WindowsFormApp
{
    public partial class TeamMatchesForm : Form
    {
        public string code;
        public string gender;
        public string option;
        public IList<StartingEleven> formPlayers;
        public TeamMatchesForm()
        {
            InitializeComponent();


        }

        private void TeamMatchesForm_Load(object sender, EventArgs e)
        {


            try
            {

                FillTestWithData();
                LoadFavPlayers();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private  void FillTestWithData()
        {
            PlayersManager playersRecievedData = new PlayersManager();

            Players plr = new Players();

                if (option == "Api")
                {
                  LoadApiData();
                }
                else
                {
                  LoadJsonData();
                }

        }


        private async void LoadApiData()
        {
            PlayersManager playersRecievedData = new PlayersManager();

            Players plr = new Players();

            if (gender == "Muški")
            {
                var maleplayerdata = await playersRecievedData.GetMalePlayers(code);
                var maleplayers = PlayersControlsList(maleplayerdata);
                formPlayers = new List<StartingEleven>(maleplayerdata);
                maleplayers.ToList().ForEach(p => flpPlayers.Controls.Add(p));
            }
            else
            {
                var femaleplayerdata = await playersRecievedData.GetFemalePlayers(code);
                var femaleplayers = PlayersControlsList(femaleplayerdata);
                formPlayers = new List<StartingEleven>(femaleplayerdata);
                femaleplayers.ToList().ForEach(p => flpPlayers.Controls.Add(p));
            }
       
        }

        private void LoadJsonData()
        {
            PlayersManager playersRecievedData = new PlayersManager();

            Players plr = new Players();
           

            if (gender == "Muški")
            {
                var maleplayerdata =  playersRecievedData.GetMaleOffPlayers(code);
                var maleplayers = PlayersControlsList(maleplayerdata);
                maleplayers.ToList().ForEach(p => flpPlayers.Controls.Add(p));
            }
            else
            {
                var femaleplayerdata =  playersRecievedData.GetFemaleOffPlayers(code);
                var femaleplayers = PlayersControlsList(femaleplayerdata);
                femaleplayers.ToList().ForEach(p => flpPlayers.Controls.Add(p));
            }
        }
    


        IList<Players> PlayersControlsList(IList<StartingEleven> data)
        {


              Players plr;
            
            IList<Players> players = new List<Players>();

            for (int i = 0; i < data.Count(); i++)
            {
                plr = new Players()
                {
                    name = data[i].Name,
                    captain = data[i].Captain,
                    shirtNumber = data[i].ShirtNumber,
                    position = data[i].Position,
                    testerbester = this
                };


                players.Add(plr);

                
            }


            return players;
        }
        
      

        private void LoadFavPlayers()
        {
            PlayersManager helper = new PlayersManager();
            var data = helper.LoadPlayers(code,gender);
            if (data == null)
            {
                return;
            }
            Players plr;

            for (int i = 0; i < data.Count(); i++)
            {
                plr = new Players()
                {
                    name = data[i].Name,
                    captain = data[i].Captain,
                    shirtNumber = data[i].ShirtNumber,
                    position = data[i].Position
                };


                flpFavorites.Controls.Add(plr);

            }

        }

        private void flpFavorites_DragEnter(object sender, DragEventArgs e)
        {
           
            e.Effect = DragDropEffects.Move;
            if (flpFavorites.Controls.Count == 3)
            {
                e.Effect = DragDropEffects.None;
            }

        }

        public void csMenu_Click(object sender, EventArgs e)
        {

            Players player = sender as Players;
            player.Click += player.itemAddFav_Click;
            


        }

        public void AddFavs(Players player)
        {
            
            flpFavorites.Controls.Add(player);

        }


        private void flpFavorites_DragDrop(object sender, DragEventArgs e)
        {

            Players player = new Players();
            flpFavorites = sender as FlowLayoutPanel;
            var data = (Players)e.Data.GetData(typeof(Players));
            

            if (flpFavorites.Controls.Count < 3)
            {

                flpFavorites.Controls.Add(data);
               
             
            }
            else
            {
                e.Effect = DragDropEffects.None;
                
            }



        }



        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {

            PlayersManager data = new PlayersManager();
            Control.ControlCollection control = flpFavorites.Controls;
            IList<Players> plr = new List<Players>();

            foreach (var item in control)
            {
                plr.Add((Players)item);
            }
            for (int i = 0; i < plr.Count(); i++)
            {
                flpPlayers.Controls.Add(plr[i]);
            }

            flpFavorites.Controls.Clear();
            data.DeleteFile(code, gender);
            

            
           
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            Control.ControlCollection control = flpFavorites.Controls;
            IList<Players> plr = new List<Players>();

            foreach (var item in control)
            {
                plr.Add((Players)item);
            }

            PlayersManager helper = new PlayersManager();

            IList<StartingEleven> playerList = new List<StartingEleven>();
            foreach (var item in plr)
            {
                playerList.Add(item.strelv);

            }


            helper.SavePlayer(playerList,code,gender);
           
        }

        private void btnRankPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            PlayerRankForm rankForm = new PlayerRankForm();
            rankForm.formPlayers = formPlayers;
            rankForm.code = code;
            rankForm.option = option;
            rankForm.gender = gender;
            rankForm.ShowDialog();
        }

        private void btnRankVisitor_MouseClick(object sender, MouseEventArgs e)
        {
            GameRankForm rankForm = new GameRankForm();
            rankForm.code = code;
            rankForm.gender = gender;
            rankForm.option = option;
            rankForm.ShowDialog();
        }
    }
}
