<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="CustomerHome.aspx.cs" Inherits="CustomerHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" Runat="Server">
<div class="ibox-title">
        <h5>
            <strong>Search Inventory</strong></h5>
           
          <div class="ibox-content">
             <form id="Form1" class="form-horizontal" runat="server">
                  <div class="form-group">
                    <label class="col-md-3 control-label">Inventory Type</label>
                    <div class="col-md-5">                        
                        <asp:DropDownList ID="DropDownList3" runat="server" ClientIDMode="Static" 
                            name="DropDownList3" runat="server" class="form-control col-md-3">
                         <asp:ListItem Text="" Value=""></asp:ListItem>
                         <asp:ListItem Text="New Inventory" Value="NEW"></asp:ListItem>
                         <asp:ListItem Text="Used Inventory" Value="USED"></asp:ListItem>
                        </asp:DropDownList>                        
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-3 control-label">Make</label>
                    <div class="col-md-5">                        
                        <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" ClientIDMode="Static" 
                            name="DropDownList1" runat="server" class="form-control col-md-3" 
                            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>                        
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-3 control-label">Model</label>
                    <div class="col-md-5">                        
                        <asp:DropDownList ID="DropDownList2" runat="server" ClientIDMode="Static" name="DropDownList2" runat="server" class="form-control col-md-3">
                        </asp:DropDownList>                        
                    </div>
                </div>                
                 <div class="form-group">
                    <div class="col-sm-4 col-sm-offset-3">
                        <asp:Button ID="submitbtn" class="btn btn-sm btn-success" runat="server" 
                            Text="Search" onclick="Button1_Click" />                   
                    </div>
                </div>
            </form>        
        </div>
    </div>  

    <div id="inventory" runat="server"></div>

</asp:Content>

