<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Seos_Edit.aspx.cs" Inherits="TZ.WebApp917.Admins.Seos.Seos_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">优化菜单</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>优化ID:</label>
                        <asp:TextBox ID="txtId" ReadOnly="True" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>优化标题</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>优化关键字:</label>
                        <asp:TextBox ID="txtKeyword" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>优化描述:</label>
                        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox>
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
