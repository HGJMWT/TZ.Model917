<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Seos_List.aspx.cs" Inherits="TZ.WebApp917.Admins.Seos.Seos_List" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row mb-1">
        <div class="col-md-10 col-md-offset-1">
            <div class="col-md-5">
                <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Button ID="btnSearch" runat="server" Text="Go" CssClass="btn btn-primary" OnClick="btnSearch_OnClick" />
                <a href="Seos_Add.aspx" class="btn btn-success">Insert</a>
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
                           <th width="5%">优化Id</th>
                           <th width="5%">优化标题</th>
                           <th width="5%">优化链接</th>
                           <th width="5%">优化描述</th>
                           <th width="5%">编辑</th>
                           <th width="5%">删除</th>
                       </tr>
                       </thead>
                       <tbody>
                       <asp:Repeater ID="RepSeosList" runat="server">
                           <ItemTemplate>
                               <tr>
                                   <td><%#Container.ItemIndex+1 %></td>
                                   <td><%#Eval("Seos_Title") %></td>
                                   <td><%#Eval("Seos_Keyword") %></td>
                                   <td><%#Eval("Seos_Description") %></td>
                                   <td>
                                       <a class="btn btn-warning" href='Seos_Edit.aspx?action=<%# Eval("Id")%>'>
                                           <span class="lnr lnr-pencil"></span>修改
                                       </a>
                                   </td>
                                   <td>
                                       <a class="btn btn-danger" href='Seos_Remove.aspx?action=<%# Eval("Id")%>'>
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
            <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages" CurrentPageButtonClass="cpb"
                                  CustomInfoTextAlign="Left" HorizontalAlign="Right" PageIndexBoxType="TextBox"  
                                  ShowCustomInfoSection="Left" ShowMoreButtons="False" ShowNavigationToolTip="True"  
                                  ShowPageIndexBox="Always"   
                                  runat="server" AlwaysShow="True" PageSize="2" ShowInputBox="Always"
                                  LayoutType="Table" OnPageChanging="AspNetPager1_OnPageChanging" 
                                  FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
                                  PagingButtonSpacing="2px" >
            </webdiyer:AspNetPager>
        </div>
    </div>
</asp:Content>

