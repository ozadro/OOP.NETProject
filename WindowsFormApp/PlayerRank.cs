using System;
using System.Windows.Forms;

namespace GLForma
{
    public partial class PlayerRank : UserControl
    {
        public string code;
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
            lbCountGoals.Text = countGoals.ToString();
            lbCountCards.Text = countCards.ToString();
            //code = playerRankForm.code;
        }
    }
}
