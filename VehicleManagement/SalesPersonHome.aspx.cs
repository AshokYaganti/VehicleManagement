using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

public partial class SalesPersonHome : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["vehicleConnection"].ConnectionString);
    SqlCommand cmd;
    byte[] raw;
    List<string> images = new List<string>();
    string filename = string.Empty;
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
            DropDownList1.Items.Insert(0, new ListItem("", "0"));
        }
    }   
    protected void Button1_Click(object sender, EventArgs e)
    {
        filename = image1.PostedFile.FileName;

        if (filename != "")
        {
            string fileLocation = Path.GetFileName(image1.PostedFile.FileName);
            image1.PostedFile.SaveAs(Server.MapPath("~/cimages/") + fileLocation);
            images.Add(fileLocation);
        }

        filename = image2.PostedFile.FileName;
        if (filename != "")
        {
            string fileLocation = Path.GetFileName(image2.PostedFile.FileName);
            image2.PostedFile.SaveAs(Server.MapPath("~/cimages/") + fileLocation);
            images.Add(fileLocation);
        }

        filename = image3.PostedFile.FileName;
        if (filename != "")
        {
            string fileLocation = Path.GetFileName(image3.PostedFile.FileName);
            image3.PostedFile.SaveAs(Server.MapPath("~/cimages/") + fileLocation);
            images.Add(fileLocation);
        }


        filename = image4.PostedFile.FileName;
        if (filename != "")
        {
            string fileLocation = Path.GetFileName(image4.PostedFile.FileName);
            image4.PostedFile.SaveAs(Server.MapPath("~/cimages/") + fileLocation);
            images.Add(fileLocation);
        }

        DAL obj1 = new DAL();      

        string inventorytype = DropDownList3.SelectedValue;
        string make = DropDownList1.SelectedValue;
        string model = DropDownList2.SelectedValue;
        string year = Request["year"];
        string vin = Request["vin"];
        string milage = string.Empty;
        if (inventorytype == "USED")
        {
            milage = Request["milage"];
        }
        else
        {
            milage = "N/A";
        }
        string price = Request["price"];      
        string description = Request["description"];
        string username = Convert.ToString(Session["username"]);

        if (inventorytype == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select inventory type' )</script>", false);

        }
        else if (make == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select car make' )</script>", false);

        }
        else if (model == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select car model' )</script>", false);

        }
        else if (year.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please enter user name' )</script>", false);

        }

        else if (vin.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('please enter Password' )</script>", false);

        }

        else if (milage.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('please enter confirm password' )</script>", false);

        }
        else if (price.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('please enter confirm password' )</script>", false);

        }
        else if (description.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please enter street address' )</script>", false);
        }       
        else
        {
            int res = obj1.addInventory(username,inventorytype, make, model, year, vin, milage, price, description);
            if (res > 0)
            {
                uploadImage(res);
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Something went wrong with this request. Please try agin later.')</script>", false);
                Response.Redirect(ResolveUrl("SalesPersonHome.aspx"));
            }

        }
      
    }

    public void uploadImage(int id)
    {
        try
        {
            foreach (var i in images)
            {
               
                FileStream fs = new FileStream(Server.MapPath("~/cimages/") + i, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
                raw = new byte[fs.Length];
                fs.Read(raw, 0, Convert.ToInt32(fs.Length));
                cmd = new SqlCommand("sp_carimages", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@imageid", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@inventoryid", id);
                cmd.Parameters.AddWithValue("@photo", raw);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your new inventory request request has been created successfully');window.location='SalesPersonHome.aspx';", true);
                }
                else
                {
                    string script = "<script>alert('Request has been created but Something went wrong while uploading images')</script>";
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Error", script);
                }
            }
        }

        catch (Exception e1)
        {
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
        DropDownList2.Items.Insert(0, new ListItem("", "0"));
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList3.SelectedValue == "USED")
        {
            mile.Visible = true;
        }
        else
        {
            mile.Visible = false;
        }
    }
}