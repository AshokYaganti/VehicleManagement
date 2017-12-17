using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Web.Services;
public partial class AdminHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAL obj = new DAL();
        string username = Convert.ToString(Session["username"]);
        DataSet ds = new DataSet();
        ds.Clear();
        ds = obj.getAllInventory();
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
                    if ((dr["status"]).ToString() == "OPEN")
                    {
                        sb.Append("<a href='#' class='btn btn-primary btn-xs approvecls' data-toggle='modal' data-target='#approveModal' style='text-decoration:none'>Approve/Decline</a>");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                    sb.Append("<td align='center'>");
                    sb.Append("<a href='AdminInventoryView.aspx?id=" + dr["inventoryid"] + "'' class='btn btn-primary btn-xs viewcls' style='text-decoration:none'>View</a>");
                    sb.Append("</td>"); 
                   
                    sb.Append("<td align='center'>");
                    if ((dr["status"]).ToString() != "SOLD")
                    {
                        sb.Append("<a href='#' class='btn btn-warning btn-xs updatecls' data-toggle='modal' data-target='#updateModel' style='text-decoration:none'>Update</a>");
                    }
                    else
                    {
                        sb.Append("");
                    }
                    sb.Append("</td>");
                    sb.Append("<td align='center'>");
                    if ((dr["status"]).ToString() != "SOLD")
                    {
                        sb.Append("<a href='#' class='btn btn-danger btn-xs deleteecls' data-toggle='modal' data-target='#deleteModal' style='text-decoration:none'>Delete</a>");
                    }
                    else
                    {
                        sb.Append("");
                    }
                    sb.Append("</td>");                         
                    sb.Append("<td hidden='true'>");
                    sb.Append(dr["inventoryid"]);
                    sb.Append("</td>");
                    sb.Append("</tr>");

                }

        ltData.Text = sb.ToString();
    }

    [WebMethod]
    public static string updateInventory(string price, string inventoryid)
    {
        DAL obj = new DAL();
        int result = obj.updateInventory(price, inventoryid);
        string msg = string.Empty;
        if (result > 0)
        {
            msg = "success";

        }
        else
        {
            msg = "failure";
        }
        return msg;
    }

    [WebMethod]
    public static string deleteInventory(string iid)
    {
        DAL obj = new DAL();
        int result = obj.deleteInventory(iid);
        string msg = string.Empty;
        if (result > 0)
        {
            msg = "success";

        }
        else
        {
            msg = "failure";
        }
        return msg;
    }

    [WebMethod]
    public static string approveInventory(string status, string inventoryid)
    {
        DAL obj = new DAL();
        int result = obj.approveInventory(status, inventoryid);
        string msg = string.Empty;
        if (result > 0)
        {
            msg = "success";

        }
        else
        {
            msg = "failure";
        }
        return msg;
    }
}