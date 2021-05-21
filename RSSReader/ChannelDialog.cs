using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class ChannelDialog : Form
    {
        private Label folderLabel;
        private Label channelIDLabel;
        private Label titleLabel;
        private Label urlLabel;
        private Label lastUpdatedLabel;
        private TextBox channelIDTextBox;
        private TextBox titleTextBox;
        private TextBox urlTextBox;
        private TextBox lastUpdatedTextBox;
        private Button cancelButton;
        private ComboBox folderComboBox;
        private Button okButton;

        private int channelID;
        private rssDataSet rssDataSet;
        private BindingSource FolderBindingSource;
        private IContainer components;
        private BindingSource ChannelBindingSource;
        private RSSReader.rssDataSetTableAdapters.FolderTableAdapter folderTableAdapter;
        private RSSReader.rssDataSetTableAdapters.ChannelTableAdapter channelTableAdapter;
        private int folderID;

        public rssDataSet DataSource
        {
            get { return this.rssDataSet; }
            set { this.rssDataSet = value; }
        }

        public int ChannelID
        {
            get { return channelID; }
            set { channelID = value; }
        }

        public int FolderID
        {
            get { return folderID; }
            set { folderID = value; }
        }
    
        public ChannelDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.channelIDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.lastUpdatedLabel = new System.Windows.Forms.Label();
            this.channelIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.lastUpdatedTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.rssDataSet = new RSSReader.rssDataSet();
            this.FolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderTableAdapter = new RSSReader.rssDataSetTableAdapters.FolderTableAdapter();
            this.channelTableAdapter = new RSSReader.rssDataSetTableAdapters.ChannelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLabel.Location = new System.Drawing.Point(42, 37);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(57, 16);
            this.folderLabel.TabIndex = 7;
            this.folderLabel.Text = "Folder :";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(103, 291);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // channelIDLabel
            // 
            this.channelIDLabel.AutoSize = true;
            this.channelIDLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.channelIDLabel.Location = new System.Drawing.Point(42, 88);
            this.channelIDLabel.Name = "channelIDLabel";
            this.channelIDLabel.Size = new System.Drawing.Size(86, 16);
            this.channelIDLabel.TabIndex = 7;
            this.channelIDLabel.Text = "Channel ID :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(42, 136);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(44, 16);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title :";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.urlLabel.Location = new System.Drawing.Point(42, 184);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(42, 16);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "URL :";
            // 
            // lastUpdatedLabel
            // 
            this.lastUpdatedLabel.AutoSize = true;
            this.lastUpdatedLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastUpdatedLabel.Location = new System.Drawing.Point(42, 234);
            this.lastUpdatedLabel.Name = "lastUpdatedLabel";
            this.lastUpdatedLabel.Size = new System.Drawing.Size(99, 16);
            this.lastUpdatedLabel.TabIndex = 7;
            this.lastUpdatedLabel.Text = "Last Updated :";
            // 
            // channelIDTextBox
            // 
            this.channelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChannelBindingSource, "ChannelID", true));
            this.channelIDTextBox.Location = new System.Drawing.Point(157, 85);
            this.channelIDTextBox.Name = "channelIDTextBox";
            this.channelIDTextBox.ReadOnly = true;
            this.channelIDTextBox.Size = new System.Drawing.Size(189, 20);
            this.channelIDTextBox.TabIndex = 5;
            this.channelIDTextBox.TextChanged += new System.EventHandler(this.channelIDTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChannelBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(157, 133);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(189, 20);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChannelBindingSource, "URL", true));
            this.urlTextBox.Location = new System.Drawing.Point(157, 181);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(189, 20);
            this.urlTextBox.TabIndex = 2;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // lastUpdatedTextBox
            // 
            this.lastUpdatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChannelBindingSource, "LastUpdated", true));
            this.lastUpdatedTextBox.Location = new System.Drawing.Point(157, 231);
            this.lastUpdatedTextBox.Name = "lastUpdatedTextBox";
            this.lastUpdatedTextBox.ReadOnly = true;
            this.lastUpdatedTextBox.Size = new System.Drawing.Size(189, 20);
            this.lastUpdatedTextBox.TabIndex = 6;
            this.lastUpdatedTextBox.TextChanged += new System.EventHandler(this.lastUpdatedTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(220, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // folderComboBox
            // 
            this.folderComboBox.DataSource = this.FolderBindingSource;
            this.folderComboBox.DisplayMember = "FolderName";
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(157, 36);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(189, 21);
            this.folderComboBox.TabIndex = 0;
            this.folderComboBox.ValueMember = "FolderID";
            this.folderComboBox.SelectedIndexChanged += new System.EventHandler(this.folderComboBox_SelectedIndexChanged);
            // 
            // rssDataSet
            // 
            this.rssDataSet.DataSetName = "rssDataSet";
            this.rssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FolderBindingSource
            // 
            this.FolderBindingSource.DataMember = "Folder";
            this.FolderBindingSource.DataSource = this.rssDataSet;
            // 
            // ChannelBindingSource
            // 
            this.ChannelBindingSource.DataMember = "Channel";
            this.ChannelBindingSource.DataSource = this.rssDataSet;
            // 
            // folderTableAdapter
            // 
            this.folderTableAdapter.ClearBeforeFill = true;
            // 
            // channelTableAdapter
            // 
            this.channelTableAdapter.ClearBeforeFill = true;
            // 
            // ChannelDialog
            // 
            this.ClientSize = new System.Drawing.Size(392, 366);
            this.Controls.Add(this.folderComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lastUpdatedTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.channelIDTextBox);
            this.Controls.Add(this.lastUpdatedLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.channelIDLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.folderLabel);
            this.Name = "ChannelDialog";
            this.Text = "Channel Properties";
            this.Load += new System.EventHandler(this.ChannelDialog_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void folderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void channelIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastUpdatedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (channelID == 0)
            {
                rssDataSet.ChannelRow channel = rssDataSet.Channel.NewChannelRow();

                channel.FolderID = int.Parse(folderComboBox.SelectedValue.ToString());
                channel.Title = titleTextBox.Text;
                channel.URL = urlTextBox.Text;
                channel.LastUpdated = DateTime.Now;

                rssDataSet.Channel.AddChannelRow(channel);
            }
            else
            {
                rssDataSet.ChannelRow channel = rssDataSet.Channel.FindByChannelID(channelID);

                channel.BeginEdit();
                channel.FolderID = int.Parse(folderComboBox.SelectedValue.ToString());
                channel.Title = titleTextBox.Text;
                channel.URL = urlTextBox.Text;
                channel.LastUpdated = DateTime.Parse(lastUpdatedTextBox.Text);
                channel.EndEdit();
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChannelDialog_Load_1(object sender, EventArgs e)
        {

            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            FolderBindingSource.DataSource = rssDataSet;
            FolderBindingSource.DataMember = "Folder";
            FolderBindingSource.ResetBindings(true);

            folderComboBox.SelectedValue = folderID;

            if (channelID > 0)
            {
                ChannelBindingSource.DataSource = rssDataSet;
                ChannelBindingSource.DataMember = "Channel";
                ChannelBindingSource.Filter = "ChannelID = " + channelID.ToString();
                ChannelBindingSource.ResetBindings(true);
            }
        }

    }
}