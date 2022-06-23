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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRankForm));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbAttendance = new System.Windows.Forms.Label();
            this.lbHomeTeam = new System.Windows.Forms.Label();
            this.lbAwayTeam = new System.Windows.Forms.Label();
            this.cmPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlGame.SuspendLayout();
            this.cmPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackgroundImage = global::GLForma.Properties.Resources.stadium;
            this.pnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGame.Controls.Add(this.lbLocation);
            this.pnlGame.Controls.Add(this.lbAttendance);
            this.pnlGame.Controls.Add(this.lbHomeTeam);
            this.pnlGame.Controls.Add(this.lbAwayTeam);
            this.pnlGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(930, 937);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseClick);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLocation.Location = new System.Drawing.Point(398, 450);
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
            this.lbAttendance.Location = new System.Drawing.Point(65, 422);
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
            this.lbHomeTeam.Location = new System.Drawing.Point(370, 767);
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
            this.lbAwayTeam.Location = new System.Drawing.Point(370, 123);
            this.lbAwayTeam.Name = "lbAwayTeam";
            this.lbAwayTeam.Size = new System.Drawing.Size(195, 37);
            this.lbAwayTeam.TabIndex = 0;
            this.lbAwayTeam.Text = "Away Team";
            // 
            // cmPrint
            // 
            this.cmPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPrintPreview,
            this.itemPrint});
            this.cmPrint.Name = "cmPrint";
            this.cmPrint.Size = new System.Drawing.Size(173, 48);
            // 
            // itemPrintPreview
            // 
            this.itemPrintPreview.Name = "itemPrintPreview";
            this.itemPrintPreview.Size = new System.Drawing.Size(172, 22);
            this.itemPrintPreview.Text = "Pregled prije ispisa";
            this.itemPrintPreview.Click += new System.EventHandler(this.itemPrintPreview_Click);
            // 
            // itemPrint
            // 
            this.itemPrint.Name = "itemPrint";
            this.itemPrint.Size = new System.Drawing.Size(172, 22);
            this.itemPrint.Text = "Ispis";
            this.itemPrint.Click += new System.EventHandler(this.itemPrint_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // GameRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 937);
            this.Controls.Add(this.pnlGame);
            this.Name = "GameRankForm";
            this.Text = "GameRankForm";
            this.Load += new System.EventHandler(this.GameRankForm_Load);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.cmPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbAttendance;
        private System.Windows.Forms.Label lbHomeTeam;
        private System.Windows.Forms.Label lbAwayTeam;
        private System.Windows.Forms.ContextMenuStrip cmPrint;
        private System.Windows.Forms.ToolStripMenuItem itemPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem itemPrint;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}