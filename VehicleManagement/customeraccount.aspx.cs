using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
public partial class customeraccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAL obj = new DAL();
        string username1 = Convert.ToString(Session["username"]);
        DataSet ds = obj.myAccount(username1);
        if (!IsPostBack)
        {
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                name.Text = ds.Tables[0].Rows[0]["dname"].ToString();
                username.Text = ds.Tables[0].Rows[0]["username"].ToString();
                email.Text = ds.Tables[0].Rows[0]["email"].ToString();
                phone.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                address.Text = ds.Tables[0].Rows[0]["address"].ToString();
                state.Text = ds.Tables[0].Rows[0]["state"].ToString();
                city.Text = ds.Tables[0].Rows[0]["city"].ToString();
                zip.Text = ds.Tables[0].Rows[0]["zip"].ToString();
            }
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DAL obj1 = new DAL();
        DataSet ds = new DataSet();
        string username = Convert.ToString(Session["username"]);

        string emailid = email.Text;
        string phonenum = phone.Text;       

        var regexItem = new Regex("^[0-9 ]*$");
      
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(emailid);

        if (emailid.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please enter email address' )</script>", false);
        }
        else if (!(match.Success))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Email address was not in correct format' )</script>", false);
        }
        else if (phonenum.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please enter phone number' )</script>", false);
        }
        else if (!(regexItem.IsMatch(phonenum)))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Phone number should be numeric' )</script>", false);
        }     

        else
        {
            int res = obj1.updateAccount(username, emailid, phonenum);
            if (res > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your account has been updated.');window.location='customeraccount.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Something went wrong with this request. Please try agin later.')</script>", false);
                Response.Redirect(ResolveUrl("customeraccount.aspx"));
            }

        }
    }
}