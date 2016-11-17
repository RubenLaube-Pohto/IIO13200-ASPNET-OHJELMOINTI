using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ValidateRequest : System.Web.UI.Page
{
  //http://stackoverflow.com/questions/502112/handling-request-validation-silently
  //TODO ylikirjoita ProcessRequest
  protected void Page_Load(object sender, EventArgs e)
  {
    try
    {

    }
    catch (Exception ex)
    {
      ltMessage.Text = ex.Message;  
    }
  }

  protected void btnCommit_Click(object sender, EventArgs e)
  {
    try
    {
      //TODO kirjoitetaan kommentti XML:ään
    }
    catch (Exception ex)
    {
      ltMessage.Text = ex.Message;
    }
  }
}