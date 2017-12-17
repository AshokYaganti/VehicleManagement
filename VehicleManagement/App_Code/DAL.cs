using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["vehicleConnection"].ConnectionString);
    DataSet ds = new DataSet();

    public DataSet getUsename()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_username", con);
        cmd.CommandText = "sp_username";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public int registrationDetails(string dname, string username, string password, string emailid, string phone,string address, string state, string city, string zip,string role)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("sp_registrations", con);
        cmd.CommandText = "sp_registrations";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@rid", SqlDbType.Int).Direction = ParameterDirection.Output;
        cmd.Parameters.AddWithValue("@name", dname);       
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        cmd.Parameters.AddWithValue("@email", emailid);       
        cmd.Parameters.AddWithValue("@phone", phone);       
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@state", state);
        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@zip", zip);
        cmd.Parameters.AddWithValue("@role", role);  
        cmd.ExecuteNonQuery();
        string rid = cmd.Parameters["@rid"].Value.ToString();
        int rid1 = Convert.ToInt32(rid);
        con.Close();
        return rid1;

    }

    public DataSet getLoginDetails(string username)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_logindetails", con);
        cmd.CommandText = "sp_logindetails";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

  
    public DataSet getMake()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getmake", con);
        cmd.CommandText = "sp_getmake";
        cmd.CommandType = CommandType.StoredProcedure;       
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }
    public DataSet getModels(string makeid)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getModels", con);
        cmd.CommandText = "sp_getModels";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@makeid", makeid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public int addInventory(string username,string type, string make, string model, string year, string vin, string milage, string price, string description)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("sp_addinventory", con);
        cmd.CommandText = "sp_addinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@inventoryid", SqlDbType.Int).Direction = ParameterDirection.Output;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@type", type);
        cmd.Parameters.AddWithValue("@make", make);
        cmd.Parameters.AddWithValue("@model", model);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.Parameters.AddWithValue("@vin", vin);       
        cmd.Parameters.AddWithValue("@milage", milage);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@description", description);       
        cmd.ExecuteNonQuery();
        string inventoryid = cmd.Parameters["@inventoryid"].Value.ToString();
        int inventoryid1 = Convert.ToInt32(inventoryid);
        con.Close();
        return inventoryid1;

    }

    public DataSet getInventory(string username)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getinventory", con);
        cmd.CommandText = "sp_getinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public int updateInventory(string price, string inventoryid)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_updateinventory", con);
        cmd.CommandText = "sp_updateinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);       
        int result=cmd.ExecuteNonQuery();      
        con.Close();
        return result;
    }
    public int deleteInventory(string inventoryid)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_delteinventory", con);
        cmd.CommandText = "sp_delteinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        return result;
    }

    public DataSet getAllInventory()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getallinventory", con);
        cmd.CommandText = "sp_getallinventory";
        cmd.CommandType = CommandType.StoredProcedure;        
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public DataSet getdeletedInventory()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getdeletedinventory", con);
        cmd.CommandText = "sp_getdeletedinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }
    public int changePassword(string username,string password)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_changpassword", con);
        cmd.CommandText = "sp_changpassword";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        return result;
    }
    public DataSet registeredUsers()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_registeredusers", con);
        cmd.CommandText = "sp_registeredusers";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public int approveInventory(string status,string inventoryid)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_approveinventory", con);
        cmd.CommandText = "sp_approveinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@status", status);
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        return result;
    }
    public DataSet searchInventory(string inventorytype,string make,string model)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_searchinventory", con);
        cmd.CommandText = "sp_searchinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@inventorytype", inventorytype);
        cmd.Parameters.AddWithValue("@make", make);
        cmd.Parameters.AddWithValue("@model", model);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public DataSet getMoreInventory(string inventoryid)
    {
         con.Open();
        SqlCommand cmd = new SqlCommand("sp_getmoreinventory", con);
        cmd.CommandText = "sp_getmoreinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);       
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public int bookmark(string username, string inventoryid)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_bookmarks", con);
        cmd.CommandText = "sp_bookmarks";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        return result;
    }

    public int salesPersonContact(string username, string inventoryid,string comment)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_salespersoncontact", con);
        cmd.CommandText = "sp_salespersoncontact";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
        cmd.Parameters.AddWithValue("@comment", comment);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        return result;
    }

    public DataSet getbookmarkinventorycount(string username,string inventoryid)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_bookmarkcount", con);
        cmd.CommandText = "sp_bookmarkcount";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public DataSet myAccount(string username)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_myaccount", con);
        cmd.CommandText = "sp_myaccount";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);       
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public int updateAccount(string username, string emailid, string phone)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_updateaccount", con);
        cmd.CommandText = "sp_updateaccount";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@emailid", emailid);
        cmd.Parameters.AddWithValue("@phone", phone);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        return result;
    }

    public DataSet getBookmarkInventory(string username)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getBookmarkInventory", con);
        cmd.CommandText = "sp_getBookmarkInventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@customerid", username);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public DataSet getCustomerComments(string inventoryid)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getComments", con);
        cmd.CommandText = "sp_getComments";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }
    public int sellInventory(string inventoryid)
    {
         con.Open();
        SqlCommand cmd = new SqlCommand("sp_sellinventory", con);
        cmd.CommandText = "sp_sellinventory";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@inventoryid", inventoryid);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        return result;
    }

    public DataSet getSoldnventory()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_soldInventory", con);
        cmd.CommandText = "sp_soldInventory";
        cmd.CommandType = CommandType.StoredProcedure;        
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        return ds;
    }
}