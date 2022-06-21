using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class MainForm : Form
    {   
            
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (ddlGenders.SelectedItem.ToString() == "Muški")
            {

                TeamStateForm newForm = new TeamStateForm();
                newForm.gender = "Muški";
                newForm.option = cbOption.SelectedItem.ToString();
                newForm.ShowDialog();
                

            }
            else if(ddlGenders.SelectedItem.ToString() == "Ženski")
            {
                
                TeamStateForm newForm = new TeamStateForm();
                newForm.gender = "Ženski";
                newForm.option = cbOption.SelectedItem.ToString(); 
                newForm.ShowDialog();

            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ddlGenders.SelectedIndex = 0;
            ddlLanguages.SelectedIndex = 0;
            cbOption.SelectedIndex = 0;
           
        }



        
    }
}
