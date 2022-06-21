namespace GLForma
{
    partial class PlayerRank
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbGoals = new System.Windows.Forms.Label();
            this.lbCards = new System.Windows.Forms.Label();
            this.lbCountGoals = new System.Windows.Forms.Label();
            this.lbCountCards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.Black;
            this.lbFullName.ForeColor = System.Drawing.Color.White;
            this.lbFullName.Location = new System.Drawing.Point(86, 60);
            this.lbFullName.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(59, 13);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "lbFullName";
            // 
            // lbGoals
            // 
            this.lbGoals.AutoSize = true;
            this.lbGoals.BackColor = System.Drawing.Color.Black;
            this.lbGoals.ForeColor = System.Drawing.Color.White;
            this.lbGoals.Location = new System.Drawing.Point(86, 88);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.Size = new System.Drawing.Size(35, 13);
            this.lbGoals.TabIndex = 1;
            this.lbGoals.Text = "label1";
            // 
            // lbCards
            // 
            this.lbCards.AutoSize = true;
            this.lbCards.BackColor = System.Drawing.Color.Black;
            this.lbCards.ForeColor = System.Drawing.Color.White;
            this.lbCards.Location = new System.Drawing.Point(86, 110);
            this.lbCards.Name = "lbCards";
            this.lbCards.Size = new System.Drawing.Size(35, 13);
            this.lbCards.TabIndex = 2;
            this.lbCards.Text = "label1";
            // 
            // lbCountGoals
            // 
            this.lbCountGoals.AutoSize = true;
            this.lbCountGoals.BackColor = System.Drawing.Color.Black;
            this.lbCountGoals.ForeColor = System.Drawing.Color.White;
            this.lbCountGoals.Location = new System.Drawing.Point(127, 88);
            this.lbCountGoals.Name = "lbCountGoals";
            this.lbCountGoals.Size = new System.Drawing.Size(35, 13);
            this.lbCountGoals.TabIndex = 3;
            this.lbCountGoals.Text = "label1";
            // 
            // lbCountCards
            // 
            this.lbCountCards.AutoSize = true;
            this.lbCountCards.BackColor = System.Drawing.Color.Black;
            this.lbCountCards.ForeColor = System.Drawing.Color.White;
            this.lbCountCards.Location = new System.Drawing.Point(127, 110);
            this.lbCountCards.Name = "lbCountCards";
            this.lbCountCards.Size = new System.Drawing.Size(35, 13);
            this.lbCountCards.TabIndex = 4;
            this.lbCountCards.Text = "label1";
            // 
            // PlayerRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GLForma.Properties.Resources.jersey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbCountCards);
            this.Controls.Add(this.lbCountGoals);
            this.Controls.Add(this.lbCards);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.lbFullName);
            this.DoubleBuffered = true;
            this.Name = "PlayerRank";
            this.Size = new System.Drawing.Size(231, 222);
            this.Load += new System.EventHandler(this.PlayerRank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbGoals;
        private System.Windows.Forms.Label lbCards;
        private System.Windows.Forms.Label lbCountGoals;
        private System.Windows.Forms.Label lbCountCards;
    }
}
