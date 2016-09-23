using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lotto : System.Web.UI.Page
{
    string type = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlType.Items.Add("Suomi");
            ddlType.Items.Add("VikingLotto"); 
        }
    }

    protected void btnDraw_Click(object sender, EventArgs e)
    {
        JAMK.IT.IIO11300.Lotto lotto = new JAMK.IT.IIO11300.Lotto(ddlType.SelectedItem.Text);
        try
        {
            int lines = int.Parse(txtLines.Text);
            lblOutput.Text = lotto.DrawNumbers(lines);
        }
        catch (Exception ex)
        {
            lblOutput.Text = ex.Message;
        }
    }
}