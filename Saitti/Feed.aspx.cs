using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Feed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetFeed_Click(object sender, EventArgs e)
    {
        // set xmldatasource to yle uutiset rss feed
        string url = @"http://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss";
        myDataSource.DataFile = url;
        GetFeeds();
    }

    private void GetFeeds()
    {
        try
        {
            // using xmldocument class and it's methods and properties
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            // first get channel info
            XmlNode node1 = doc.SelectSingleNode("/rss/channel");
            string title = node1["title"].InnerText;
            feedContent.InnerHtml = string.Format("<h1>{0} {1}</h1>", title, DateTime.Now.ToString());
            // second get all item elements and loop through them
            XmlNodeList nodes = doc.SelectNodes("/rss/channel/item");
            string category;
            string link;
            string piclink;
            foreach (XmlNode node in nodes)
            {
                // get image url if it exists
                if (node["enclosure"] != null)
                {
                    piclink = node["enclosure"].GetAttribute("url");
                } else
                {
                    piclink = ".\\Images\\nope.png";
                }
                feedContent.InnerHtml += string.Format("<img src='{0}' style='height: 50px; width: auto;'>", piclink);
                // title, link and category are read from element
                category = node["category"].InnerText;
                link = node["link"].InnerText;
                title = node["title"].InnerText;
                feedContent.InnerHtml += string.Format("{0} <a href='{1}'>{2}</a>", category, link, title);
                feedContent.InnerHtml += "<br>";
            }
        }
        catch (Exception e)
        {
            feedContent.InnerHtml = e.Message;
        }
    }

    protected void btnGetFeedWired_Click(object sender, EventArgs e)
    {
        string url = @"http://feeds.wired.com/wired/index";
        myDataSource.DataFile = url;
        GetFeeds();
    }
}