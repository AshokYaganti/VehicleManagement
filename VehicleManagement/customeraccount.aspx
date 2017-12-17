<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true"
    CodeFile="customeraccount.aspx.cs" Inherits="customeraccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" runat="Server">
    <div class="ibox-title">
        <h5>
            <strong>My Account</strong></h5>
        <div class="ibox-content">
            <form id="Form1" class="form-horizontal" runat="server">
            <div class="form-group">
                <label class="col-md-3 control-label">
                    Name</label>
                <div class="col-md-5">
                    <asp:TextBox ID="name" runat="server" class="form-control col-md-3" disabled="disabled"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-md-3 control-label">
                    Username</label>
                <div class="col-md-5">
                    <asp:TextBox ID="username" runat="server" class="form-control col-md-3" disabled="disabled"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-md-3 control-label">
                    Email</label>
                <div class="col-md-5">
                    <asp:TextBox ID="email" runat="server" class="form-control col-md-3"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-md-3 control-label">
                    Phone</label>
                <div class="col-md-5">
                    <asp:TextBox ID="phone" runat="server" class="form-control col-md-3"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-md-3 control-label">
                    Address</label>
                <div class="col-md-5">
                    <asp:TextBox ID="address" runat="server" class="form-control col-md-3" disabled="disabled"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
             <label class="col-md-3 control-label">
                    State</label>
                <div class="col-md-5">
                    <asp:TextBox ID="state" runat="server" class="form-control col-md-3" disabled="disabled"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-md-3 control-label">
                    City</label>
                <div class="col-md-5">
                    <asp:TextBox ID="city" runat="server" class="form-control col-md-3" disabled="disabled"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-md-3 control-label">
                    ZIP</label>
                <div class="col-md-5">
                    <asp:TextBox ID="zip" runat="server" class="form-control col-md-3" disabled="disabled"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-4 col-sm-offset-3">
                    <asp:Button ID="submitbtn" class="btn btn-sm btn-success" runat="server" Text="Update"
                        OnClick="Button1_Click" />
                </div>
            </div>
            </form>
        </div>
    </div>
</asp:Content>
