using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class FolderDialog : Form
    {
        private Label folderIDLabel;
        private Label folderNameLabel;
        private Button okButton;
        private Button cancelButton;
        private TextBox folderNameTextBox;
        private TextBox folderIDTextBox;

        private int folderID = 0;
        private string folderName = "";

        public int FolderID
        {
            set
            {
                folderID = value;
            }
            get
            {
                return folderID;
            }
        }

        public string FolderName
        {
            set
            {
                folderName = value;
            }
            get
            {
                return folderName;
            }
        }

        public FolderDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.folderIDLabel = new System.Windows.Forms.Label();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.folderIDTextBox = new System.Windows.Forms.TextBox();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderIDLabel
            // 
            this.folderIDLabel.AutoSize = true;
            this.folderIDLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderIDLabel.Location = new System.Drawing.Point(13, 28);
            this.folderIDLabel.Name = "folderIDLabel";
            this.folderIDLabel.Size = new System.Drawing.Size(74, 16);
            this.folderIDLabel.TabIndex = 4;
            this.folderIDLabel.Text = "Folder ID :";
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.folderNameLabel.Location = new System.Drawing.Point(13, 82);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(98, 16);
            this.folderNameLabel.TabIndex = 4;
            this.folderNameLabel.Text = "Folder Name :";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(48, 185);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(158, 185);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // folderIDTextBox
            // 
            this.folderIDTextBox.Location = new System.Drawing.Point(123, 27);
            this.folderIDTextBox.Name = "folderIDTextBox";
            this.folderIDTextBox.ReadOnly = true;
            this.folderIDTextBox.Size = new System.Drawing.Size(157, 20);
            this.folderIDTextBox.TabIndex = 3;
            this.folderIDTextBox.TextChanged += new System.EventHandler(this.folderIDTextBox_TextChanged);
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(123, 81);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.folderNameTextBox.TabIndex = 0;
            this.folderNameTextBox.TextChanged += new System.EventHandler(this.folderNameTextBox_TextChanged);
            // 
            // FolderDialog
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.folderIDTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.folderNameLabel);
            this.Controls.Add(this.folderIDLabel);
            this.Name = "FolderDialog";
            this.Text = "Folder Properties";
            this.Load += new System.EventHandler(this.FolderDialog_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            folderName = folderNameTextBox.Text;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FolderDialog_Load_1(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            folderIDTextBox.Text = folderID.ToString();
            folderNameTextBox.Text = folderName;
        }

        private void folderIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}