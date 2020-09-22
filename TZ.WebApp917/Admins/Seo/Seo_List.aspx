<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Seo_List.aspx.cs" Inherits="TZ.WebApp917.Admins.Seo.Seo_List" %>
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
                   <h3 class="panel-title">优化表</h3>
               </div>
               <div class="panel-body">
                   <table class="table table-bordered table-hover">
                       <thead>
                       <tr>
                           <th>优化Id</th>
                           <th>优化标题</th>
                           <th>优化关键字</th>
                           <th>优化描述</th>
                           <th>优化网站菜单编号</th>
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
