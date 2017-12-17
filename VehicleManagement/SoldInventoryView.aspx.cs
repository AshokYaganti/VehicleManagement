using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
public partial class SoldInventoryView : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["vehicleConnection"].ConnectionString);
    string inventoryid = string.Empty;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        DAL obj = new DAL();
        inventoryid = Request.QueryString["id"];
        string username = Convert.ToString(Session["username"]);
        DataSet ds = new DataSet();
        ds.Clear();
        ds = obj.getMoreInventory(inventoryid);
        string cartype1 = string.Empty;
        string vin1 = string.Empty;
        string make1 = string.Empty;
        string model1 = string.Empty;
        string year1 = string.Empty;
        string milage1 = string.Empty;
        string price1 = string.Empty;
        string posteddate1 = string.Empty;
        string description1 = string.Empty;
        string name1 = string.Empty;
        string email1 = string.Empty;
        string phone1 = string.Empty;
        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            cartype1 = ds.Tables[0].Rows[0]["type"].ToString();
            vin1 = ds.Tables[0].Rows[0]["vin"].ToString();
            make1 = ds.Tables[0].Rows[0]["make"].ToString();
            model1 = ds.Tables[0].Rows[0]["model"].ToString();
            year1 = ds.Tables[0].Rows[0]["year"].ToString();
            milage1 = ds.Tables[0].Rows[0]["milage"].ToString();
            price1 = ds.Tables[0].Rows[0]["price"].ToString();
            posteddate1 = ds.Tables[0].Rows[0]["posted_date"].ToString();
            description1 = ds.Tables[0].Rows[0]["description"].ToString();
            name1 = ds.Tables[0].Rows[0]["dname"].ToString();
            email1 = ds.Tables[0].Rows[0]["email"].ToString();
            phone1 = ds.Tables[0].Rows[0]["phone"].ToString();
        }

        cartype.Text = cartype1;
        vin.Text = vin1;
        make.Text = make1;
        model.Text = model1;
        year.Text = year1;
        milage.Text = milage1;
        price.Text = price1;
        posteddate.Text = posteddate1;
        description.Text = description1;
        displayImages();
        customercomments();

    }
    public void displayImages()
    {
        try
        {
            DataSet ds1 = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getimages", con);
            cmd.CommandText = "sp_getimages";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1);
            int i;
            if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
            {
                for (i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        Image1.ImageUrl = "~/Handler.ashx?imageid=" + ds1.Tables[0].Rows[i]["imageid"];
                    }
                    if (i == 1)
                    {
                        Image2.ImageUrl = "~/Handler.ashx?imageid=" + ds1.Tables[0].Rows[i]["imageid"];
                    }
                    if (i == 2)
                    {
                        Image3.ImageUrl = "~/Handler.ashx?imageid=" + ds1.Tables[0].Rows[i]["imageid"];
                    }
                    if (i == 3)
                    {
                        Image4.ImageUrl = "~/Handler.ashx?imageid=" + ds1.Tables[0].Rows[i]["imageid"];
                    }


                }
            }
            if (ds1.Tables[0].Rows.Count == 0)
            {
                Image1.Visible = false;
                Image2.Visible = false;
                Image3.Visible = false;
                Image4.Visible = false;
                Noimage.Visible = true;

            }
            if (ds1.Tables[0].Rows.Count == 1)
            {
                Image2.Visible = false;
                Image3.Visible = false;
                Image4.Visible = false;
            }
            if (ds1.Tables[0].Rows.Count == 2)
            {
                Image3.Visible = false;
                Image4.Visible = false;
            }
            if (ds1.Tables[0].Rows.Count == 3)
            {
                Image3.Visible = false;
            }

            con.Close();
        }
        catch (Exception e1)
        {
        }

    }

    public void customercomments()
    {
        DAL obj2 = new DAL();
        DataSet ds12 = obj2.getCustomerComments(inventoryid);
        StringBuilder sb = new StringBuilder();
        DataTable dt = new DataTable();
        dt.Clear();
        dt = ds12.Tables[0];
        if (dt != null)
            if (dt.Rows.Count > 0)
                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("<div class='ibox-content'>" +
                              "<form id='Form123' class='form-horizontal' runat='server'>" +
                                "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Name:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["dname"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                 "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Phone:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["phone"] + "</label>" +
                                   "</div>" +
                                 "</div>" + "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Email:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["email"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                 "<div class='form-group'>" +
                                  "<label class='col-md-3 control-label'>Comment:</label>" +
                                    "<div class='col-md-5'>" +
                                      "<label class='control-label'>" + dr["Comment"] + "</label>" +
                                   "</div>" +
                                 "</div>" +
                                 "</form>" +
                               "</div>");
                }
        comments.InnerHtml = sb.ToString();

    }   
}