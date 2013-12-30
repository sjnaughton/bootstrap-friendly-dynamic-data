<%@ Control Language="C#" CodeBehind="ForeignKey_Edit.ascx.cs" Inherits="$safeprojectname$.ForeignKey_EditField" %>

<asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
</asp:DropDownList>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="validator" ControlToValidate="DropDownList1" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="validator" ControlToValidate="DropDownList1" Display="Dynamic" />

