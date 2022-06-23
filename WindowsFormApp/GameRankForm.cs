using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Utility.Manager;

namespace GLForma
{
    public partial class GameRankForm : Form
    {
        public string code;
        public string option;
        public string gender;


        public GameRankForm()
        {
            InitializeComponent();
            
        }

        private void GameRankForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillFormWithData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public  void FillFormWithData()
        {


            if (option == "Api")
            {
                LoadApiData();
            }
            else if (option == "Json")
            {
                MessageBox.Show("In Progress");
            }

            
        }


        private async void LoadApiData()
        {
            PlayersManager playersRecievedData = new PlayersManager();

          

            if (gender == "Muški")
            {
                var homeTeam = await playersRecievedData.GetMaleHomeTeam(code);
                var awayTeam = await playersRecievedData.GetMaleAwayTeam(code);
                var attendance = await playersRecievedData.GetGameDataMaleForTeam(code);
                lbHomeTeam.Text = homeTeam[0].Country;
                lbAwayTeam.Text = awayTeam[0].Country;
                lbAttendance.Text = attendance[0].Attendance.ToString();
                lbLocation.Text = attendance[0].Location;

            }
            else if (gender == "Ženski")
            {
                var homeTeam = await playersRecievedData.GetFemaleHomeTeam(code);
                var awayTeam = await playersRecievedData.GetFemaleAwayTeam(code);
                var attendance = await playersRecievedData.GetGameDataFemaleForTeam(code);
                lbHomeTeam.Text = homeTeam[0].Country;
                lbAwayTeam.Text = awayTeam[0].Country;
                lbAttendance.Text = attendance[0].Attendance.ToString();
                lbLocation.Text = attendance[0].Location;
            }

            
        }

 
        private void itemPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            
            printPreviewDialog.ShowDialog();
        }

        private void itemPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
        public void OnRightClick(object sender)
        {


            Panel pnl = sender as Panel;
            Point locationOnForm = pnl.Parent.PointToScreen(pnl.Location);

            cmPrint.Show(locationOnForm);

        }
        private void pnlGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            OnRightClick(sender as Panel);


        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            var graphics = e.Graphics;
            var normalFont = new Font("Calibri", 22);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.HasMorePages = false;
            Bitmap image = new Bitmap(pnlGame.Width, pnlGame.Height, pnlGame.CreateGraphics());
            pnlGame.DrawToBitmap(image, new Rectangle(0, 0, pnlGame.Width, pnlGame.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = (image.Height / image.Width);

            graphics.DrawImage(image, bounds.Left, bounds.Top ,bounds.Width, bounds.Height);
           
            

        }
    }
}
