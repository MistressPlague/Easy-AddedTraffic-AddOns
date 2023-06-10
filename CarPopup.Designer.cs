namespace Easy_AddedTraffic_AddOns
{
    partial class CarPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPopup));
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LocationsCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLabel.Location = new System.Drawing.Point(13, 13);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(95, 24);
            this.CarNameLabel.TabIndex = 0;
            this.CarNameLabel.Text = "Car Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Where do you want this to spawn?";
            // 
            // LocationsCheckBoxList
            // 
            this.LocationsCheckBoxList.FormattingEnabled = true;
            this.LocationsCheckBoxList.Location = new System.Drawing.Point(17, 81);
            this.LocationsCheckBoxList.Name = "LocationsCheckBoxList";
            this.LocationsCheckBoxList.Size = new System.Drawing.Size(232, 169);
            this.LocationsCheckBoxList.TabIndex = 2;
            // 
            // NextButton
            // 
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(17, 261);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(232, 53);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CarPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 332);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.LocationsCheckBoxList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CarPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox LocationsCheckBoxList;
        private System.Windows.Forms.Button NextButton;
    }
}