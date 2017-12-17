using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
public partial class RegisteredUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAL obj = new DAL();
        DataSet ds = obj.registeredUsers();
        StringBuilder sb = new StringBuilder();
        DataTable dt = new DataTable();
        dt.Clear();
        dt = ds.Tables[0];
        if (dt != null)
            if (dt.Rows.Count > 0)
                foreach (DataRow dr in dt.Rows)
                {

                    sb.Append("<tr>");
                    sb.Append("<td>");
                    sb.Append((dr["dname"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["username"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["email"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["phone"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["address"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["state"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["city"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["zip"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["role"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["created_date"]));
                    sb.Append("</td>");                 
                    sb.Append("</tr>");

                }

        ltData.Text = sb.ToString();
    }
}