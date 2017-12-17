<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SalesPersonHome.aspx.cs" Inherits="SalesPersonHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" Runat="Server">

<div class="ibox-title">
        <h5>
            <strong>Add Inventory</strong></h5>
           
          <div class="ibox-content">
             <form id="Form1" class="form-horizontal" runat="server">
                  <div class="form-group">
                    <label class="col-md-3 control-label">Inventory Type</label>
                    <div class="col-md-5">                        
                        <asp:DropDownList ID="DropDownList3" AutoPostBack="true" runat="server" ClientIDMode="Static" 
                            name="DropDownList3" runat="server" class="form-control col-md-3" 
                            onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                         <asp:ListItem Text="" Value="0"></asp:ListItem>
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
                    <label class="col-md-3 control-label">Year</label>
                    <div class="col-md-5">                        
                         <input type="number" name="year" id="year" class="form-control col-md-3">                       
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-3 control-label">VIN</label>
                    <div class="col-md-5">
                        <input type="text" name="vin" id="vin" class="form-control col-md-3">                       
                    </div>
                </div> 
                 <div class="form-group" visible="false" runat="server" id="mile">
                    <label class="col-md-3 control-label">Milage</label>
                    <div class="col-md-5">
                        <input type="number" name="Milage" id="Milage" class="form-control col-md-3">                      
                    </div>
                </div>            
                <div class="form-group">
                    <label class="col-md-3 control-label">Price ($)</label>
                    <div class="col-md-5">
                        <input type="number" name="price" id="price" class="form-control col-md-3">                      
                    </div>
                </div> 
                 <div class="form-group">
                    <label class="col-md-3 control-label">Description</label>
                    <div class="col-md-5">
                        <textarea name="description" id="description" style="resize: none;" class="form-control col-md-3 resize" rows="3"></textarea>                      
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-3 control-label">Upload Image1</label>
                    <div class="col-md-5">
                       <input type="file" id="image1" runat="server" class="form-control"/>
                    </div>                    
                </div> 
                 <div class="form-group">
                    <label class="col-md-3 control-label">Upload Image2</label>
                    <div class="col-md-5">
                       <input type="file"  runat="server" id="image2" class="form-control"/>
                    </div>                    
                </div>   
                 <div class="form-group">
                    <label class="col-md-3 control-label">Upload Image3</label>
                    <div class="col-md-5">
                       <input type="file" id="image3" runat="server" class="form-control"/>
                    </div>                     
                </div>   
                 <div class="form-group">
                    <label class="col-md-3 control-label">Upload Image4</label>
                    <div class="col-md-5">
                       <input type="file" id="image4" runat="server" class="form-control"/>
                    </div>                     
                </div> 
                 <div class="form-group">
                    <div class="col-sm-4 col-sm-offset-3">
                        <asp:Button ID="submitbtn" class="btn btn-sm btn-success" runat="server" 
                            Text="Submit" onclick="Button1_Click" />                   
                    </div>
                </div>
            </form>        
        </div>
    </div>  
 
</asp:Content>

