<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="Insert.aspx.cs" Inherits="$safeprojectname$.Insert" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
        <DataControls>
            <asp:DataControlReference ControlID="FormView1" />
        </DataControls>
    </asp:DynamicDataManager>

    <h2 class="DDSubHeader">Add new entry to table <%= table.DisplayName %></h2>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                HeaderText="List of validation errors" CssClass="DDValidator" />
            <asp:DynamicValidator runat="server" ID="DetailsViewValidator" ControlToValidate="FormView1" Display="None" CssClass="DDValidator" />

            <asp:FormView runat="server" ID="FormView1" DataSourceID="DetailsDataSource" DefaultMode="Insert"
                OnItemCommand="FormView1_ItemCommand" OnItemInserted="FormView1_ItemInserted" RenderOuterTable="false">
                <InsertItemTemplate>
                    <div class="form-horizontal" role="form">
                        <asp:DynamicEntity runat="server" Mode="Insert" />

                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:LinkButton runat="server" CommandName="Insert" CssClass="btn btn-primary" ><i class="glyphicon glyphicon-plus"></i> Insert</asp:LinkButton>
                                <asp:LinkButton runat="server" CommandName="Cancel" CssClass="btn btn-default" CausesValidation="false"><i class="glyphicon glyphicon-remove"></i> Cancel</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </InsertItemTemplate>
            </asp:FormView>

            <asp:EntityDataSource ID="DetailsDataSource" runat="server" EnableInsert="true" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

