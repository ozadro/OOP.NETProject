namespace GLForma
{
    partial class PlayerRankForm
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
            this.flpRankPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpRankPlayers
            // 
            this.flpRankPlayers.AutoScroll = true;
            this.flpRankPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRankPlayers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRankPlayers.Location = new System.Drawing.Point(0, 0);
            this.flpRankPlayers.Name = "flpRankPlayers";
            this.flpRankPlayers.Size = new System.Drawing.Size(1168, 574);
            this.flpRankPlayers.TabIndex = 1;
            // 
            // PlayerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 574);
            this.Controls.Add(this.flpRankPlayers);
            this.Name = "PlayerRankForm";
            this.Text = "Player Rank Form";
            this.Load += new System.EventHandler(this.PlayerRankForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRankPlayers;
    }
}