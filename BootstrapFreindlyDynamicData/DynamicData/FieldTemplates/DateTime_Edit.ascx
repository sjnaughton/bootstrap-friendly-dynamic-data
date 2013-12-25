<%@ Control Language="C#" CodeBehind="DateTime_Edit.ascx.cs" Inherits="DynamicDataBootstrapped.DateTime_EditField" %>


<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Text='<%# FieldValueEditString %>' Columns="20"></asp:TextBox>


<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" />
<asp:CustomValidator runat="server" ID="DateValidator" CssClass="validator" ControlToValidate="TextBox1" Display="Dynamic" EnableClientScript="false" Enabled="false" OnServerValidate="DateValidator_ServerValidate" />

