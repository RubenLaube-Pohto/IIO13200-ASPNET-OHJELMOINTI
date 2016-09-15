using System;
using System.Data; // ado.net data classes
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class GetStudentsEvening : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet3_Click(object sender, EventArgs e)
    {
        // get precreated data and bind to control
        DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
        gvStudents.DataSource = dt;
        gvStudents.DataBind();
    }

    protected void btnGetAll_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
        string msg = "";
        try
        {
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetAllStudentsFromSQLServer(cs, "oppilaat", out msg);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
            lblMessage.Text = msg;
        }
        catch (Exception ex)
        {
            // where to display the exception message?
            lblMessage.Text = ex.Message;
        }
    }
}