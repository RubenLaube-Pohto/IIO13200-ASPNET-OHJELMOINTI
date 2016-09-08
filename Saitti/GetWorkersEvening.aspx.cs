using System;
using System.Configuration; // for using web.config
using System.Collections.Generic;
using System.Data; // for ADO.NET classes
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetWorkersEvening : System.Web.UI.Page
{
    string xmlFile;

    protected void Page_Load(object sender, EventArgs e)
    {
        // read xml filename from web.config
        xmlFile = ConfigurationManager.AppSettings["tiedosto"];
        lblMsg.Text = xmlFile;
    }

    protected void btnGet_Click(object sender, EventArgs e)
    {
        // read workers from xml file and display them in the gridview

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        ds.ReadXml(Server.MapPath(xmlFile));
        dt = ds.Tables[0];
        dv = dt.DefaultView;

        // bind data to ui control
        gvData.DataSource = dv;
        gvData.DataBind();

        lblMsg.Text = String.Format("Found {0} workers", dt.Rows.Count);
    }
}