using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Utility.Manager;

namespace WindowsFormApp
{
    
    public partial class MainForm : Form
    {
        public string language;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   


            SetKultura(language);
            SettingsManager settings = new SettingsManager();
            string gender = "Gender";
            string option = "Api";

            var dataGender = settings.Load(gender);
            int indexGender = ddlGenders.FindString(dataGender);

            var dataOption = settings.Load(option);
            int indexOption = cbOption.FindString(dataOption);

            if (settings.FileExists(gender))
            {
                if (language == "hr" && dataGender == "Male")
                {
                    ddlGenders.SelectedIndex = 0;
                }
               else if (language == "hr" && dataGender == "Female")
                {
                    ddlGenders.SelectedIndex = 1;
                }
                else if (language == "en" && dataGender == "Muški")
                {
                    ddlGenders.SelectedIndex = 0;
                }
                else if (language == "en" && dataGender == "Ženski")
                {
                    ddlGenders.SelectedIndex = 1;
                }
                else
                {
                    ddlGenders.SelectedIndex = indexGender;
                }
               

            }
            else
            {
                ddlGenders.SelectedIndex = 0;
            }

            if (settings.FileExists(option))
            {

                cbOption.SelectedIndex = indexOption;

            }
            else
            {
                cbOption.SelectedIndex = 0;
            }
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
                TeamStateForm newForm = new TeamStateForm();
                newForm.gender = ddlGenders.SelectedItem.ToString();
                newForm.option = cbOption.SelectedItem.ToString();
                newForm.language = language;
                newForm.ShowDialog();

        }

        private void SetKultura(string language)
        {

         
            var kultura = new CultureInfo(language);

            Thread.CurrentThread.CurrentUICulture = kultura;
            Thread.CurrentThread.CurrentCulture = kultura;

            AzurirajUIInitializeComponent(kultura);
            
        }

        private void AzurirajUIInitializeComponent(CultureInfo kultura)
        {
            this.Controls.Clear();
            InitializeComponent();
            cbOption.SelectedIndex = 0;
            ddlGenders.SelectedIndex = 0;
            
        }

       

        private void ddlLanguages_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetKultura(language);
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            SettingsManager settings = new SettingsManager();
                
            
            settings.Save(ddlGenders.SelectedItem.ToString(),"Gender");
            settings.Save(cbOption.SelectedItem.ToString(),"Api");
            
           

        }

        private void ddlGenders_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbOption_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
