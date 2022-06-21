namespace GLForma
{
    partial class GameRankForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbAttendance = new System.Windows.Forms.Label();
            this.lbHomeTeam = new System.Windows.Forms.Label();
            this.lbAwayTeam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GLForma.Properties.Resources.stadium;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.lbAttendance);
            this.panel1.Controls.Add(this.lbHomeTeam);
            this.panel1.Controls.Add(this.lbAwayTeam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 782);
            this.panel1.TabIndex = 0;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLocation.Location = new System.Drawing.Point(341, 373);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(129, 33);
            this.lbLocation.TabIndex = 3;
            this.lbLocation.Text = "Stadium";
            // 
            // lbAttendance
            // 
            this.lbAttendance.AutoSize = true;
            this.lbAttendance.BackColor = System.Drawing.Color.Transparent;
            this.lbAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAttendance.Location = new System.Drawing.Point(62, 351);
            this.lbAttendance.Name = "lbAttendance";
            this.lbAttendance.Size = new System.Drawing.Size(189, 37);
            this.lbAttendance.TabIndex = 2;
            this.lbAttendance.Text = "Attendance";
            // 
            // lbHomeTeam
            // 
            this.lbHomeTeam.AutoSize = true;
            this.lbHomeTeam.BackColor = System.Drawing.Color.Transparent;
            this.lbHomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHomeTeam.Location = new System.Drawing.Point(377, 633);
            this.lbHomeTeam.Name = "lbHomeTeam";
            this.lbHomeTeam.Size = new System.Drawing.Size(202, 37);
            this.lbHomeTeam.TabIndex = 1;
            this.lbHomeTeam.Text = "Home Team";
            // 
            // lbAwayTeam
            // 
            this.lbAwayTeam.AutoSize = true;
            this.lbAwayTeam.BackColor = System.Drawing.Color.Transparent;
            this.lbAwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAwayTeam.Location = new System.Drawing.Point(377, 106);
            this.lbAwayTeam.Name = "lbAwayTeam";
            this.lbAwayTeam.Size = new System.Drawing.Size(195, 37);
            this.lbAwayTeam.TabIndex = 0;
            this.lbAwayTeam.Text = "Away Team";
            // 
            // GameRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 782);
            this.Controls.Add(this.panel1);
            this.Name = "GameRankForm";
            this.Text = "GameRankForm";
            this.Load += new System.EventHandler(this.GameRankForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbAttendance;
        private System.Windows.Forms.Label lbHomeTeam;
        private System.Windows.Forms.Label lbAwayTeam;
    }
}