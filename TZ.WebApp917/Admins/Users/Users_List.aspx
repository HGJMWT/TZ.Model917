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
                <a href="Users_Add.aspx" class="btn btn-success">Insert</a>
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
                           <th width="5%">用户Id</th>
                           <th width="5%">用户账号</th>
                           <th width="5%">用户密码</th>
                           <th width="5%">用户昵称</th>
                           <th width="5%">用户头像</th>
                           <th width="5%">身份编号</th>
                           <th width="5%">编辑</th>
                           <th width="5%">删除</th>
                       </tr>
                       </thead>
                       <tbody>
                       <asp:Repeater ID="RepUsersList" runat="server">
                           <ItemTemplate>
                               <tr>
                                   <td><%#Container.ItemIndex+1 %></td>
                                   <td><%#Eval("Users_Account") %></td>
                                   <td><%#Eval("Users_Password") %></td>
                                   <td><%#Eval("Users_NickName") %></td>
                                   <td><%#Eval("Users_Photo") %></td>
                                   <td><%#Eval("Users_RolesId") %></td>
                                   <td>
                                       <a class="btn btn-warning" href='Users_Edit.aspx?action=<%# Eval("Id")%>'>
                                           <span class="lnr lnr-pencil"></span>修改
                                       </a>
                                   </td>
                                   <td>
                                       <a class="btn btn-danger" href='Users_Remove.aspx?action=<%# Eval("Id")%>'>
                                           <span class="lnr lnr-trash"></span>删除
                                       </a>
                                   </td>
                               </tr>
                           </ItemTemplate>
                       </asp:Repeater>
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
