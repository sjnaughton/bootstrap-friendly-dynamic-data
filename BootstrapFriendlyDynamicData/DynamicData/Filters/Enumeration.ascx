<%@ Control Language="C#" CodeBehind="Enumeration.ascx.cs" Inherits="DynamicDataBootstrapped.EnumerationFilter" %>

<asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="True" CssClass="form-control"
    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
  <asp:ListItem Text="All" Value="" />
</asp:DropDownList>

