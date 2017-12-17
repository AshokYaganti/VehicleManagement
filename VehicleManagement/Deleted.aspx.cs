using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
public partial class Deleted : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAL obj = new DAL();
        string username = Convert.ToString(Session["username"]);
        DataSet ds = new DataSet();
        ds.Clear();
        ds = obj.getdeletedInventory();
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
                    sb.Append((dr["vin"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["make"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["model"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["year"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["type"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    if ((dr["type"]).ToString() == "Used Car")
                    {
                        sb.Append((dr["milage"]));
                    }
                    else
                    {
                        sb.Append("N/A");
                    }
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["price"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["status"]));
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append((dr["posted_date"]).ToString());
                    sb.Append("</td>");
                    sb.Append("<td align='center'>");
                    sb.Append("<a href='#' class='btn btn-success btn-xs viewcls' data-toggle='modal' data-target='#viewModel' style='text-decoration:none'>View</a>");
                    sb.Append("</td>");                   
                    sb.Append("<td hidden='true'>");
                    sb.Append(dr["inventoryid"]);
                    sb.Append("</td>");
                    sb.Append("</tr>");

                }

        ltData.Text = sb.ToString();
    }
}