using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {        
        DAL obj1 = new DAL();
        string username = Convert.ToString(Session["username"]);
        string password = Request["password"];
        string cpassword = Request["cpassword"];
        bool pass = password.Equals(cpassword);
        if (password.Length==0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please enter new password' )</script>", false);

        }
        else if (password.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please enter confirm password' )</script>", false);

        }
        else if (pass.Equals(false))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please check confirm password' )</script>", false);

        }
        else
        {
            int res = obj1.changePassword(username,password);
            if (res > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your password has been changed successfully');window.location='ChangePassword.aspx';", true); 
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Something went wrong with this request. Please try agin later.')</script>", false);
                Response.Redirect(ResolveUrl("ChangePassword.aspx"));
            }
        }
    }  
}