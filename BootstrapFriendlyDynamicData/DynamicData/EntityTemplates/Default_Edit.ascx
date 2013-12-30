<%@ Control Language="C#" CodeBehind="Default_Edit.ascx.cs" Inherits="DynamicDataBootstrapped.Default_EditEntityTemplate" %>

<%@ Reference Control="~/DynamicData/EntityTemplates/Default.ascx" %>
<asp:EntityTemplate runat="server" ID="EntityTemplate1">
    <ItemTemplate>
        <div class="form-group">
            <asp:Label runat="server" class="col-sm-2 control-label" OnInit="Label_Init" OnPreRender="Label_PreRender" />
            <div class="col-sm-10">
                <asp:DynamicControl runat="server" ID="DynamicControl" Mode="Edit" OnInit="DynamicControl_Init" />
            </div>
        </div>
    </ItemTemplate>
</asp:EntityTemplate>

