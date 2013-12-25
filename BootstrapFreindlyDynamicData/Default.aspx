<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeBehind="Default.aspx.cs" Inherits="DynamicDataBootstrapped._Default" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    <!-- Main component for a primary marketing message or call to action -->
    <div class="jumbotron">
        <h1>Welcome to Dynamic Data</h1>
        <p>Extensible data-driven Web applications by inferring at run time the appearance and behavior of data fields and by deriving UI behavior from it. The topics listed next provide information and code examples that illustrate Dynamic Data capabilities.</p>
        <p>
            <a href="http://msdn.microsoft.com/en-us/library/cc488545.aspx" class="btn btn-primary btn-lg" role="button" target="_blank">Learn more</a>
        </p>
    </div>
    <!-- Example row of columns -->
    <div class="row">
        <div class="col-md-4">
            <h2>Overview</h2>
            <p>ASP.NET Dynamic Data lets you create extensible data-driven Web applications by inferring at run time the appearance and behavior of data entities from the database schema and deriving UI behavior from it.</p>

            <p><a class="btn btn-default" href="http://msdn.microsoft.com/en-us/library/ee845452%28v=vs.100%29.aspx" role="button" target="_blank">View details &raquo;</a></p>
        </div>
        <div class="col-md-4">
            <h2>Fully Scaffolded</h2>
            <p>Dynamic Data supports scaffolding, which is a way to automatically generate Web pages for each table in the database. Scaffolding lets you create a functional Web site for viewing and editing data based on the schema of the data. You can easily customize scaffolding elements or create new ones to override the default behavior.</p>
            <p><a class="btn btn-default" href="http://msdn.microsoft.com/en-us/library/ee377606(v=vs.100).aspx" role="button" target="_blank">View details &raquo;</a></p>
        </div>
        <div class="col-md-4">
            <h2>Simple Dynamic Data</h2>
            <p>You can also enable dynamic behavior in existing or new Web applications without using scaffolding. In that case, you specify how and when Dynamic Data should infer UI elements from the data source without using scaffolding for the entire Web site.</p>
            <p><a class="btn btn-default" href="http://msdn.microsoft.com/en-us/library/ee225351(v=vs.100).aspx" role="button" target="_blank">View details &raquo;</a></p>
        </div>
    </div>
</asp:Content>


