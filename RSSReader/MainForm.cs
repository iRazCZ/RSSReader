using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.folderTableAdapter.Fill(this.rssDataSet.Folder);

            refreshChannels();
            refreshNewsItems();

        }

        private void refreshChannels()
        {
            if (this.rssDataSet.Channel.Rows.Count == 0)
                this.channelTableAdapter.Fill(this.rssDataSet.Channel);

            if (folderComboBox.SelectedValue != null)
                this.ChannelBindingSource.Filter = "FolderID = " + folderComboBox.SelectedValue;
        }

        private void refreshNewsItems()
        {

            if (this.rssDataSet.NewsItem.Rows.Count == 0)
                this.newsItemTableAdapter.Fill(this.rssDataSet.NewsItem);

            if (channelsListBox.SelectedValue != null)
                this.NewsItemBindingSource.Filter = "ChannelID = " + channelsListBox.SelectedValue.ToString();
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFolder();
        }

        private void newChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addChannel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently no help contents available. Sorry for this inconvenience.",
                            "Contents",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Index not available. Sorry for this inconvenience.",
                            "Index",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
        }


        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search operation cannot be peroformed. Sorry for this inconvenience.",
                            "Search",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Name : RSS Reader v1.0.0.0\nDeveloped by A. Rameez Raza\nDeveloper E-Mail ID : rameez_osx@yahoo.com.au",
                            "About",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void addFolderToolstripButton_Click(object sender, EventArgs e)
        {
            addFolder();
        }

        private void editFolderToolstripButton_Click(object sender, EventArgs e)
        {
            editFolder();
        }

        private void deleteFolderToolStripButton_Click(object sender, EventArgs e)
        {
            deleteFolder();
        }

        private void addChannelToolstripButton_Click(object sender, EventArgs e)
        {
            addChannel();
        }

        private void editChannelToolstripButton_Click(object sender, EventArgs e)
        {
            editChannel();
        }

        private void deleteChannelToolstripButton_Click(object sender, EventArgs e)
        {
            deleteChannel();
        }

        private void addFolder()
        {
            statusLabel.Text = "Creating New Folder ...";
            FolderDialog myFolderDialog = new FolderDialog();
            myFolderDialog.FolderID = 0;
            myFolderDialog.FolderName = "";

            DialogResult result = myFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    rssDataSet.FolderRow folder = rssDataSet.Folder.NewFolderRow();
                    folder.FolderName = myFolderDialog.FolderName;

                    rssDataSet.Folder.AddFolderRow(folder);

                    int rowsAffected = folderTableAdapter.Update(folder);

                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "New Folder Created - '" + myFolderDialog.FolderName + "'";
                    }
                    else
                    {
                        statusLabel.Text = "Problem creating new folder.  Could not save into the database.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem creating new folder : " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "New folder operation cancelled.";
            }

            myFolderDialog = null;
        }

        private void editFolder()
        {
            statusLabel.Text = "Editing folder ...";

            FolderDialog myFolderDialog = new FolderDialog();

            int folderID = (int)folderComboBox.SelectedValue;

            rssDataSet.FolderRow folder = rssDataSet.Folder.FindByFolderID(folderID);

            myFolderDialog.FolderID = folderID;
            myFolderDialog.FolderName = folder.FolderName;

            DialogResult result = myFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    folder.BeginEdit();
                    folder.FolderName = myFolderDialog.FolderName;
                    folder.EndEdit();

                    int rowsAffected = folderTableAdapter.Update(folder);

                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "Folder edited successfully : '" + folder.FolderName + "'";
                    }
                    else
                    {
                        statusLabel.Text = "Problem updating folder.  Could not save into the database.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem editing folder : " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "Edit folder operation cancelled.";
            }

            myFolderDialog = null;
        }

        private void deleteFolder()
        {
            statusLabel.Text = "Deleting folder ...";

            DialogResult result = MessageBox.Show("Are you sure you want to delete the current Folder? " +
            "Doing so will also delete all the Channels and Messages contained in that foler.",
            "Delete Folder?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2,
            MessageBoxOptions.DefaultDesktopOnly,
            false);

            if (result == DialogResult.Yes)
            {
                try
                {
                int folderID = (int)folderComboBox.SelectedValue;
                deleteChannels(folderID);

                rssDataSet.FolderRow folder = rssDataSet.Folder.FindByFolderID(folderID);
                folder.Delete();

                int rowsAffected = folderTableAdapter.Update(rssDataSet);

                if (rowsAffected > 0)
                {
                    statusLabel.Text = "Folder successfully deleted.";
                }
                else
                {
                    statusLabel.Text = "Problem deleting Folder.";
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem when deleting folder :" + ex.Message);
                }

            }
            else
            {
                statusLabel.Text = "Delete folder operation cancelled.";
            }
        }

        private void addChannel()
        {
            statusLabel.Text = "Creating new Channel ...";

            ChannelDialog myChannelDialog = new ChannelDialog();

            myChannelDialog.DataSource = rssDataSet;
            myChannelDialog.ChannelID = 0;
            myChannelDialog.FolderID = (int)folderComboBox.SelectedValue;

            DialogResult result = myChannelDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    int rowsAffected = channelTableAdapter.Update(rssDataSet);

                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "New channel successfully created.";
                    }
                    else
                    {
                        statusLabel.Text = "Problem creating new channel.";
                    }

                    queryChannels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem creating channel :" + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "New channel operation cancelled.";
            }

            myChannelDialog = null;
        }

        private void editChannel()
        {
            statusLabel.Text = "Editing channel ...";

            ChannelDialog myChannelDialog = new ChannelDialog();

            myChannelDialog.DataSource = rssDataSet;
            myChannelDialog.ChannelID = (int)channelsListBox.SelectedValue;
            myChannelDialog.FolderID = (int)folderComboBox.SelectedValue;

            DialogResult result = myChannelDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                int rowsAffected = channelTableAdapter.Update(rssDataSet);

                if (rowsAffected > 0)
                {
                    statusLabel.Text = "Channel updated successfully.";
                }
                else
                {
                    statusLabel.Text = "Problem updating channel.";
                }

                queryChannels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem updating channel : " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "Edit channel operation cancelled.";
            }

            myChannelDialog = null;
        }

        private void deleteChannel()
        {
            statusLabel.Text = "Deleting channel ...";

            DialogResult result = MessageBox.Show("Are you sure you want to delete the current Channel? " +
            "Doing so will also delete all the News Items for that Channel.",
            "Delete Folder?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2,
            MessageBoxOptions.DefaultDesktopOnly,
            false);

            if (result == DialogResult.Yes)
            {
                try
                {
                int channelID = (int)channelsListBox.SelectedValue;
                deleteNewsItems(channelID);

                rssDataSet.ChannelRow channel = rssDataSet.Channel.FindByChannelID(channelID);
                channel.Delete();

                int rowsAffected = channelTableAdapter.Update(rssDataSet);

                if (rowsAffected > 0)
                {
                    statusLabel.Text = "Channel deleted successfully.";
                }
                else
                {
                    statusLabel.Text = "Problem deleting channel.";
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem deleting channel: " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "Delete channel operation cancelled.";
            }
        }

        private void deleteChannels(int folderID)
        {
            try
            {
            rssDataSet.ChannelRow[] channels = (rssDataSet.ChannelRow[])rssDataSet.Channel.Select("FolderID = " + folderID.ToString());

            foreach (rssDataSet.ChannelRow channel in channels)
            {
                int channelID = channel.ChannelID;
                deleteNewsItems(channelID);
                channel.Delete();
            }

            int rowsAffected = channelTableAdapter.Update(rssDataSet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void deleteNewsItems(int channelID)
        {
            try
            {
            rssDataSet.NewsItemRow[] newsItems = (rssDataSet.NewsItemRow[])rssDataSet.NewsItem.Select("ChannelID = " + channelID.ToString());

            if (newsItems.Length == 0)
                return;

            foreach (rssDataSet.NewsItemRow newsItem in newsItems)
                newsItem.Delete();

            int rowsAffected = newsItemTableAdapter.Update(rssDataSet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void refreshRSSFeed_Click(object sender, EventArgs e)
        {
            try
            {
                queryChannels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem updating RSS Feeds : " + ex.Message);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void channelsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            refreshNewsItems();
        }

        private void folderComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            refreshChannels();
            refreshNewsItems();
        }

        private void newsItemsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.newsItemsListBox.SelectedIndex != -1)
                this.NewsItemBindingSource.Position = this.newsItemsListBox.SelectedIndex;
        }

        private void queryChannels()
        {
            statusLabel.Text = "Updating RSS Feeds ...";

            progressBar.Maximum = rssDataSet.Channel.Rows.Count;
            progressBar.Value = 0;

            try
            {
            foreach (rssDataSet.ChannelRow currentChannel in rssDataSet.Channel.Rows)
            {
                System.Collections.ArrayList result = new System.Collections.ArrayList();
                result = RssManager.ProcessNewsFeed(currentChannel.URL);

                foreach (RSSReader.NewsItem currentNewsItem in result)
                {
                    string title = currentNewsItem.Title;

                    if (title.Length >= 50)
                        title.Substring(0, 49);

                    title.Replace("'", "");

                    string filterExpression = "Title = '" + title + "'";
                    System.Data.DataRow[] filteredNewsItems = rssDataSet.NewsItem.Select(filterExpression);

                    if (filteredNewsItems.Length == 0)
                    {
                        rssDataSet.NewsItemRow newRow = rssDataSet.NewsItem.NewNewsItemRow();
                        newRow.Title = currentNewsItem.Title;
                        newRow.Description = currentNewsItem.Description;
                        newRow.Link = currentNewsItem.Link;
                        newRow.ChannelID = currentChannel.ChannelID;
                        newRow.DateAcquired = DateTime.Now;

                        rssDataSet.NewsItem.AddNewsItemRow(newRow);
                    }
                }
                progressBar.Value++;
           }

            int rowsAffected = newsItemTableAdapter.Update(rssDataSet);

            if (rowsAffected > 0)
            {
                statusLabel.Text = "RSS Feeds updated successfully.  " + rowsAffected.ToString() + " NewsItems were added.";
            }
            else
            {
                statusLabel.Text = "RSS Feeds updated successfully.  No NewsItems were added.";
            }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                progressBar.Value = 0;
            }
        }

        private void expandLabel_Click(object sender, EventArgs e)
        {
            if (expandLabel.Tag.ToString().Length == 0)
                return;
            try
            {
                System.Diagnostics.Process.Start("IExplore", expandLabel.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not launch the link in Internet Explorer.",
                                "An error has occurred",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
