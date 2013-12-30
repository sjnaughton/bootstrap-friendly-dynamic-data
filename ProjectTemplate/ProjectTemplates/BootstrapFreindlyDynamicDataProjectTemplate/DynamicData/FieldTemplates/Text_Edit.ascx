<%@ Control Language="C#" CodeBehind="Text_Edit.ascx.cs" Inherits="$safeprojectname$.Text_EditField" %>

<asp:TextBox
    ID="TextBox1"
    runat="server"
    Text='<%# FieldValueEditString %>'
    CssClass="form-control"></asp:TextBox>

<asp:RequiredFieldValidator
    runat="server"
    ID="RequiredFieldValidator1"
    CssClass="validator"
    ControlToValidate="TextBox1"
    Display="Dynamic"
    Enabled="false" />
<asp:RegularExpressionValidator
    runat="server"
    ID="RegularExpressionValidator1"
    CssClass="validator"
    ControlToValidate="TextBox1"
    Display="Dynamic"
    Enabled="false" />
<asp:DynamicValidator
    runat="server"
    ID="DynamicValidator1"
    CssClass="validator"
    ControlToValidate="TextBox1"
    Display="Dynamic" />
