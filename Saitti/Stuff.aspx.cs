using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Stuff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvStuff_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = gvStuff.SelectedIndex;
        string name = gvStuff.Rows[i].Cells[1].Text;
        string stuff = gvStuff.Rows[i].Cells[2].Text;
        myStuff.Text = string.Format("{0} {1}", name, stuff);
        dvStuff.PageIndex = i;
    }
}