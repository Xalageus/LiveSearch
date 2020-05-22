namespace LiveSearch
{
    partial class Options
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
            this.searchTypeLabel = new System.Windows.Forms.Label();
            this.searchTypeCB = new System.Windows.Forms.ComboBox();
            this.stdGB = new System.Windows.Forms.GroupBox();
            this.stdLabel = new System.Windows.Forms.Label();
            this.caseSensitiveCB = new System.Windows.Forms.CheckBox();
            this.stdGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTypeLabel
            // 
            this.searchTypeLabel.AutoSize = true;
            this.searchTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.searchTypeLabel.Name = "searchTypeLabel";
            this.searchTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.searchTypeLabel.TabIndex = 0;
            this.searchTypeLabel.Text = "Search Type";
            // 
            // searchTypeCB
            // 
            this.searchTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeCB.FormattingEnabled = true;
            this.searchTypeCB.Items.AddRange(new object[] {
            "Manual Contains",
            "Contains (C# Built-in)",
            "Manual Spread"});
            this.searchTypeCB.Location = new System.Drawing.Point(86, 6);
            this.searchTypeCB.Name = "searchTypeCB";
            this.searchTypeCB.Size = new System.Drawing.Size(143, 21);
            this.searchTypeCB.TabIndex = 1;
            this.searchTypeCB.SelectedValueChanged += new System.EventHandler(this.searchTypeCB_SelectedValueChanged);
            // 
            // stdGB
            // 
            this.stdGB.Controls.Add(this.stdLabel);
            this.stdGB.Location = new System.Drawing.Point(12, 33);
            this.stdGB.Name = "stdGB";
            this.stdGB.Size = new System.Drawing.Size(217, 82);
            this.stdGB.TabIndex = 2;
            this.stdGB.TabStop = false;
            this.stdGB.Text = "Search Type Description";
            // 
            // stdLabel
            // 
            this.stdLabel.AutoSize = true;
            this.stdLabel.Location = new System.Drawing.Point(6, 16);
            this.stdLabel.Name = "stdLabel";
            this.stdLabel.Size = new System.Drawing.Size(84, 13);
            this.stdLabel.TabIndex = 0;
            this.stdLabel.Text = "descriptionLabel";
            // 
            // caseSensitiveCB
            // 
            this.caseSensitiveCB.AutoSize = true;
            this.caseSensitiveCB.Checked = true;
            this.caseSensitiveCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.caseSensitiveCB.Location = new System.Drawing.Point(15, 121);
            this.caseSensitiveCB.Name = "caseSensitiveCB";
            this.caseSensitiveCB.Size = new System.Drawing.Size(96, 17);
            this.caseSensitiveCB.TabIndex = 3;
            this.caseSensitiveCB.Text = "Case Sensitive";
            this.caseSensitiveCB.UseVisualStyleBackColor = true;
            this.caseSensitiveCB.CheckedChanged += new System.EventHandler(this.caseSensitiveCB_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 150);
            this.Controls.Add(this.caseSensitiveCB);
            this.Controls.Add(this.stdGB);
            this.Controls.Add(this.searchTypeCB);
            this.Controls.Add(this.searchTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.stdGB.ResumeLayout(false);
            this.stdGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchTypeLabel;
        private System.Windows.Forms.ComboBox searchTypeCB;
        private System.Windows.Forms.GroupBox stdGB;
        private System.Windows.Forms.Label stdLabel;
        private System.Windows.Forms.CheckBox caseSensitiveCB;
    }
}