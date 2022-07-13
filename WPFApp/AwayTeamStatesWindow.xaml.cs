using System;
using System.Windows;
using Utility.Manager;

namespace WPFApp
{

    public partial class AwayTeamStatesWindow : Window
    {
        public string code;
        public string language;
        public string gender;
      
        public AwayTeamStatesWindow()
        {
            InitializeComponent();
        }

        private void AwayTeamStatesWindow_Loaded(object sender, RoutedEventArgs e)
        {
      
            
            try
            {
                FillDdlWithData();

    }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }


        public void FillDdlWithData()
        {
            if (gender == "Muški")
            {
                LoadMaleAwayTeams();
            }
            else if (gender == "Ženski")
            {
                LoadFemaleAwayTeams();
            }
        }


        public async void LoadMaleAwayTeams()
        {
            PlayersManager playersManager = new PlayersManager();

          var data = await playersManager.GetAllMatchesForMaleTeam(code);
         
            ddlStates.ItemsSource = data;

            ddlStates.SelectedIndex = 0;

        }

        public async void LoadFemaleAwayTeams()
        {
            PlayersManager playersManager = new PlayersManager();
            var data = await playersManager.GetAllMatchesForFemaleTeam(code);

            ddlStates.ItemsSource = data;

            ddlStates.SelectedIndex = 0;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.Left = (SystemParameters.WorkArea.Width - Width) / 2 + SystemParameters.WorkArea.Left;
            this.Top = (SystemParameters.WorkArea.Height - Height) / 2 + SystemParameters.WorkArea.Top;
        }

        private void BtnChoose_Click(object sender, RoutedEventArgs e)
        {
            MatchResultWindow newWindow = new MatchResultWindow
            {
                code = code,
                awayCode = ddlStates.SelectedItem.ToString(),
                gender = gender,
                Width = this.Width,
                Height = this.Height
            };

            StartingElevenWindow newStartingWindow = new StartingElevenWindow
            {
                gender = gender,
                code = code,
                awayCode = ddlStates.Text
            };

            newStartingWindow.Show();
            newWindow.Show();
            this.Close();

        }
    }
}
