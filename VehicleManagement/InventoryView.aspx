<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InventoryView.aspx.cs" Inherits="InventoryView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" Runat="Server">

 <form id="Form123" class="form-horizontal" runat="server">
    <div class="ibox-title">
        <h5>
            <strong>Inventory Information</strong></h5>
    </div>
    <div class="ibox-content">
        <div class="form-group">
            <label class="col-md-3 control-label">
                Car Type:</label>
            <div class="col-md-5">
                <asp:Label ID="cartype" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                VIN:</label>
            <div class="col-md-5">
                <asp:Label ID="vin" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Make:</label>
            <div class="col-md-5">
                <asp:Label ID="make" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Model:</label>
            <div class="col-md-5">
                <asp:Label ID="model" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Year:</label>
            <div class="col-md-5">
                <asp:Label ID="year" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Mileage:</label>
            <div class="col-md-5">
                <asp:Label ID="milage" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Price:</label>
            <div class="col-md-5">
                <asp:Label ID="price" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Posted Date:</label>
            <div class="col-md-5">
                <asp:Label ID="posteddate" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Description:</label>
            <div class="col-md-5">
                <asp:Label ID="description" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
    </div>   
    <div class="ibox-title">
        <h5>
            <strong>Car Images</strong></h5>
    </div>
    <div class="ibox-content">
        <div class="form-group">
            <asp:Image ID="Image1" class="col-md-3" runat="server" ImageUrl='<%# "~/Handler.ashx?ID=" + Eval("imageid")%>'/>
            <asp:Image ID="Image2" runat="server" class="col-md-3" ImageUrl='<%# "~/Handler.ashx?ID=" + Eval("imageid")%>'/>
            <asp:Image ID="Image3" runat="server" class="col-md-3" ImageUrl='<%# "~/Handler.ashx?ID=" + Eval("imageid")%>'/>
            <asp:Image ID="Image4" runat="server" class="col-md-3" ImageUrl='<%# "~/Handler.ashx?ID=" + Eval("imageid")%>'/>
            <asp:Label ID="Noimage" class="control-label" runat="server" Text="No Image Found" Visible="false"></asp:Label>
        </div>
    </div>
  
    <div class="ibox-title">
        <h5>
            <strong>Customer Comments</strong></h5>
    </div>
   <div id="comments" runat="server"></div>
    </form>

</asp:Content>

