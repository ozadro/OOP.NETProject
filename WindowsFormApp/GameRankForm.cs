using System;
using System.Windows.Forms;
using Utility.Manager;

namespace GLForma
{
    public partial class GameRankForm : Form
    {
        public string code;
        public string gender;


        public GameRankForm()
        {
            InitializeComponent();
        }

        private void GameRankForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillFormWithData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public  void FillFormWithData()
        {


          LoadApiData();
            

            
        }


        private async void LoadApiData()
        {
            PlayersManager playersRecievedData = new PlayersManager();

          

            if (gender == "Muški")
            {
                var homeTeam = await playersRecievedData.GetMaleHomeTeam(code);
                var awayTeam = await playersRecievedData.GetMaleAwayTeam(code);
                var attendance = await playersRecievedData.GetGameDataForTeam(code);
                lbHomeTeam.Text = homeTeam[0].Country;
                lbAwayTeam.Text = awayTeam[0].Country;
                lbAttendance.Text = attendance[0].Attendance.ToString();
                lbLocation.Text = attendance[0].Location;

            }
            else
            {
               
            }

        }
    }
}
