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
  
    public partial class AwayTeamStatesWindow : Window
    {
        public string code;
      
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
            LoadMaleAwayTeams();
        }


        public async void LoadMaleAwayTeams()
        {
            PlayersManager playersManager = new PlayersManager();

          var data = await playersManager.GetAllMatchesForMaleTeam(code);
         
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
                Width = this.Width,
                Height = this.Height
            };

            StartingElevenWindow newStartingWindow = new StartingElevenWindow
            {
                code = code,
                awayCode=ddlStates.SelectedItem.ToString(),
            };

            newStartingWindow.Show();
            newWindow.Show();
           

        }
    }
}
