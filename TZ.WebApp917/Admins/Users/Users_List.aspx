<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Users_List.aspx.cs" Inherits="TZ.WebApp917.Admins.Users.Users_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mb-1">
        <div class="col-md-10 col-md-offset-1">
            <div class="col-md-5">
                <input type="text" class="form-control"/>
            </div>
            <div class="col-md-4">
                <button class="btn btn-primary">Go!</button>
                <button class="btn btn-success">Insert</button>
                <button class="btn btn-danger">Delete</button>
            </div>
        </div>
    </div>
   <div class="row">
       <div class="col-md-10 col-md-offset-1">
           <div class="panel">
               <div class="panel-heading">
                   <h3 class="panel-title">用户表</h3>
               </div>
               <div class="panel-body">
                   <table class="table table-bordered table-hover">
                       <thead>
                       <tr>
                           <th>用户Id</th>
                           <th>用户账号</th>
                           <th>用户密码</th>
                           <th>用户头像</th>
                           <th>身份编号</th>
                       </tr>
                       </thead>
                       <tbody>
                       <tr>
                           <td>tz</td>
                           <td>tz</td>
                           <td>tz</td>
                           <td>tz</td>
                           <td>tz</td>
                       </tr>
                       </tbody>
                   </table>
               </div>
           </div>
       </div>
   </div>
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            <nav aria-label="Page navigation">
                <ul class="pagination">
                    <li>
                        <a href="#" aria-label="Previous">
                            <span aria-hidden="true">&laquo;</span>
                        </a>
                    </li>
                    <li><a href="#">1</a></li>
                    <li><a href="#">2</a></li>
                    <li><a href="#">3</a></li>
                    <li><a href="#">4</a></li>
                    <li><a href="#">5</a></li>
                    <li>
                        <a href="#" aria-label="Next">
                            <span aria-hidden="true">&raquo;</span>
                        </a>
                    </li>
                </ul>
            </nav>
        </div>
    </div>
</asp:Content>
