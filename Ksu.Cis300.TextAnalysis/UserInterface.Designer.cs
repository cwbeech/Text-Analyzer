namespace Ksu.Cis300.TextAnalysis
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxOpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.uxListView1 = new System.Windows.Forms.ListView();
            this.uxColumnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxColumnVocabulary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxColumnWordsUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxColumnDifference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxFolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.uxMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip1
            // 
            this.uxMenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.uxMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uxMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenFolderToolStripMenuItem,
            this.uxThresholdToolStripMenuItem,
            this.uxToolStripTextBox1});
            resources.ApplyResources(this.uxMenuStrip1, "uxMenuStrip1");
            this.uxMenuStrip1.Name = "uxMenuStrip1";
            // 
            // uxOpenFolderToolStripMenuItem
            // 
            this.uxOpenFolderToolStripMenuItem.Name = "uxOpenFolderToolStripMenuItem";
            resources.ApplyResources(this.uxOpenFolderToolStripMenuItem, "uxOpenFolderToolStripMenuItem");
            this.uxOpenFolderToolStripMenuItem.Click += new System.EventHandler(this.uxOpenFolderToolStripMenuItem_Click);
            // 
            // uxThresholdToolStripMenuItem
            // 
            this.uxThresholdToolStripMenuItem.Name = "uxThresholdToolStripMenuItem";
            resources.ApplyResources(this.uxThresholdToolStripMenuItem, "uxThresholdToolStripMenuItem");
            this.uxThresholdToolStripMenuItem.Click += new System.EventHandler(this.uxThresholdToolStripMenuItem_Click);
            // 
            // uxToolStripTextBox1
            // 
            resources.ApplyResources(this.uxToolStripTextBox1, "uxToolStripTextBox1");
            this.uxToolStripTextBox1.Name = "uxToolStripTextBox1";
            this.uxToolStripTextBox1.ReadOnly = true;
            // 
            // uxListView1
            // 
            this.uxListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxColumnFileName,
            this.uxColumnVocabulary,
            this.uxColumnWordsUsed,
            this.uxColumnDifference});
            resources.ApplyResources(this.uxListView1, "uxListView1");
            this.uxListView1.GridLines = true;
            this.uxListView1.HideSelection = false;
            this.uxListView1.MultiSelect = false;
            this.uxListView1.Name = "uxListView1";
            this.uxListView1.UseCompatibleStateImageBehavior = false;
            this.uxListView1.View = System.Windows.Forms.View.Details;
            this.uxListView1.SelectedIndexChanged += new System.EventHandler(this.uxListView1_SelectedIndexChanged);
            // 
            // uxColumnFileName
            // 
            resources.ApplyResources(this.uxColumnFileName, "uxColumnFileName");
            // 
            // uxColumnVocabulary
            // 
            resources.ApplyResources(this.uxColumnVocabulary, "uxColumnVocabulary");
            // 
            // uxColumnWordsUsed
            // 
            resources.ApplyResources(this.uxColumnWordsUsed, "uxColumnWordsUsed");
            // 
            // uxColumnDifference
            // 
            resources.ApplyResources(this.uxColumnDifference, "uxColumnDifference");
            // 
            // UserInterface
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxListView1);
            this.Controls.Add(this.uxMenuStrip1);
            this.MainMenuStrip = this.uxMenuStrip1;
            this.Name = "UserInterface";
            this.uxMenuStrip1.ResumeLayout(false);
            this.uxMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxOpenFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox uxToolStripTextBox1;
        private System.Windows.Forms.ListView uxListView1;
        private System.Windows.Forms.ColumnHeader uxColumnFileName;
        private System.Windows.Forms.ColumnHeader uxColumnVocabulary;
        private System.Windows.Forms.ColumnHeader uxColumnDifference;
        private System.Windows.Forms.ColumnHeader uxColumnWordsUsed;
        private System.Windows.Forms.FolderBrowserDialog uxFolderBrowserDialog1;
    }
}

