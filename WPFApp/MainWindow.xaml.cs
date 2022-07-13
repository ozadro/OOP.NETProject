using System.Windows;
using System.Windows.Controls;

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
            
            if (ddlGenders.Text == "Muški")
            {

                StatesWindow newForm = new StatesWindow(ddlLanguages.Text);
                newForm.gender = "Muški";
                //settings
                newForm.Width = this.Width;
                newForm.Height = this.Height;
                newForm.Show();
                this.Close();




            }
            else if (ddlGenders.Text == "Ženski")
            {

                StatesWindow newForm = new StatesWindow(ddlLanguages.Text);
                newForm.gender = "Ženski";
                //settings
                newForm.Width = this.Width;
                newForm.Height = this.Height;
                newForm.Show();
                this.Close();

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
