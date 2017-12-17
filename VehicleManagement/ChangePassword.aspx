<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true"
    CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" runat="Server">
    <div class="ibox-title">
        <h5>
            <strong>Change Password</strong>
        </h5>
    </div>
    <div class="ibox-content">
        <form id="Form1" class="form-horizontal" runat="server">
        <div class="form-group">
            <label class="col-md-3 control-label">
                New Password</label>
            <div class="col-md-5">
                <input type="password" name="password" id="password" class="form-control col-md-3">
            </div>
        </div>
        <div class="form-group" runat="server" id="mile">
            <label class="col-md-3 control-label">
                Confirm Password</label>
            <div class="col-md-5">
                <input type="password" name="cpassword" id="cpassword" class="form-control col-md-3">
            </div>
        </div>
        <div class="form-group">
                    <div class="col-sm-4 col-sm-offset-3">
                        <asp:Button ID="submitbtn" class="btn btn-sm btn-success" runat="server" 
                            Text="Change Password" onclick="Button1_Click" />                   
                    </div>
                </div>
        </form>
    </div>
</asp:Content>
