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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerRankForm));
            this.flpRankPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.cmPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.cmPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpRankPlayers
            // 
            this.flpRankPlayers.AutoScroll = true;
            this.flpRankPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRankPlayers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRankPlayers.Location = new System.Drawing.Point(0, 0);
            this.flpRankPlayers.Name = "flpRankPlayers";
            this.flpRankPlayers.Size = new System.Drawing.Size(1412, 618);
            this.flpRankPlayers.TabIndex = 1;
            this.flpRankPlayers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flpRankPlayers_MouseClick);
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
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // PlayerRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 618);
            this.Controls.Add(this.flpRankPlayers);
            this.Name = "PlayerRankForm";
            this.Text = "Player Rank Form";
            this.Load += new System.EventHandler(this.PlayerRankForm_Load);
            this.cmPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRankPlayers;
        private System.Windows.Forms.ContextMenuStrip cmPrint;
        private System.Windows.Forms.ToolStripMenuItem itemPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem itemPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}