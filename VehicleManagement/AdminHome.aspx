<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true"
    CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" runat="Server">
    <div class="ibox-title">
        <h5>
            <strong>Cars Inventory</strong>
        </h5>
    </div>
    <div class="ibox-content">
        <table class="table table-condensed table-striped table-hover" id="carsinventory">
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
                    <th>
                        &nbsp;
                    </th>
                    <th>
                        &nbsp;
                    </th>
                    <th>
                        &nbsp;
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
    <div class="modal fade" id="updateModel" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="updateclosebtn2" class="closebtn close" data-dismiss="modal">
                        &times;</button>
                    <h4 class="modal-title">
                        Update Car Price</h4>
                </div>
                <div class="modal-body" id="Div2">
                    <form id="Form2" class="form-horizontal">
                    <input type="hidden" id="inventoryid" name="inventoryid" />
                    <div class="form-group">
                        <label class="col-md-3 control-label">
                            VIN</label>
                        <div class="col-md-5">
                            <input type="text" name="vin" id="vin" class="form-control col-md-3" disabled="disabled" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-3 control-label">
                            Make</label>
                        <div class="col-md-5">
                            <input type="text" name="make" id="make" class="form-control col-md-3" disabled="disabled" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-3 control-label">
                            Modal</label>
                        <div class="col-md-5">
                            <input type="text" name="modal" id="modal" class="form-control col-md-3" disabled="disabled" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-3 control-label">
                            Price</label>
                        <div class="col-md-5">
                            <input type="number" name="price" id="price" class="form-control col-md-3" />
                        </div>
                    </div>
                    </form>
                </div>
                <div class="modal-footer" id="Div3" runat="server">
                    <a href="#" class="btn btn-success btn-sm" id="updatebtn">update</a>
                    <button type="button" id="updateclosebtn" class="btn btn-default closebtn" data-dismiss="modal">
                        Close</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="coursedeleteModal" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="deleteCourseclosebtn" class="close closebtn" data-dismiss="modal">
                        &times;</button>
                    <h4 class="modal-title">
                        Delete Car</h4>
                </div>
                <div class="modal-body" id="Div4">
                    <form id="Form3" class="form-horizontal">
                    <input type="hidden" id="iid" name="iid" />
                    Are you sure do you want to delete the car?
                    </form>
                </div>
                <div class="modal-footer" id="Div5" runat="server">
                    <a href="#" class="btn btn-success btn-sm" id="deletebtn">Yes, Delete</a>
                    <button type="button" id="deleteclosebtn2" class="btn btn-default closebtn" data-dismiss="modal">
                        Close</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="approveModal" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" id="Button1" class="close closebtn" data-dismiss="modal">
                        &times;</button>
                    <h4 class="modal-title">
                        Approve/Decline Inventory</h4>
                </div>
                <div class="modal-body" id="Div6">
                    <form id="Form1" class="form-horizontal">
                    <input type="hidden" id="invid" name="invid" />
                    <div class="form-group">
                        <label class="col-md-3 control-label">
                            Inventory Decision</label>
                        <div class="col-md-5">
                          <select class="form-control col-md-3" id="decision">
                           <option value="APPROVED">Approve</option>
                            <option value="DECLINED">Decline</option>
                          </select>                           
                        </div>
                    </div>
                    </form>
                </div>
                <div class="modal-footer" id="Div7" runat="server">
                    <a href="#" class="btn btn-success btn-sm" id="approvebtn">Submit</a>
                    <button type="button" id="Button2" class="btn btn-default closebtn" data-dismiss="modal">
                        Close</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
