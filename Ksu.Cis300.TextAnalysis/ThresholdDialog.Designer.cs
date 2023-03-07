namespace Ksu.Cis300.TextAnalysis
{
    partial class ThresholdDialog
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxLabel1 = new System.Windows.Forms.Label();
            this.uxNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.uxOKButton1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.uxLabel1);
            this.flowLayoutPanel1.Controls.Add(this.uxNumericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.uxOKButton1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 101);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // uxLabel1
            // 
            this.uxLabel1.AutoSize = true;
            this.uxLabel1.Location = new System.Drawing.Point(4, 0);
            this.uxLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabel1.Name = "uxLabel1";
            this.uxLabel1.Size = new System.Drawing.Size(83, 20);
            this.uxLabel1.TabIndex = 1;
            this.uxLabel1.Text = "Threshold:";
            // 
            // uxNumericUpDown1
            // 
            this.uxNumericUpDown1.DecimalPlaces = 5;
            this.uxNumericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.uxNumericUpDown1.Location = new System.Drawing.Point(4, 25);
            this.uxNumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxNumericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumericUpDown1.Name = "uxNumericUpDown1";
            this.uxNumericUpDown1.Size = new System.Drawing.Size(180, 26);
            this.uxNumericUpDown1.TabIndex = 2;
            this.uxNumericUpDown1.Value = new decimal(new int[] {
            400,
            0,
            0,
            327680});
            // 
            // uxOKButton1
            // 
            this.uxOKButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOKButton1.Location = new System.Drawing.Point(4, 61);
            this.uxOKButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxOKButton1.Name = "uxOKButton1";
            this.uxOKButton1.Size = new System.Drawing.Size(112, 35);
            this.uxOKButton1.TabIndex = 3;
            this.uxOKButton1.Text = "OK";
            this.uxOKButton1.UseVisualStyleBackColor = true;
            // 
            // ThresholdDialog
            // 
            this.AcceptButton = this.uxOKButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(232, 158);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "ThresholdDialog";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label uxLabel1;
        private System.Windows.Forms.NumericUpDown uxNumericUpDown1;
        private System.Windows.Forms.Button uxOKButton1;
    }
}