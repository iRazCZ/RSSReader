namespace RSSReader
{
    partial class ChannelDialog
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
            this.folderLabel = new System.Windows.Forms.Label();
            this.channelIDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.lastUpdatedLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.channelIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.lastUpdatedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(10, 34);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(35, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Folder:";
            // 
            // channelIDLabel
            // 
            this.channelIDLabel.AutoSize = true;
            this.channelIDLabel.Location = new System.Drawing.Point(8, 65);
            this.channelIDLabel.Name = "channelIDLabel";
            this.channelIDLabel.Size = new System.Drawing.Size(59, 13);
            this.channelIDLabel.TabIndex = 1;
            this.channelIDLabel.Text = "Channel ID:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(8, 95);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(26, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(8, 125);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(28, 13);
            this.urlLabel.TabIndex = 3;
            this.urlLabel.Text = "URL:";
            // 
            // lastUpdatedLabel
            // 
            this.lastUpdatedLabel.AutoSize = true;
            this.lastUpdatedLabel.Location = new System.Drawing.Point(8, 155);
            this.lastUpdatedLabel.Name = "lastUpdatedLabel";
            this.lastUpdatedLabel.Size = new System.Drawing.Size(70, 13);
            this.lastUpdatedLabel.TabIndex = 4;
            this.lastUpdatedLabel.Text = "Last Updated:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(205, 231);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(124, 231);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // folderComboBox
            // 
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(100, 34);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(180, 21);
            this.folderComboBox.TabIndex = 7;

            // 
            // channelIDTextBox
            // 
            this.channelIDTextBox.Location = new System.Drawing.Point(100, 65);
            this.channelIDTextBox.Name = "channelIDTextBox";
            this.channelIDTextBox.ReadOnly = true;
            this.channelIDTextBox.Size = new System.Drawing.Size(180, 20);
            this.channelIDTextBox.TabIndex = 8;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(100, 95);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(180, 20);
            this.titleTextBox.TabIndex = 9;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(100, 125);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(180, 20);
            this.urlTextBox.TabIndex = 10;
            // 
            // lastUpdatedTextBox
            // 
            this.lastUpdatedTextBox.Location = new System.Drawing.Point(100, 155);
            this.lastUpdatedTextBox.Name = "lastUpdatedTextBox";
            this.lastUpdatedTextBox.ReadOnly = true;
            this.lastUpdatedTextBox.Size = new System.Drawing.Size(180, 20);
            this.lastUpdatedTextBox.TabIndex = 11;
            // 
            // ChannelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lastUpdatedTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.channelIDTextBox);
            this.Controls.Add(this.folderComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lastUpdatedLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.channelIDLabel);
            this.Controls.Add(this.folderLabel);
            this.Name = "ChannelDialog";
            this.Text = "Channel Properties";
            this.Load += new System.EventHandler(this.ChannelDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Label channelIDLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label lastUpdatedLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.TextBox channelIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox lastUpdatedTextBox;
    }
}