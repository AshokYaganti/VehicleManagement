using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["loggedin"] != "Yes")
        {
            Response.Redirect("LoginPage.aspx");
        }
        else
        {                       
            name.InnerText = Convert.ToString(Session["name"]);
        }
    }
}
