using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class WorkersXML : System.Web.UI.Page
{
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        XmlDocument doc = new XmlDocument();
        doc = Xml1.Document;
        XmlNodeList palkat = doc.SelectNodes("/tyontekijat/tyontekija[tyosuhde='vakituinen']/palkka");
        lblMsg.Text = "Vakituisten määrä: " + palkat.Count.ToString();
        int sum = 0;
        foreach (XmlNode palkka in palkat)
        {
            sum += int.Parse(palkka.InnerText);
        }
        lblMsg.Text += ", Vakituisten yhteen laskettu palkka: " + sum;
    }
}