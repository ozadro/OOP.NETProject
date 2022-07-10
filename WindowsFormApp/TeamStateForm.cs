using System;
using System.Windows.Forms;
using System.Threading;
using Utility.Dal;
using System.Globalization;
using System.ComponentModel;
using GLForma;
using Utility.Manager;
using Utility.Model;
using System.Collections.Generic;
using Utility.Constants;

namespace WindowsFormApp
{
    public partial class TeamStateForm : Form
    {
        public string gender;
        public string option;
        public string language;

        public TeamStateForm()
        {
           
            InitializeComponent();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            

            try
            {
                
                FillDdlWithData();
                SetKultura(language);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

       


        private  void FillDdlWithData()
        {
            

            if (gender == "Muški" || gender == "Male") 
            {
                if (option == "Api")
                {
                    LoadApiMaleStates();
                }
                else if (option == "Json")
                {
                    LoadJsonMaleStates();
                }
                
               
            }
           else if (gender == "Ženski" || gender == "Female")
            {
                if (option == "Api")
                {
                    LoadApiFemaleStates();
                }
                else if (option == "Json")
                {
                    LoadJsonFemaleStates();
                }


            }


          
           
        }

        public  void  LoadJsonMaleStates()
        {
            JsonData states = new JsonData();
            var statesData = states.GetAllOffMaleStates();

           


            // puni drop down list

             ddlStates.DataSource = statesData;


            StatesManager statesManager = new StatesManager();
            var data = statesManager.LoadStates(gender);
            int index = ddlStates.FindString(data);
            if (statesManager.FileExists(gender))
            {

                ddlStates.SelectedIndex = index;

            }
            else
            {
                ddlStates.SelectedIndex = 0;
            }



        }

        public async void LoadApiMaleStates()
        {

            ApiData states = new ApiData();
            var statesData = await states.GetAllMaleStates();


            // puni drop down list
            ddlStates.DataSource = statesData;

            StatesManager statesManager = new StatesManager();
            var data = statesManager.LoadStates(gender);
            int index = ddlStates.FindString(data);
            if (statesManager.FileExists(gender))
            {
               
                ddlStates.SelectedIndex = index;

            }
            else
            {
                ddlStates.SelectedIndex = 0;
            }

        }

        public  void LoadJsonFemaleStates()
        {
            JsonData states = new JsonData();
            var statesData =  states.GetAllFemaleOffStates();


            // puni drop down list
            ddlStates.DataSource = statesData;
            StatesManager statesManager = new StatesManager();
            var data = statesManager.LoadStates(gender);
            int index = ddlStates.FindString(data);
            if (statesManager.FileExists(gender))
            {
                
                ddlStates.SelectedIndex = index;

            }
            else
            {
                ddlStates.SelectedIndex = 0;
            }

        }

        public async void LoadApiFemaleStates()
        {

            ApiData states = new ApiData();
            var statesData = await states.GetAllFemaleStates();


            // puni drop down list
            ddlStates.DataSource = statesData;
            StatesManager statesManager = new StatesManager();
            var data = statesManager.LoadStates(gender);
            int index = ddlStates.FindString(data);
            if (statesManager.FileExists(gender))
            {
                
                ddlStates.SelectedIndex = index;

            }
            else
            {
                ddlStates.SelectedIndex = 0;
            }

        }

        private void SetKultura(string jezik)
        {
            var kultura = new CultureInfo(jezik);

            Thread.CurrentThread.CurrentUICulture = kultura;
            Thread.CurrentThread.CurrentCulture = kultura;
            AzurirajUIInitializeComponent(kultura);



        }
        private void AzurirajUIInitializeComponent(CultureInfo kultura)
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
     

                TeamMatchesForm newForm = new TeamMatchesForm();
                newForm.code = ddlStates.SelectedItem.ToString();
                newForm.option = option;
                newForm.gender = gender;
                newForm.language = language;
                newForm.ShowDialog();

            
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            StatesManager statesManager = new StatesManager();
            statesManager.SaveStates(ddlStates.SelectedItem.ToString(),gender);
        }

        private void ddlStates_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
