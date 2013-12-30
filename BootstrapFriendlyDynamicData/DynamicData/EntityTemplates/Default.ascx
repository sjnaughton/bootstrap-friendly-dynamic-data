<%@ Control Language="C#" CodeBehind="Default.ascx.cs" Inherits="DynamicDataBootstrapped.DefaultEntityTemplate" %>

<asp:EntityTemplate runat="server" ID="EntityTemplate1">
    <ItemTemplate>
        <div class="form-group">
            <asp:Label runat="server" class="col-sm-2 control-label" OnInit="Label_Init" />
            <div class="col-sm-10">
                <asp:DynamicControl runat="server" OnInit="DynamicControl_Init" />
            </div>
        </div>
    </ItemTemplate>
</asp:EntityTemplate>

