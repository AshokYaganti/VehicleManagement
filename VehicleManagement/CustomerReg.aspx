﻿<%@ Page Title="" Language="C#" MasterPageFile="~/LoginRegister.master" AutoEventWireup="true" CodeFile="CustomerReg.aspx.cs" Inherits="CustomerReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" Runat="Server">
<div class="ibox-title">
        <h5><strong>Student Application Form</strong></h5>
        <div class="ibox-content">
            <form id="Form1" class="form-horizontal" runat="server">                
                <div class="form-group">
                    <label class="col-md-3 control-label">Name</label>
                    <div class="col-md-5">
                        <input type="text" name="name" id="name"  class="form-control">
                    </div>
                </div>
               
                <div class="form-group">
                    <label class="col-md-3 control-label">Username</label>
                    <div class="col-md-5">
                        <input type="text" name="username" id="username" class="form-control">
                    </div>
                </div>              
              
                <div class="form-group">
                    <label class="col-md-3 control-label">Password</label>
                    <div class="col-md-5">
                        <input type="password" name="password" id="password" class="form-control" />
                    </div>
                </div>
                
                <div class="form-group">
                    <label class="col-md-3 control-label">Confirm Password</label>
                    <div class="col-md-5">
                        <input type="password" name="cpassword" id="cpassword"  class="form-control" />
                    </div>
                </div>
                
                <div class="form-group">
                    <label class="col-md-3 control-label">Email ID</label>
                    <div class="col-md-5">
                        <input type="text" name="emailid" id="emailid"  class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-3 control-label">Phone</label>
                    <div class="col-md-5">
                        <input type="text" name="phone" id="phone"  class="form-control" />
                    </div>
                </div>                        
                <div class="form-group">
                    <label class="col-lg-3 control-label">Address</label>
                    <div class="col-lg-5">
                        <textarea name="address" id="address" rows="4" class="form-control noresize"></textarea>
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-lg-3 control-label">State</label>
                    <div class="col-lg-5">
                        <asp:DropDownList ID="DropDownList2" runat="server" class="form-control">
                        </asp:DropDownList>                  
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-lg-3 control-label">City</label>
                    <div class="col-lg-5">
                        <input type="text" name="city" id="city" rows="4" class="form-control" />
                    </div>
                </div>
                 <div class="form-group">
                    <label class="col-lg-3 control-label">Zip Code</label>
                    <div class="col-lg-5">
                         <input type="text" name="zip" id="zip" rows="4" class="form-control" />
                    </div>
                </div>                
                <div class="form-group">
                    <div class="col-sm-4 col-sm-offset-3">
                        <asp:Button ID="Button1" class="btn btn-sm btn-success" runat="server" 
                            Text="Submit" onclick="Button1_Click" />                   
                    </div>
                </div>
            </form>
        </div>
    </div>

</asp:Content>

