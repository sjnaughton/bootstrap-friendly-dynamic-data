<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="$safeprojectname$.ForeignKeyFilter" %>

<asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="True" CssClass="form-control"
    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem Text="All" Value="" />
</asp:DropDownList>

