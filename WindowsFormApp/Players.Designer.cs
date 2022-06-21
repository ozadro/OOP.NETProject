namespace GLForma
{
    partial class Players
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
            this.components = new System.ComponentModel.Container();
            this.lbCaptain = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbShirtNumber = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.csMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemAddFav = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddPic = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRemovePic = new System.Windows.Forms.ToolStripMenuItem();
            this.csMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCaptain
            // 
            this.lbCaptain.AutoSize = true;
            this.lbCaptain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCaptain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCaptain.ForeColor = System.Drawing.Color.Orange;
            this.lbCaptain.Location = new System.Drawing.Point(48, 36);
            this.lbCaptain.Name = "lbCaptain";
            this.lbCaptain.Size = new System.Drawing.Size(52, 18);
            this.lbCaptain.TabIndex = 3;
            this.lbCaptain.Text = "label3";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPosition.ForeColor = System.Drawing.Color.White;
            this.lbPosition.Location = new System.Drawing.Point(48, 81);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(35, 13);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "label2";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(105, 81);
            this.lbName.MaximumSize = new System.Drawing.Size(85, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.UseMnemonic = false;
            // 
            // lbShirtNumber
            // 
            this.lbShirtNumber.AutoSize = true;
            this.lbShirtNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbShirtNumber.ForeColor = System.Drawing.Color.White;
            this.lbShirtNumber.Location = new System.Drawing.Point(105, 110);
            this.lbShirtNumber.Name = "lbShirtNumber";
            this.lbShirtNumber.Size = new System.Drawing.Size(35, 13);
            this.lbShirtNumber.TabIndex = 1;
            this.lbShirtNumber.Text = "label1";
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // csMenu
            // 
            this.csMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAddFav,
            this.itemAddPic,
            this.itemRemovePic});
            this.csMenu.Name = "csMenu";
            this.csMenu.Size = new System.Drawing.Size(168, 70);
            // 
            // itemAddFav
            // 
            this.itemAddFav.Name = "itemAddFav";
            this.itemAddFav.Size = new System.Drawing.Size(167, 22);
            this.itemAddFav.Text = "Add to Favourites";
            this.itemAddFav.Click += new System.EventHandler(this.itemAddFav_Click);
            // 
            // itemAddPic
            // 
            this.itemAddPic.Name = "itemAddPic";
            this.itemAddPic.Size = new System.Drawing.Size(167, 22);
            this.itemAddPic.Text = "Add Picture";
            this.itemAddPic.Click += new System.EventHandler(this.itemAddPic_Click);
            // 
            // itemRemovePic
            // 
            this.itemRemovePic.Name = "itemRemovePic";
            this.itemRemovePic.Size = new System.Drawing.Size(167, 22);
            this.itemRemovePic.Text = "Remove Picture";
            this.itemRemovePic.Click += new System.EventHandler(this.itemRemovePic_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GLForma.Properties.Resources.jersey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbCaptain);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbShirtNumber);
            this.Controls.Add(this.lbName);
            this.DoubleBuffered = true;
            this.Name = "Players";
            this.Size = new System.Drawing.Size(261, 263);
            this.Load += new System.EventHandler(this.Players_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Players_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Players_MouseDown);
            this.csMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCaptain;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbShirtNumber;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ContextMenuStrip csMenu;
        private System.Windows.Forms.ToolStripMenuItem itemAddFav;
        private System.Windows.Forms.ToolStripMenuItem itemAddPic;
        private System.Windows.Forms.ToolStripMenuItem itemRemovePic;
    }
}
