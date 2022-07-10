using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;
using Utility.Manager;
using Utility.Model;

namespace GLForma
{
    public partial class PlayerRankForm : Form
    {
        public string code;
        public string gender;
        public string option;
        public IList<StartingEleven> formPlayers;

        public PlayerRankForm()
        {
            InitializeComponent();
        }

        private void PlayerRankForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                FillWithData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void FillWithData()
        {
            if (option == "Api")
            {
                LoadApiData();
            }
            else if (option == "Json")
            {
                MessageBox.Show("In progress");
            }
        }

        private async void LoadApiData()
        {
            PlayersManager eventRecievedData = new PlayersManager();

            PlayerRank plr = new PlayerRank();

            if (gender == "Muški" || gender == "Male")
            {
                var maleEventData = await eventRecievedData.GetMaleTeamEvent(code);
                var maleEvent = EventControlsList(maleEventData);
                foreach (var item in maleEvent)
                {
                    flpRankPlayers.Controls.Add(item);
                }
            }
            else if (gender == "Ženski" || gender == "Female")
            {
                var femaleEventData = await eventRecievedData.GetFemaleEvent(code);
                var femaleEvenet = EventControlsList(femaleEventData);
                foreach (var item in femaleEvenet)
                {
                    flpRankPlayers.Controls.Add(item);
                }
            }
           
        }


        IList<PlayerRank> EventControlsList(IList<TeamEvent> data)
        {


           

            IList<PlayerRank> players = new List<PlayerRank>();


            foreach (var item in formPlayers)
            {
                bool exists = true;

                PlayerRank plr = new PlayerRank();
                for (int i = 0; i < data.Count; i++)
                {
                    plr.goals = "goals:";
                    plr.cards = "yellow-cards: ";
                    if (item.Name == data[i].Player)
                    {
                        exists = false;
                        plr.name = data[i].Player;
                        if (data[i].TypeOfEvent == "goal")
                        {
                            
                            plr.countGoals++;
                            
                        }
                        else if(data[i].TypeOfEvent == "goal-own")
                        {
                            plr.countGoals++;
                        }
                        else if (data[i].TypeOfEvent == "goal-penalty")
                        {
                            plr.countGoals++;
                        }
                        if (data[i].TypeOfEvent == "yellow-card")
                        {
                            
                            plr.countCards++;
                        }

                       
                    }
                    if (exists)
                    {
                        plr.name = item.Name;
                    }


                }

                players.Add(plr);

            }

            

            


            return players;
        }


        private void itemPrintPreview_Click(object sender, EventArgs e)
        {

            try
            {
                printDocument.DefaultPageSettings.Landscape = true;
                printPreviewDialog.Document = printDocument;

                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void itemPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument.DefaultPageSettings.Landscape = true;
                printDocument.Print();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void flpRankPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            OnRightClick(sender as Panel);
        }
        public void OnRightClick(object sender)
        {


            Panel pnl = sender as Panel;
            Point locationOnForm = pnl.Parent.PointToScreen(pnl.Location);

            cmPrint.Show(locationOnForm);

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
           
                var graphics = e.Graphics;
                var normalFont = new Font("Calibri", 22);
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.HasMorePages = false;
           
                Bitmap image = new Bitmap(flpRankPlayers.Width, flpRankPlayers.Height, flpRankPlayers.CreateGraphics());
                flpRankPlayers.DrawToBitmap(image, new Rectangle(0, 0, flpRankPlayers.Width, flpRankPlayers.Height));
                printDocument.DefaultPageSettings.Landscape = true;
                RectangleF bounds = e.PageSettings.PrintableArea;
                 bounds.Height = e.PageSettings.PrintableArea.Height;
                 bounds.Width = e.PageSettings.PrintableArea.Width;
                graphics.DrawImage(image, bounds.Left, bounds.Top, bounds.Height, bounds.Width);
            
            
        }
    }
}
