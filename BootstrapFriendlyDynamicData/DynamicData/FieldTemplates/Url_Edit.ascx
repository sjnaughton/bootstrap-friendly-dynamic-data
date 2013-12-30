<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Url_Edit.ascx.cs" Inherits="DynamicDataBootstrapped.Url_EditField" %>


<asp:TextBox ID="TextBox1" runat="server" Text='<%# FieldValueEditString %>' CssClass="form-control" Columns="10"></asp:TextBox>


<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" />

