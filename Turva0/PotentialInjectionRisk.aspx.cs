using System;
using MySql.Data.MySqlClient; // for mysql
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PotentialInjectionRisk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
    }

    protected void btnCommit_Click(object sender, EventArgs e)
    {
        BadWriteToDatabase(); // direct sql
        //GoodWriteToDatabase(); // using parameters
    }

    private void BadWriteToDatabase()
    {
        string name = txtName.Text;
        string comment = txtComment.Text;
        string date = txtDate.Text;

        string sql = string.Format(
            "INSERT INTO comment (name, comment, date) VALUES ('{0}', '{1}', '{2}');",
            name, comment, date);

        try
        {
            MySqlConnection conn = new MySqlConnection(myComments.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();
            lblMessages.Text = string.Format("Added {0} comments successfully to database", i);
            gvComments.DataBind();
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }

    private void GoodWriteToDatabase()
    {
        string name = txtName.Text;
        string comment = txtComment.Text;
        string date = txtDate.Text;

        string sql = "INSERT INTO comment (name, comment, date) VALUES (@name, @comment, @date);";

        try
        {
            MySqlConnection conn = new MySqlConnection(myComments.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@comment", comment);
            cmd.Parameters.AddWithValue("@date", date);
            int i = cmd.ExecuteNonQuery();
            lblMessages.Text = string.Format("Added {0} comments successfully to database", i);
            gvComments.DataBind();
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}