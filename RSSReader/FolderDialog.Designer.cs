namespace RSSReader
{
    partial class FolderDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.folderIDLabel = new System.Windows.Forms.Label();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.folderIDTextBox = new System.Windows.Forms.TextBox();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(205, 202);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(124, 202);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // folderIDLabel
            // 
            this.folderIDLabel.AutoSize = true;
            this.folderIDLabel.Location = new System.Drawing.Point(13, 41);
            this.folderIDLabel.Name = "folderIDLabel";
            this.folderIDLabel.Size = new System.Drawing.Size(49, 13);
            this.folderIDLabel.TabIndex = 2;
            this.folderIDLabel.Text = "Folder ID:";
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(13, 71);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(66, 13);
            this.folderNameLabel.TabIndex = 3;
            this.folderNameLabel.Text = "Folder Name:";
            // 
            // folderIDTextBox
            // 
            this.folderIDTextBox.Location = new System.Drawing.Point(103, 41);
            this.folderIDTextBox.Name = "folderIDTextBox";
            this.folderIDTextBox.ReadOnly = true;
            this.folderIDTextBox.Size = new System.Drawing.Size(177, 20);
            this.folderIDTextBox.TabIndex = 4;
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(103, 71);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.folderNameTextBox.TabIndex = 5;
            // 
            // FolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 237);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.folderIDTextBox);
            this.Controls.Add(this.folderNameLabel);
            this.Controls.Add(this.folderIDLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "FolderDialog";
            this.Text = "Folder Properties";
            this.Load += new System.EventHandler(this.FolderDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label folderIDLabel;
        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.TextBox folderIDTextBox;
        private System.Windows.Forms.TextBox folderNameTextBox;
    }
}