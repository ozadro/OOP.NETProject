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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            ddlLanguages.SelectedIndex = 0;
            ddlGenders.SelectedIndex = 0;
            this.Left = (SystemParameters.WorkArea.Width - Width) / 2 + SystemParameters.WorkArea.Left;
            this.Top = (SystemParameters.WorkArea.Height - Height) / 2 + SystemParameters.WorkArea.Top;

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (ddlGenders.SelectedItem.ToString() == "Muški" || ddlGenders.SelectedItem.ToString() == "Male")
            {

                StatesWindow newForm = new StatesWindow();
                newForm.gender = "Muški";
                //settings
                newForm.language = ddlLanguages.SelectedItem.ToString();
                newForm.Width = this.Width;
                newForm.Height = this.Height;
                newForm.Show();



            }
            else if (ddlGenders.SelectedItem.ToString() == "Ženski" || ddlGenders.SelectedItem.ToString() == "Female")
            {

                StatesWindow newForm = new StatesWindow();
                newForm.gender = "Ženski";
                //settings
                newForm.language = ddlLanguages.SelectedItem.ToString();
                newForm.Width = this.Width;
                newForm.Height = this.Height;
                newForm.Show();

            }

        }

        private void ddlSettings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (ddlSettings.SelectedItem.ToString() == "Fullscreen")
            {
                Application.Current.MainWindow.Height = SystemParameters.WorkArea.Height;
                Application.Current.MainWindow.Width = SystemParameters.WorkArea.Width;
            }
            else if (ddlSettings.SelectedItem.ToString() == "600x800")
            {
                Application.Current.MainWindow.Width = 800;
                Application.Current.MainWindow.Height = 600;
                
            }
            else if (ddlSettings.SelectedItem.ToString() == "300x500")
            {
                Application.Current.MainWindow.Width = 500;
                Application.Current.MainWindow.Height = 300;
               
            }
            else if (ddlSettings.SelectedItem.ToString() == "1000x700")
            {
                Application.Current.MainWindow.Width = 700;
                Application.Current.MainWindow.Height = 1000;
                
            }
            

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.Left = (SystemParameters.WorkArea.Width - Width) / 2 + SystemParameters.WorkArea.Left;
            this.Top = (SystemParameters.WorkArea.Height - Height) / 2 + SystemParameters.WorkArea.Top;
        }
    }
}
