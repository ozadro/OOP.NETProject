using System;
using System.Windows.Forms;

namespace GLForma
{
    public partial class PlayerRank : UserControl
    {
        public string name;
        public string goals;
        public string cards;
        public int countGoals;
        public int countCards;
       
        public PlayerRankForm playerRankForm;
        public PlayerRank()
        {
            InitializeComponent();
        }

        private void PlayerRank_Load(object sender, EventArgs e)
        {
            InitializePlayerRank();
        }

        public void InitializePlayerRank()
        {
            lbFullName.Text = name;
            lbCards.Text = cards;
            lbGoals.Text = goals;
            lbCountCards.Text = countCards.ToString();
            lbCountGoals.Text = countGoals.ToString();
            
        }
    }
}
