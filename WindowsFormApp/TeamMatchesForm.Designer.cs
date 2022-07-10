namespace WindowsFormApp
{
    partial class TeamMatchesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamMatchesForm));
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRankPlayer = new System.Windows.Forms.Button();
            this.btnRankVisitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpPlayers
            // 
            resources.ApplyResources(this.flpPlayers, "flpPlayers");
            this.flpPlayers.Name = "flpPlayers";
            // 
            // flpFavorites
            // 
            resources.ApplyResources(this.flpFavorites, "flpFavorites");
            this.flpFavorites.AllowDrop = true;
            this.flpFavorites.BackColor = System.Drawing.Color.Wheat;
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragDrop);
            this.flpFavorites.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragEnter);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseClick);
            // 
            // btnTest
            // 
            resources.ApplyResources(this.btnTest, "btnTest");
            this.btnTest.Name = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseClick);
            // 
            // btnRankPlayer
            // 
            resources.ApplyResources(this.btnRankPlayer, "btnRankPlayer");
            this.btnRankPlayer.Name = "btnRankPlayer";
            this.btnRankPlayer.UseVisualStyleBackColor = true;
            this.btnRankPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRankPlayer_MouseClick);
            // 
            // btnRankVisitor
            // 
            resources.ApplyResources(this.btnRankVisitor, "btnRankVisitor");
            this.btnRankVisitor.Name = "btnRankVisitor";
            this.btnRankVisitor.UseVisualStyleBackColor = true;
            this.btnRankVisitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRankVisitor_MouseClick);
            // 
            // TeamMatchesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRankVisitor);
            this.Controls.Add(this.btnRankPlayer);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.flpFavorites);
            this.Controls.Add(this.flpPlayers);
            this.Name = "TeamMatchesForm";
            this.Load += new System.EventHandler(this.TeamMatchesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlayers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTest;
        public System.Windows.Forms.FlowLayoutPanel flpFavorites;
        private System.Windows.Forms.Button btnRankPlayer;
        private System.Windows.Forms.Button btnRankVisitor;
    }
}