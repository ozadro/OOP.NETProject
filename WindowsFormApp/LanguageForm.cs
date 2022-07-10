using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Manager;
using WindowsFormApp;

namespace GLForma
{
    public partial class LanguageForm : Form
    {
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            SettingsManager settings = new SettingsManager();
            string language = "Language";
            settings.Save(ddlLanguage.SelectedItem.ToString(),language);
        }


        private void LanguageForm_Load(object sender, EventArgs e)
        {
            SettingsManager settings = new SettingsManager();
            string language = "Language";
            var data = settings.Load(language);
            int index = ddlLanguage.FindString(data);
            if (settings.FileExists(language))
            {

                ddlLanguage.SelectedIndex = index;

            }
            else
            {
                ddlLanguage.SelectedIndex = 0;
            }
        }

        private void btnNext_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.language = ddlLanguage.SelectedItem.ToString();
            newForm.ShowDialog();
        }

        private void ddlLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
