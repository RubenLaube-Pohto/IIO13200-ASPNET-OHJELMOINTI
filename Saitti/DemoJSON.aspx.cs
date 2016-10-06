using JAMK.IT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoJSON : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet_Click(object sender, EventArgs e)
    {
        // get json and display it in the ui
        try
        {
            ltResult.Text = GetJSONFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP");
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    protected void btnGetPerson_Click(object sender, EventArgs e)
    {
        // convert json into an object
        try
        {
            string json = GetJSONFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP");
            Person p = JsonConvert.DeserializeObject<Person>(json);
            ltResult.Text = string.Format("Löytyi henkilö {0} ja syntynyt {1}", p.Name, p.Birthday);
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    protected void btnGetPoliticians_Click(object sender, EventArgs e)
    {
        // convert json to a collection of objects
        try
        {
            string json = GetJSONFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
            List<Politician> hallitus = JsonConvert.DeserializeObject<List<Politician>>(json);
            string ret = "<h2>Suomen vankka hallitus</h2><ul>";
            foreach (Politician ministeri in hallitus)
            {
                ret += "<li>" + ministeri.Name + ", " + ministeri.Party + "</li>";
            }
            ret += "</ul>";
            ltResult.Text = ret;
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    private string GetJSONFrom(string url)
    {
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }
}