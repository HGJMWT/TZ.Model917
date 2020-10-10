<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Users_Edit.aspx.cs" Inherits="TZ.WebApp917.Admins.Users.Users_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">编辑用户</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>用户ID:</label>
                        <asp:TextBox ID="txtId" ReadOnly="True" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>用户账号:</label>
                        <asp:TextBox ID="txtAccount" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>用户密码:</label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>用户昵称:</label>
                        <asp:TextBox ID="txtNickName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>用户身份编号:</label>
                        <asp:TextBox ID="txtRolesId" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="BtnSubmit" OnClick="BtnSubmit_OnClick" runat="server" Text="保存"  CssClass="btn btn-primary"/>
                        <asp:Button ID="BtnReset" OnClick="BtnReset_OnClick" runat="server"  Text="重置" CssClass="btn btn-primary"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
