using System;
using System.Drawing;
using System.Windows.Forms;
using Utility.Model;
using WindowsFormApp;

namespace GLForma
{
    public partial class Players : UserControl
    {
        public string name = "";
        public long shirtNumber;
        public string position = "";
        public bool captain;
        public StartingEleven strelv = new StartingEleven();
        public Control playerDnD;
        public TeamMatchesForm testerbester;
        

        public Players()
        {
            InitializeComponent();

        }

        private void Players_Load(object sender, EventArgs e)
        {
            InputPlayersData();
        }




        private void InputPlayersData()
        {

            lbName.Text = name;
            strelv.Name = name;
            lbShirtNumber.Text = shirtNumber.ToString();
            strelv.ShirtNumber = shirtNumber;
            lbPosition.Text = position;
            strelv.Position = position;
            if (captain == true)
            {
                strelv.Captain = true;
                lbCaptain.Text = "C";
            }
            else
            {
                strelv.Captain = false;
                lbCaptain.Text = "";
            }
        }

        private void Players_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            startDnD(sender as Players);

        }



        private void startDnD(Players player)
        {


            player.DoDragDrop(player, DragDropEffects.Move);

        }

        public void LoadPicture()
        {
           

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.bmp;*.jpg;*.jpeg;*.png";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = Image.FromFile(ofd.FileName);

            }

        }

        public void OnRightClick(object sender)
        {

            
            Players player = sender as Players;
            Point locationOnForm = player.Parent.PointToScreen(player.Location);

            csMenu.Show(locationOnForm);

        }

        
      

   


        private void Players_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) return;
            OnRightClick(sender as Players);




        }

        public void itemAddFav_Click(object sender, EventArgs e)
        {
            Players player = this;
           
            testerbester.AddFavs(player);
            
        }

        private void itemAddPic_Click(object sender, EventArgs e)
        {
            LoadPicture();
        }

        private void itemRemovePic_Click(object sender, EventArgs e)
        {
           BackgroundImage = Properties.Resources.jersey;
        }
    }
    
}
