using RestSharp.Extensions;
using RestSharp;
using System;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Utility.Model;
using Utility.Constants;
using Utility.Dal;

namespace WindowsFormApp
{
    public partial class TeamStateForm : Form
    {
        public string gender;
        public string option;

        public TeamStateForm()
        {
           
            InitializeComponent();
           
        }
        private void MainForm_Load(object sender, EventArgs e)
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

       


        private  void FillDdlWithData()
        {
            

            if (gender == "Muški") 
            {
                if (option == "Api")
                {
                    LoadApiMaleStates();
                }
                else
                {
                    LoadJsonMaleStates();
                }
                
               
            }
           else if (gender == "Ženski")
            {
                if (option == "Api")
                {
                    LoadApiFemaleStates();
                }
                else
                {
                    LoadJsonFemaleStates();
                }


            }


          
           
        }

        public  void  LoadJsonMaleStates()
        {
            JsonData states = new JsonData();
            var statesData =  states.GetAllOffMaleStates();


            // puni drop down list
            ddlStates.DataSource = statesData;

            ddlStates.SelectedIndex = 0;
        }

        public async void LoadApiMaleStates()
        {

            ApiData states = new ApiData();
            var statesData = await states.GetAllMaleStates();


            // puni drop down list
            ddlStates.DataSource = statesData;

            ddlStates.SelectedIndex = 0;
        }

        public  void LoadJsonFemaleStates()
        {
            JsonData states = new JsonData();
            var statesData =  states.GetAllFemaleOffStates();


            // puni drop down list
            ddlStates.DataSource = statesData;

            ddlStates.SelectedIndex = 0;
        }

        public async void LoadApiFemaleStates()
        {

            ApiData states = new ApiData();
            var statesData = await states.GetAllFemaleStates();


            // puni drop down list
            ddlStates.DataSource = statesData;

            ddlStates.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            if (gender == "Muški")
            {

                TeamMatchesForm newForm = new TeamMatchesForm();
                newForm.code = ddlStates.SelectedItem.ToString();
                newForm.gender = "Muški";
                if (option == "Api")
                {
                    newForm.option = "Api";
                }
                else
                {
                    newForm.option = "Json";
                }
                newForm.ShowDialog();


            }
            else if (gender == "Ženski")
            {

                TeamMatchesForm newForm = new TeamMatchesForm();
                newForm.code = ddlStates.SelectedItem.ToString();
                if (option == "Api")
                {
                    newForm.option = "Api";
                }
                else
                {
                    newForm.option = "Json";
                }
                newForm.gender = "Ženski";
                newForm.ShowDialog();

            }


        }


        

    }
}
