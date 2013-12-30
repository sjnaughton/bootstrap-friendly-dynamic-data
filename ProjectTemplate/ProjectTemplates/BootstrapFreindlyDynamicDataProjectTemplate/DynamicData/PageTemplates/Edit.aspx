<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="Edit.aspx.cs" Inherits="$safeprojectname$.Edit" %>


<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
        <DataControls>
            <asp:DataControlReference ControlID="FormView1" />
        </DataControls>
    </asp:DynamicDataManager>

    <h2 class="DDSubHeader">Edit entry from table <%= table.DisplayName %></h2>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ValidationSummary 
                ID="ValidationSummary1" 
                runat="server" 
                EnableClientScript="true" 
                HeaderText="List of validation errors" 
                CssClass="DDValidator"/>
            <asp:DynamicValidator 
                runat="server" 
                ID="DetailsViewValidator" 
                ControlToValidate="FormView1" 
                Display="None" 
                CssClass="DDValidator"/>

            <asp:FormView 
                runat="server" 
                ID="FormView1" 
                DataSourceID="DetailsDataSource" 
                DefaultMode="Edit" 
                OnItemCommand="FormView1_ItemCommand" 
                OnItemUpdated="FormView1_ItemUpdated" 
                RenderOuterTable="false">
                <EditItemTemplate>
                    <div class="form-horizontal" role="form">
                        <asp:DynamicEntity runat="server" Mode="Edit" />

                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:LinkButton runat="server" CommandName="Update" CssClass="btn btn-primary"><i class="glyphicon glyphicon-floppy-disk"></i> Update</asp:LinkButton>
                                <asp:LinkButton runat="server" CommandName="Cancel" CssClass="btn btn-default" CausesValidation="false"><i class="glyphicon glyphicon-remove"></i> Cancel</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <div class="DDNoItem">No such item.</div>
                </EmptyDataTemplate>
            </asp:FormView>

            <asp:EntityDataSource ID="DetailsDataSource" runat="server" EnableUpdate="true" />

            <asp:QueryExtender TargetControlID="DetailsDataSource" ID="DetailsQueryExtender" runat="server">
                <asp:DynamicRouteExpression />
            </asp:QueryExtender>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

