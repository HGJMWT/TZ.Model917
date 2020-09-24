﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Roles_Add.aspx.cs" Inherits="TZ.WebApp917.Admins.Roles.Roles_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">添加权限</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>权限名称:</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="BtnSubmit" OnClick="BtnSubmit_OnClick" runat="server"  Text="保存" CssClass="btn btn-primary"/>
                        <asp:Button ID="BtnReset" OnClick="BtnReset_OnClick" runat="server"  Text="重置" CssClass="btn btn-primary"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
