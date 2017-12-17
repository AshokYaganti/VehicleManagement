<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="SoldInventory.aspx.cs" Inherits="SoldInventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" Runat="Server">
 <div class="ibox-title">
        <h5>
            <strong>Cars Inventory</strong>
        </h5>
    </div>
    <div class="ibox-content">
        <table class="table table-condensed table-striped table-hover" id="soldinventory">
            <thead>
                <tr>
                    <th>
                        Supervisor
                    </th>
                    <th>
                        VIN
                    </th>
                    <th>
                        Make
                    </th>
                    <th>
                        Model
                    </th>
                    <th>
                        Year
                    </th>
                    <th>
                        Inventory Type
                    </th>
                    <th>
                        Mileage
                    </th>
                    <th>
                        Cost
                    </th>
                    <th>
                        Status
                    </th>
                    <th>
                        Posted Date
                    </th>
                    <th>
                        &nbsp;
                    </th>                    
                </tr>
            </thead>
            <tbody>
                <asp:Literal runat="server" ID="ltData"></asp:Literal>
            </tbody>
        </table>
    </div>
</asp:Content>

