<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true"
    CodeFile="inventorymore.aspx.cs" Inherits="inventorymore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" runat="Server">
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
            <strong>Sales Person Details</strong>
        </h5>
    </div>
    <div class="ibox-content">       
        <div class="form-group">
            <label class="col-md-3 control-label">
                Name:</label>
            <div class="col-md-5">
                <asp:Label ID="name" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Email Addess:</label>
            <div class="col-md-5">
                <asp:Label ID="email" class="control-label" runat="server"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <label class="col-md-3 control-label">
                Phone:</label>
            <div class="col-md-5">
                <asp:Label ID="phone" class="control-label" runat="server"></asp:Label>
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
  
    <div class="ibox-content">
        <div class="form-group">
            <label class="col-md-3 control-label">
                Do you want to bookmark this car?</label>
            <div class="col-md-5">
                <asp:Button ID="Button1" class="btn btn-sm btn-success" Visible="false" runat="server" Text="Bookmark"
                    OnClick="Button2_Click" />
                     <asp:Label ID="Label1" runat="server" Visible="false" Text="Already bookmarked"></asp:Label>
            </div>
        </div>
    </div>
    <div class="ibox-title">
        <h5>
            <strong>Contact Sales Person</strong></h5>
    </div>
    <div class="ibox-content">
        <div class="form-group">
            <label class="col-md-3 control-label">
                Comment:</label>
            <div class="col-md-5">
                <textarea name="comment" id="comment" style="resize: none;" class="form-control col-md-3 resize"
                    rows="4"></textarea>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-4 col-sm-offset-3">
                <asp:Button ID="submitbtn" class="btn btn-sm btn-success" runat="server" Text="Submit"
                    OnClick="Button1_Click" />             
            </div>
        </div>
    </div>
    </form>
</asp:Content>
