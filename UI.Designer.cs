namespace Easy_AddedTraffic_AddOns
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.label1 = new System.Windows.Forms.Label();
            this.PathToGTAVTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.RefreshAddOnsButton = new System.Windows.Forms.Button();
            this.ModelNameTextBox = new System.Windows.Forms.TextBox();
            this.AddByModelNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path To GTA V:";
            // 
            // PathToGTAVTextBox
            // 
            this.PathToGTAVTextBox.Location = new System.Drawing.Point(101, 15);
            this.PathToGTAVTextBox.Name = "PathToGTAVTextBox";
            this.PathToGTAVTextBox.Size = new System.Drawing.Size(180, 20);
            this.PathToGTAVTextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.Location = new System.Drawing.Point(287, 14);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RefreshAddOnsButton
            // 
            this.RefreshAddOnsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshAddOnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshAddOnsButton.Location = new System.Drawing.Point(15, 43);
            this.RefreshAddOnsButton.Name = "RefreshAddOnsButton";
            this.RefreshAddOnsButton.Size = new System.Drawing.Size(350, 91);
            this.RefreshAddOnsButton.TabIndex = 3;
            this.RefreshAddOnsButton.Text = "Refresh Add-On Cars";
            this.RefreshAddOnsButton.UseVisualStyleBackColor = true;
            this.RefreshAddOnsButton.Click += new System.EventHandler(this.RefreshAddOnsButton_Click);
            // 
            // ModelNameTextBox
            // 
            this.ModelNameTextBox.Location = new System.Drawing.Point(15, 140);
            this.ModelNameTextBox.Name = "ModelNameTextBox";
            this.ModelNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.ModelNameTextBox.TabIndex = 4;
            // 
            // AddByModelNameButton
            // 
            this.AddByModelNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddByModelNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddByModelNameButton.Location = new System.Drawing.Point(191, 140);
            this.AddByModelNameButton.Name = "AddByModelNameButton";
            this.AddByModelNameButton.Size = new System.Drawing.Size(171, 22);
            this.AddByModelNameButton.TabIndex = 5;
            this.AddByModelNameButton.Text = "Add By Model Name";
            this.AddByModelNameButton.UseVisualStyleBackColor = true;
            this.AddByModelNameButton.Click += new System.EventHandler(this.AddByModelNameButton_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 174);
            this.Controls.Add(this.AddByModelNameButton);
            this.Controls.Add(this.ModelNameTextBox);
            this.Controls.Add(this.RefreshAddOnsButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathToGTAVTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Text = "Easy AddedTraffic AddOns";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathToGTAVTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button RefreshAddOnsButton;
        private System.Windows.Forms.TextBox ModelNameTextBox;
        private System.Windows.Forms.Button AddByModelNameButton;
    }
}

