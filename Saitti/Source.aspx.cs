using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Source : System.Web.UI.Page
{
    public string SecretMessage
    {
        get { return txtMessage.Text; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // initialize controls etc
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("Hello");
            ddlMessages.Items.Add("Ping?");
            ddlMessages.Items.Add("Handshake?");
            ddlMessages.Items.Add("Goodbye!");
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        // we will use standard redirection with Redirect
        Response.Redirect("/Target.aspx?User=Ruben&Message=" + txtMessage.Text);
    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        // write to session and redirect to another page
        Session["Message"] = txtMessage.Text;
        Response.Redirect("/Target.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        // create cookie and write message into it
        HttpCookie cookie = new HttpCookie("Message", txtMessage.Text);
        cookie.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(cookie);
    }

    protected void btnPublicProperty_Click(object sender, EventArgs e)
    {
        Server.Transfer("Target.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessage.Text = ddlMessages.SelectedItem.ToString();
    }
}