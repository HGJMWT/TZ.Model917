﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Seos_Add.aspx.cs" Inherits="TZ.WebApp917.Admins.Seos.Seos_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">添加优化</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>优化标题:</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="优化标题不能为空" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
                        </span>
                    </div>
                    <div class="form-group">
                        <label>优化关键字:</label>
                        <asp:TextBox ID="txtKeyword" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="优化链接不能为空" ControlToValidate="txtKeyword"></asp:RequiredFieldValidator>
                        </span>
                    </div>
                    <div class="form-group">
                        <label>优化描述:</label>
                        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox>
                        <span class="msg">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="优化描述不能为空" ControlToValidate="txtDescription"></asp:RequiredFieldValidator>
                        </span>
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
