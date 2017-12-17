<%@ WebHandler Language="C#" Class="Handler2" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
public class Handler2 : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        if (context.Request.QueryString["imageid2"] != null)
        {

            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["vehicleConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select photo from carimages where imageid=@imageid", con);
            cmd.Parameters.AddWithValue("@imageid", context.Request.QueryString["imageid2"].ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            context.Response.BinaryWrite((byte[])dr["photo"]);
            dr.Close();
            con.Close();
        }
        else
        {
            context.Response.Write("No Image Found");
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}