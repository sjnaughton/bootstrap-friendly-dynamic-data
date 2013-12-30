<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmailAddress_Edit.ascx.cs" Inherits="DynamicDataBootstrapped.EmailAddress_EditField" %>


<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Text='<%# FieldValueEditString %>'></asp:TextBox>


<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" />
