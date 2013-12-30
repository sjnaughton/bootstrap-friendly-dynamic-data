<%@ Control Language="C#" CodeBehind="MultilineText_Edit.ascx.cs" Inherits="$safeprojectname$.MultilineText_EditField" %>

<asp:TextBox
    ID="TextBox1"
    runat="server"
    CssClass="form-control"
    TextMode="MultiLine"
    Text='<%# FieldValueEditString %>'
    Columns="80"
    Rows="5"></asp:TextBox>
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
