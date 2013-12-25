<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="List.aspx.cs" Inherits="DynamicDataBootstrapped.List" %>

<%@ Register Src="~/DynamicData/Content/GridViewPager.ascx" TagName="GridViewPager" TagPrefix="asp" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
        <DataControls>
            <asp:DataControlReference ControlID="GridView1" />
        </DataControls>
    </asp:DynamicDataManager>

    <h2 class="DDSubHeader"><%= table.DisplayName%></h2>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true" HeaderText="List of validation errors" CssClass="alert alert-danger" />
            <asp:DynamicValidator runat="server" ID="GridViewValidator" ControlToValidate="GridView1" Display="None" CssClass="alert alert-danger" />

            <div id="filters" runat="server" class="form-inline well well-sm filters">
                <asp:QueryableFilterRepeater runat="server" ID="FilterRepeater">
                    <ItemTemplate>
                        <span class="form-group">
                            <asp:Label
                                runat="server"
                                Text='<%# Eval("DisplayName") %>'
                                OnPreRender="Label_PreRender" />
                            <asp:DynamicFilter
                                runat="server"
                                ID="DynamicFilter"
                                OnFilterChanged="DynamicFilter_FilterChanged" />
                        </span>
                    </ItemTemplate>
                </asp:QueryableFilterRepeater>
            </div>

            <div class="spacer">
                <asp:DynamicHyperLink ID="InsertHyperLink" runat="server" CssClass="btn btn-success" Action="Insert"><i class="glyphicon glyphicon-plus"></i>&nbsp;Insert new item</asp:DynamicHyperLink>
            </div>

            <div class="table-overflow">
                <asp:GridView
                    ID="GridView1"
                    runat="server"
                    DataSourceID="GridDataSource"
                    EnablePersistedSelection="true"
                    AllowPaging="True"
                    AllowSorting="True"
                    GridLines="None"
                    CellSpacing="-1"
                    CssClass="table table-striped table-hover table-rounded">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:DynamicHyperLink runat="server" ToolTip="Details" CssClass="btn btn-primary btn-round"><i class="glyphicon glyphicon-folder-open"></i></asp:DynamicHyperLink>
                                <asp:DynamicHyperLink runat="server" Action="Edit" ToolTip="Edit" CssClass="btn btn-primary btn-round"><i class="glyphicon glyphicon-pencil"></i></asp:DynamicHyperLink>
                                <asp:LinkButton runat="server" CommandName="Delete" ToolTip="Delete" CssClass="btn btn-primary btn-round"
                                    OnClientClick='return confirm("Are you sure you want to delete this item?");'><i class="glyphicon glyphicon-trash"></i></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                    <PagerStyle CssClass="table-footer" />
                    <PagerTemplate>
                        <asp:GridViewPager runat="server" />
                    </PagerTemplate>
                    <EmptyDataTemplate>
                        There are currently no items in this table.
                    </EmptyDataTemplate>
                </asp:GridView>
            </div>

            <asp:EntityDataSource ID="GridDataSource" runat="server" EnableDelete="true" />

            <asp:QueryExtender TargetControlID="GridDataSource" ID="GridQueryExtender" runat="server">
                <asp:DynamicFilterExpression ControlID="FilterRepeater" />
            </asp:QueryExtender>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

