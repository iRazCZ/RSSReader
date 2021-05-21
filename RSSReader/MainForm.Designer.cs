namespace RSSReader
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
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addFolderToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.editFolderToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteFolderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.editChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshRSSFeed = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.FolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssDataSet = new RSSReader.rssDataSet();
            this.channelsListBox = new System.Windows.Forms.ListBox();
            this.ChannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newsItemsListBox = new System.Windows.Forms.ListBox();
            this.NewsItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.datePosted = new System.Windows.Forms.TextBox();
            this.folderTableAdapter = new RSSReader.rssDataSetTableAdapters.FolderTableAdapter();
            this.channelTableAdapter = new RSSReader.rssDataSetTableAdapters.ChannelTableAdapter();
            this.newsItemTableAdapter = new RSSReader.rssDataSetTableAdapters.NewsItemTableAdapter();
            this.expandLabel = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(795, 33);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(795, 57);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolstripButton,
            this.editFolderToolstripButton,
            this.deleteFolderToolStripButton,
            this.toolStripSeparator1,
            this.addChannelToolstripButton,
            this.editChannelToolstripButton,
            this.deleteChannelToolstripButton,
            this.toolStripSeparator2,
            this.refreshRSSFeed});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(795, 33);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip";
            // 
            // addFolderToolstripButton
            // 
            this.addFolderToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addFolderToolstripButton.Image = global::RSSReader.Properties.Resources.folder_add;
            this.addFolderToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFolderToolstripButton.Name = "addFolderToolstripButton";
            this.addFolderToolstripButton.Size = new System.Drawing.Size(23, 30);
            this.addFolderToolstripButton.Text = "New Folder";
            this.addFolderToolstripButton.Click += new System.EventHandler(this.addFolderToolstripButton_Click);
            // 
            // editFolderToolstripButton
            // 
            this.editFolderToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editFolderToolstripButton.Image = global::RSSReader.Properties.Resources.folder_edit;
            this.editFolderToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editFolderToolstripButton.Name = "editFolderToolstripButton";
            this.editFolderToolstripButton.Size = new System.Drawing.Size(23, 30);
            this.editFolderToolstripButton.Text = "Edit Folder";
            this.editFolderToolstripButton.Click += new System.EventHandler(this.editFolderToolstripButton_Click);
            // 
            // deleteFolderToolStripButton
            // 
            this.deleteFolderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteFolderToolStripButton.Image = global::RSSReader.Properties.Resources.folder_delete;
            this.deleteFolderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteFolderToolStripButton.Name = "deleteFolderToolStripButton";
            this.deleteFolderToolStripButton.Size = new System.Drawing.Size(23, 30);
            this.deleteFolderToolStripButton.Text = "Delete Folder";
            this.deleteFolderToolStripButton.Click += new System.EventHandler(this.deleteFolderToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // addChannelToolstripButton
            // 
            this.addChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addChannelToolstripButton.Image = global::RSSReader.Properties.Resources.channel_new;
            this.addChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addChannelToolstripButton.Name = "addChannelToolstripButton";
            this.addChannelToolstripButton.Size = new System.Drawing.Size(23, 30);
            this.addChannelToolstripButton.Text = "Add Channel";
            this.addChannelToolstripButton.Click += new System.EventHandler(this.addChannelToolstripButton_Click);
            // 
            // editChannelToolstripButton
            // 
            this.editChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editChannelToolstripButton.Image = global::RSSReader.Properties.Resources.channel_edit;
            this.editChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editChannelToolstripButton.Name = "editChannelToolstripButton";
            this.editChannelToolstripButton.Size = new System.Drawing.Size(23, 30);
            this.editChannelToolstripButton.Text = "Edit Channel";
            this.editChannelToolstripButton.Click += new System.EventHandler(this.editChannelToolstripButton_Click);
            // 
            // deleteChannelToolstripButton
            // 
            this.deleteChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteChannelToolstripButton.Image = global::RSSReader.Properties.Resources.channel_delete;
            this.deleteChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteChannelToolstripButton.Name = "deleteChannelToolstripButton";
            this.deleteChannelToolstripButton.Size = new System.Drawing.Size(23, 30);
            this.deleteChannelToolstripButton.Text = "Delete Channel";
            this.deleteChannelToolstripButton.Click += new System.EventHandler(this.deleteChannelToolstripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // refreshRSSFeed
            // 
            this.refreshRSSFeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshRSSFeed.Image = global::RSSReader.Properties.Resources.rss;
            this.refreshRSSFeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshRSSFeed.Name = "refreshRSSFeed";
            this.refreshRSSFeed.Size = new System.Drawing.Size(23, 30);
            this.refreshRSSFeed.Text = "Refresh RSS Feed";
            this.refreshRSSFeed.Click += new System.EventHandler(this.refreshRSSFeed_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(795, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.newChannelToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // newChannelToolStripMenuItem
            // 
            this.newChannelToolStripMenuItem.Name = "newChannelToolStripMenuItem";
            this.newChannelToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newChannelToolStripMenuItem.Text = "New Channel";
            this.newChannelToolStripMenuItem.Click += new System.EventHandler(this.newChannelToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(103, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indexToolStripMenuItem.Text = "Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 544);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(792, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folder :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Channels :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(62, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "News Items :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(346, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(346, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(346, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date Posted :";
            // 
            // folderComboBox
            // 
            this.folderComboBox.DataSource = this.FolderBindingSource;
            this.folderComboBox.DisplayMember = "FolderName";
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(65, 111);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(206, 21);
            this.folderComboBox.TabIndex = 0;
            this.folderComboBox.ValueMember = "FolderID";
            this.folderComboBox.SelectedIndexChanged += new System.EventHandler(this.folderComboBox_SelectedIndexChanged_1);
            // 
            // FolderBindingSource
            // 
            this.FolderBindingSource.DataMember = "Folder";
            this.FolderBindingSource.DataSource = this.rssDataSet;
            // 
            // rssDataSet
            // 
            this.rssDataSet.DataSetName = "rssDataSet";
            this.rssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // channelsListBox
            // 
            this.channelsListBox.DataSource = this.ChannelBindingSource;
            this.channelsListBox.DisplayMember = "Title";
            this.channelsListBox.FormattingEnabled = true;
            this.channelsListBox.Location = new System.Drawing.Point(65, 174);
            this.channelsListBox.Name = "channelsListBox";
            this.channelsListBox.Size = new System.Drawing.Size(206, 121);
            this.channelsListBox.TabIndex = 1;
            this.channelsListBox.ValueMember = "ChannelID";
            this.channelsListBox.SelectedIndexChanged += new System.EventHandler(this.channelsListBox_SelectedIndexChanged_1);
            // 
            // ChannelBindingSource
            // 
            this.ChannelBindingSource.DataMember = "Channel";
            this.ChannelBindingSource.DataSource = this.rssDataSet;
            this.ChannelBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // newsItemsListBox
            // 
            this.newsItemsListBox.DataSource = this.NewsItemBindingSource;
            this.newsItemsListBox.DisplayMember = "Title";
            this.newsItemsListBox.FormattingEnabled = true;
            this.newsItemsListBox.Location = new System.Drawing.Point(65, 339);
            this.newsItemsListBox.Name = "newsItemsListBox";
            this.newsItemsListBox.Size = new System.Drawing.Size(206, 186);
            this.newsItemsListBox.TabIndex = 2;
            this.newsItemsListBox.ValueMember = "NewsItemID";
            this.newsItemsListBox.SelectedIndexChanged += new System.EventHandler(this.newsItemsListBox_SelectedIndexChanged_1);
            // 
            // NewsItemBindingSource
            // 
            this.NewsItemBindingSource.DataMember = "NewsItem";
            this.NewsItemBindingSource.DataSource = this.rssDataSet;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NewsItemBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(349, 111);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(390, 20);
            this.titleTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NewsItemBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(349, 174);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(390, 53);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // webBrowser
            // 
            this.webBrowser.DataBindings.Add(new System.Windows.Forms.Binding("Url", this.NewsItemBindingSource, "Link", true));
            this.webBrowser.Location = new System.Drawing.Point(349, 273);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(390, 252);
            this.webBrowser.TabIndex = 7;
            // 
            // datePosted
            // 
            this.datePosted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NewsItemBindingSource, "DateAcquired", true));
            this.datePosted.Location = new System.Drawing.Point(454, 239);
            this.datePosted.Name = "datePosted";
            this.datePosted.Size = new System.Drawing.Size(158, 20);
            this.datePosted.TabIndex = 5;
            // 
            // folderTableAdapter
            // 
            this.folderTableAdapter.ClearBeforeFill = true;
            // 
            // channelTableAdapter
            // 
            this.channelTableAdapter.ClearBeforeFill = true;
            // 
            // newsItemTableAdapter
            // 
            this.newsItemTableAdapter.ClearBeforeFill = true;
            // 
            // expandLabel
            // 
            this.expandLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.NewsItemBindingSource, "Link", true));
            this.expandLabel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandLabel.ForeColor = System.Drawing.Color.Blue;
            this.expandLabel.Location = new System.Drawing.Point(655, 240);
            this.expandLabel.Name = "expandLabel";
            this.expandLabel.Size = new System.Drawing.Size(61, 19);
            this.expandLabel.TabIndex = 12;
            this.expandLabel.Text = "Expand";
            this.expandLabel.Click += new System.EventHandler(this.expandLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.expandLabel);
            this.Controls.Add(this.datePosted);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.newsItemsListBox);
            this.Controls.Add(this.channelsListBox);
            this.Controls.Add(this.folderComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "RSS Reader v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addFolderToolstripButton;
        private System.Windows.Forms.ToolStripButton editFolderToolstripButton;
        private System.Windows.Forms.ToolStripButton deleteFolderToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addChannelToolstripButton;
        private System.Windows.Forms.ToolStripButton editChannelToolstripButton;
        private System.Windows.Forms.ToolStripButton deleteChannelToolstripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton refreshRSSFeed;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.ListBox channelsListBox;
        private System.Windows.Forms.ListBox newsItemsListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox datePosted;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private rssDataSet rssDataSet;
        private System.Windows.Forms.BindingSource FolderBindingSource;
        private RSSReader.rssDataSetTableAdapters.FolderTableAdapter folderTableAdapter;
        private System.Windows.Forms.BindingSource ChannelBindingSource;
        private RSSReader.rssDataSetTableAdapters.ChannelTableAdapter channelTableAdapter;
        private System.Windows.Forms.BindingSource NewsItemBindingSource;
        private RSSReader.rssDataSetTableAdapters.NewsItemTableAdapter newsItemTableAdapter;
        private System.Windows.Forms.Label expandLabel;
    }
}

