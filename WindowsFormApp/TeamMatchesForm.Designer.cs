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
            this.flpPlayers.AutoScroll = true;
            this.flpPlayers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPlayers.Location = new System.Drawing.Point(1, 2);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(1108, 323);
            this.flpPlayers.TabIndex = 0;
            // 
            // flpFavorites
            // 
            this.flpFavorites.AllowDrop = true;
            this.flpFavorites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpFavorites.BackColor = System.Drawing.Color.Wheat;
            this.flpFavorites.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFavorites.Location = new System.Drawing.Point(131, 354);
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Size = new System.Drawing.Size(827, 322);
            this.flpFavorites.TabIndex = 1;
            this.flpFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragDrop);
            this.flpFavorites.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragEnter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(964, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Obriši";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseClick);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(964, 383);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Save";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseClick);
            // 
            // btnRankPlayer
            // 
            this.btnRankPlayer.Location = new System.Drawing.Point(964, 412);
            this.btnRankPlayer.Name = "btnRankPlayer";
            this.btnRankPlayer.Size = new System.Drawing.Size(124, 23);
            this.btnRankPlayer.TabIndex = 4;
            this.btnRankPlayer.Text = "Rang lista igraca";
            this.btnRankPlayer.UseVisualStyleBackColor = true;
            this.btnRankPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRankPlayer_MouseClick);
            // 
            // btnRankVisitor
            // 
            this.btnRankVisitor.Location = new System.Drawing.Point(964, 441);
            this.btnRankVisitor.Name = "btnRankVisitor";
            this.btnRankVisitor.Size = new System.Drawing.Size(124, 23);
            this.btnRankVisitor.TabIndex = 5;
            this.btnRankVisitor.Text = "Rang lista posjetitelja";
            this.btnRankVisitor.UseVisualStyleBackColor = true;
            this.btnRankVisitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRankVisitor_MouseClick);
            // 
            // TeamMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 688);
            this.Controls.Add(this.btnRankVisitor);
            this.Controls.Add(this.btnRankPlayer);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.flpFavorites);
            this.Controls.Add(this.flpPlayers);
            this.Name = "TeamMatchesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamMatchesForm";
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