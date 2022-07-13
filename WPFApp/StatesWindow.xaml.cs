using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Utility.Dal;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for StatesWindow.xaml
    /// </summary>
    public partial class StatesWindow : Window
    {
        public string gender;
        public double height;
        public double width;
        public string language;
        
        public StatesWindow(string language)
        {
            SetKultura(language);
            InitializeComponent();
           
        }

        private void StatesWindow_Loaded(object sender, RoutedEventArgs e)
        {   
         

            try
            {

                
                FillDdlWithData();
               
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            ddlStates.SelectedIndex = 0;
        }


        private void FillDdlWithData()
        {


            if (gender == "Muški" || gender == "Male")
            {    
                    LoadApiMaleStates();
            }
            else if (gender == "Ženski" || gender == "Female")
            {        
                    LoadApiFemaleStates();
            }

        }
        public void LoadJsonMaleStates()
        {
            JsonData states = new JsonData();
            var statesData = states.GetAllOffMaleStates();


            // puni drop down list
            ddlStates.ItemsSource = statesData;

            ddlStates.SelectedIndex = 0;
        }

        public async void LoadApiMaleStates()
        {

            ApiData states = new ApiData();
            var statesData = await states.GetAllMaleStates();


            // puni drop down list
            ddlStates.ItemsSource = statesData;

            ddlStates.SelectedIndex = 0;
        }

        public void LoadJsonFemaleStates()
        {
            JsonData states = new JsonData();
            var statesData = states.GetAllFemaleOffStates();


            // puni drop down list
            ddlStates.ItemsSource = statesData;

            ddlStates.SelectedIndex = 0;
        }
        private void SetKultura(string kultura)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);

           
        }
      
        
        public async void LoadApiFemaleStates()
        {

            ApiData states = new ApiData();
            var statesData = await states.GetAllFemaleStates();


            // puni drop down list
            ddlStates.ItemsSource = statesData;

            ddlStates.SelectedIndex = 0;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.Left = (SystemParameters.WorkArea.Width - Width) / 2 + SystemParameters.WorkArea.Left;
            this.Top = (SystemParameters.WorkArea.Height - Height) / 2 + SystemParameters.WorkArea.Top;
        }

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            AwayTeamStatesWindow newWindow = new AwayTeamStatesWindow();
            newWindow.code = ddlStates.Text;
            newWindow.Height = this.Height;
            newWindow.Width = this.Width;
            newWindow.gender = gender;
            newWindow.ShowDialog();
            this.Close();

        }
    }
}
