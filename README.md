#Bootstrap Freindly Dynamic Data for Visual Studio

[Bootstrap Friendly Dynamic Data](http://csharpbits.notaclue.net/2013/07/bootstrap-friendly-dynamic-data.html)

![The Default page when using this Project Template](BootstrapFriendlyDynamicDataProjectPreviewMedium.png)  
The Default page when using this Project Template

###Releasing updates###

I'll be doign the best I can to add ALL my Dynamic Data addons to this project over time


1. **Field templates**
        a. **UploadFile** - upload images to folder on web server.
        b. **UploadImage** - upload and display images (stored in folder on webserver).
        c. **SelectImage** - select from a list of images stored the image name in the field.
        e. **Date** - uses the AJAX Control Toolkit Date Picker for choosing dates for date fields.
        f. **ValueList** - Select predefined values from dropdown list similar to Foreign Key field template but work on none FK Columns.
        g. **HTMLEditor** - Uses the AJAX Control Toolkit HTML Editor
        h. **Autocomplete** - Uses the AJAX Control Toolkit AutoComplete to filter the Foreign Key list, there will also be an autocomplete list for any column as well as the Foreign Key column version.
        i. **ChoiceList** - Dropdown List for any Column.
        j. **ChildrenList** - Provides a way to show child tables, works in conjunction with the new Edit and Details page templates.
2. **Filters** - some of the filters are direct ports from the old __ASP.Net Dynamic Data Futures VS2008 SP1 RTM project__, they do what they say on the tin.
        a. **GreaterThan & GreaterThanOrEqual** - numeric values.
        b. **LessThan & LessThanOrEqual** - numeric values.
        c. **DateRange** - filter values between two dates.
        e. **Range** - filter between two values.
        f. **Autocomplete** - Provides a method of pre-filtering huge Foreign Key list.
        g. **Contains** - equivalent to T-SQL LIKE ‘%search term%’
        h. **MultiForeignKey** - allows selecting several Foreign Key values at once.
        i. **StartsWith** - equivalent to T-SQL LIKE ‘search term%’
        j. **EndsWith** - equivalent to T-SQL LIKE ‘%search term’
        k. **DateFrom** - greater than a particular date.
        l. **DataTo** - less than a particular date.
        m. **Cascading** - Allows related Foreign Key column s to filter each other.
        n. **CascadingHierarchical** - provides a cascading filter for single foreign key columns that have parent tables the they can be filtered by. 
3. **Page Templates**
        a. **New Details and Edit page templates that use the ChildrenList field template and a tab control to display selected child tables beneath the main FormView.
        b. **Wizard** - This is just like the Insert or Edit page templates but uses the standard ASP.Net a wizard control and allows specifying which page each field should appear on.
        c. **New List page with inline Edit and Insert plus Refresh button.
        e. **Popup Insert and Edit page templates. 
4. **Entity Templates**
   a. **Group** - This allows grouping fields into section with each section having a title.
   b. **Tabs** - Using Bootstrap Tabs
   c. **MultiColumn** - Allows the creation of form with a grid like structure. 
5. **Secured Dynamic Data** site with table and column security.
6. **New Project Template** - Menus and all the above features installed out of the box. 

Many of the templates are already available via NuGet from here and as I get the project setup here the rest will become available from NuGet also. 