using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
public partial class CustomerHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DAL obj = new DAL();
            DataSet ds = obj.getMake();
            DropDownList1.DataSource = ds.Tables[0];
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("", ""));
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        DAL obj = new DAL();
        DataSet ds = obj.getModels(DropDownList1.SelectedValue);
        DropDownList2.DataSource = ds.Tables[0];
        DropDownList2.DataTextField = "name";
        DropDownList2.DataValueField = "id";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, new ListItem("", ""));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DAL obj1 = new DAL();
        string inventorytype = DropDownList3.SelectedValue;
        string make = DropDownList1.SelectedValue;
        string model = DropDownList2.SelectedValue;
        DataSet ds = obj1.searchInventory(inventorytype, make, model);
        StringBuilder sb = new StringBuilder();
        DataTable dt = new DataTable();
        dt.Clear();
        dt = ds.Tables[0];
        if (dt != null)
            if (dt.Rows.Count > 0)
                sb.Append("<div class='ibox-title'><h5><strong>Search Results</strong></h5></div>");
                foreach (DataRow dr in dt.Rows)
                {                    
                    sb.Append("<div class='ibox-content'>"+ 
                              "<form id='Form123' class='form-horizontal' runat='server'>"+     
                                "<div class='form-group'>"+
                                  "<label class='col-md-3 control-label'>Car Type:</label>"+
                                    "<div class='col-md-5'>"+
                                      "<label class='control-label'>" + dr["type"] + "</label>"+
                                   "</div>"+
                                 "</div>"+
                                 "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>VIN:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["vin"] + "</label>" +
                                   "</div>" +
                                 "</div>" + "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Make:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["make"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                 "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Model:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["model"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                 "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Year:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["year"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                 "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Mileage:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["milage"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                  "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Price:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["price"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                  "<div class='form-group'>"+
                                    "<div class='col-sm-4 col-sm-offset-3'>"+
                                      "<a href='inventorymore.aspx?id="+ dr["inventoryid"] +"' class='btn btn-sm btn-success'>More Information</a>" +                   
                                   "</div>"+
                                 "</div>"+
                                 "</form>"+
                               "</div>");                    
                }
        inventory.InnerHtml = sb.ToString();

    }
}