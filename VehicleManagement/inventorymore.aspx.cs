using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class inventorymore : System.Web.UI.Page
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
        name.Text = name1;
        email.Text = email1;
        phone.Text = phone1;
        displayImages();

        DataSet ds1 = obj.getbookmarkinventorycount(username,inventoryid);
    
        if (ds1.Tables[0].Rows.Count > 0)
        {
            string count = ds.Tables[0].Rows[0]["bcount"].ToString();
            if (count != "0")
            {
                Button1.Visible = false;
                Label1.Visible = true;
            }
            else
            {
                Label1.Visible = false;
                Button1.Visible = true;                
            }
        }       
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        string username = Convert.ToString(Session["username"]);
        DAL obj = new DAL();
        int res = obj.bookmark(username,inventoryid);

        if (res > 0)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your have successfully bookmarked this car.');window.location='CustomerHome.aspx';", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Something went wrong with this request. Please try agin later.')</script>", false);
            Response.Redirect(ResolveUrl("CustomerHome.aspx"));
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = Convert.ToString(Session["username"]);
        string comment = Request["comment"];
        DAL obj = new DAL();
        int res = obj.salesPersonContact(username, inventoryid,comment);

        if (res > 0)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('We have received your request. You will get a call from sales person soon.');window.location='CustomerHome.aspx';", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Something went wrong with this request. Please try agin later.')</script>", false);
            Response.Redirect(ResolveUrl("CustomerHome.aspx"));
        }
    }
}