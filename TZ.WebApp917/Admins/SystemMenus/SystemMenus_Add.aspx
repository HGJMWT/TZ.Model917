<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="SystemMenus_Add.aspx.cs" Inherits="TZ.WebApp917.Admins.SystemMenus.SystemMenus_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">添加系统菜单</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>系统菜单标题:</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="系统菜单标题不能为空" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
                        </span>
                    </div>
                    <div class="form-group">
                        <label>系统菜单链接:</label>
                        <asp:TextBox ID="txtLink" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="系统菜单链接不能为空" ControlToValidate="txtLink"></asp:RequiredFieldValidator>
                        </span>
                    </div>
                    <div class="form-group">
                        <label>系统菜单图片:</label>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"></asp:FileUpload>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="BtnSubmit" OnClick="BtnSubmit_OnClick" runat="server"  Text="保存" CssClass="btn btn-primary"/>
                        <asp:Button ID="BtnReset" OnClick="BtnReset_OnClick" runat="server"  Text="重置" CssClass="btn btn-danger"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

