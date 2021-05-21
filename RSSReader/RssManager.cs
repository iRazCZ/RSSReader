using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader
{
    class NewsItem
    {
        private string _title;
        private string _link;
        private string _description;

        public string Title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }

        public string Link
        {
            set
            {
                _link = value;
            }
            get
            {
                return _link;
            }
        }

        public string Description
        {
            set
            {
                _description = value;
            }
            get
            {
                return _description;
            }
        }

    }

    class RssManager
    {
        public static System.Collections.ArrayList ProcessNewsFeed(string url)
        {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(url);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            System.IO.Stream rssStream = myResponse.GetResponseStream();

            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
            rssDoc.Load(rssStream);

            System.Xml.XmlNodeList rssList = rssDoc.SelectNodes("rss/channel/item");

            //string title = "";
            //string link = "";
            //string description = "";

            System.Collections.ArrayList returnArrayList = new System.Collections.ArrayList();

            for (int i = 0; i < rssList.Count; i++)
            {
                System.Xml.XmlNode rssNode;

                NewsItem tempNewsItem = new NewsItem();

                rssNode = rssList.Item(i).SelectSingleNode("title");
                if (rssNode != null)
                    tempNewsItem.Title = rssNode.InnerText;
                else
                    tempNewsItem.Title = "";

                rssNode = rssList.Item(i).SelectSingleNode("link");
                if (rssNode != null)
                    tempNewsItem.Link = rssNode.InnerText;
                else
                    tempNewsItem.Link = "";

                rssNode = rssList.Item(i).SelectSingleNode("description");
                if (rssNode != null)
                    tempNewsItem.Description = rssNode.InnerText;
                else
                    tempNewsItem.Description = "";

                returnArrayList.Add(tempNewsItem);
            }

            return returnArrayList;

        }

    }
}
