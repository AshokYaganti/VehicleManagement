<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="RegisteredUsers.aspx.cs" Inherits="RegisteredUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" Runat="Server">
  <div class="ibox-title">
        <h5>
            <strong>Registered Users</strong>
        </h5>
    </div>
    <div class="ibox-content">
        <table class="table table-condensed table-striped table-hover" id="registeredUsers">
            <thead>
                <tr>
                    <th>
                        Name
                    </th>
                    <th>
                        Username
                    </th>
                    <th>
                        Email
                    </th>
                    <th>
                        Phone
                    </th>
                    <th>
                        Address
                    </th>
                    <th>
                        State
                    </th>
                    <th>
                        City
                    </th>
                    <th>
                        Zip
                    </th>
                     <th>
                        Role
                    </th>
                    <th>
                        Registered Date
                    </th>                                  
                </tr>
            </thead>
            <tbody>
                <asp:Literal runat="server" ID="ltData"></asp:Literal>
            </tbody>
        </table>
    </div>
</asp:Content>

