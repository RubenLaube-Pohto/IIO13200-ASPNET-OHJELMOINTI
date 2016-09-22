using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Target : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string msg = "";

        // Case 1: Query string
        msg += Request.QueryString["Message"] + "<br/>";

        foreach (string key in Request.QueryString)
        {
            msg += "Query string key: " + key + ", value: " + Request.QueryString[key] + "<br/>";
        }


        // Case 2: Session
        msg += "From session: " + Session["Message"] + "<br/>";

        // Case 3: Cookie
        msg += "From cookie: ";
        foreach (string kex in Request.Cookies)
        {
            if (kex == "Message")
            {
                msg += Request.Cookies[kex].Value + "<br/>";
            }
        }

        // Case 4: Property
        // read property of previous page
        msg += "From Property: ";
        var previousPage = PreviousPage;
        if (previousPage != null)
        {
            msg += previousPage.SecretMessage;
        }

        // display msg
        myText.InnerHtml = msg;
    }
}