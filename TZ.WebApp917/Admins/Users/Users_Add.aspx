<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Users_Add.aspx.cs" Inherits="TZ.WebApp917.Admins.Users.Users_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">添加用户</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>用户账号:</label>
                        <asp:TextBox ID="txtAccount" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="账号不能为空" ControlToValidate="txtAccount"></asp:RequiredFieldValidator>
                        </span>
                    </div>
                    <div class="form-group">
                        <label>用户密码:</label>
                        <asp:TextBox ID="txtPassword" TextMode="Password"  runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                        </span>
                    </div>
                    <div class="form-group">
                        <label>确认密码:</label>
                        <asp:TextBox ID="txtqrPassword" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:CompareValidator ID="cv1" ControlToCompare="txtPassword" ControlToValidate="txtqrPassword" runat="server" ErrorMessage="两次密码输入不一致"></asp:CompareValidator>
                    </div>
                    <div class="form-group">
                        <label>用户昵称:</label>
                        <asp:TextBox ID="txtNickName" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="昵称不能为空" ControlToValidate="txtNickName"></asp:RequiredFieldValidator>
                        </span>
                    </div>
                    <div class="form-group">
                        <label>用户头像:</label>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"></asp:FileUpload>
                    </div>
                    <div class="form-group">
                        <label>用户身份编号:</label>
                        <asp:DropDownList ID="ddlRolesList" runat="server" CssClass="form-control"></asp:DropDownList>
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
