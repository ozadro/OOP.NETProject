namespace WindowsFormApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ddlGenders = new System.Windows.Forms.ComboBox();
            this.ddlLanguages = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ddlGenders
            // 
            this.ddlGenders.FormattingEnabled = true;
            this.ddlGenders.Items.AddRange(new object[] {
            resources.GetString("ddlGenders.Items"),
            resources.GetString("ddlGenders.Items1")});
            resources.ApplyResources(this.ddlGenders, "ddlGenders");
            this.ddlGenders.Name = "ddlGenders";
            // 
            // ddlLanguages
            // 
            this.ddlLanguages.FormattingEnabled = true;
            this.ddlLanguages.Items.AddRange(new object[] {
            resources.GetString("ddlLanguages.Items"),
            resources.GetString("ddlLanguages.Items1")});
            resources.ApplyResources(this.ddlLanguages, "ddlLanguages");
            this.ddlLanguages.Name = "ddlLanguages";
            // 
            // btnChoose
            // 
            resources.ApplyResources(this.btnChoose, "btnChoose");
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // cbOption
            // 
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Items.AddRange(new object[] {
            resources.GetString("cbOption.Items"),
            resources.GetString("cbOption.Items1")});
            resources.ApplyResources(this.cbOption, "cbOption");
            this.cbOption.Name = "cbOption";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbOption);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.ddlLanguages);
            this.Controls.Add(this.ddlGenders);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlGenders;
        private System.Windows.Forms.ComboBox ddlLanguages;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ComboBox cbOption;
    }
}