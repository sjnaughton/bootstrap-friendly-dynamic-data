#Bootstrap Freindly Dynamic Data

[Bootstrap Friendly Dynamic Data](http://csharpbits.notaclue.net/2013/07/bootstrap-friendly-dynamic-data.html)

![The Default page when using this Project Template](BootstrapFriendlyDynamicDataProjectPreviewMedium.png)  
The Default page when using this Project Template

###Releasing updates###

I'll be doign the best I can to add ALL my Dynamic Data addons to this project over time


1. **Field templates**
    1. **UploadFile** - upload images to folder on web server.
    2. **UploadImage** - upload and display images (stored in folder on webserver).
    3. **SelectImage** - select from a list of images stored the image name in the field.
    4. **Date** - uses the AJAX Control Toolkit Date Picker for choosing dates for date fields.
    5. **ValueList** - Select predefined values from dropdown list similar to Foreign Key field template but work on none FK Columns.
    6. **HTMLEditor** - Uses the AJAX Control Toolkit HTML Editor
    7. **Autocomplete** - Uses the AJAX Control Toolkit AutoComplete to filter the Foreign Key list, there will also be an autocomplete list for any column as well as the Foreign Key column version.
    8. **ChoiceList** - Dropdown List for any Column.
    9. **ChildrenList** - Provides a way to show child tables, works in conjunction with the new Edit and Details page templates.
2. **Filters** - some of the filters are direct ports from the old __ASP.Net Dynamic Data Futures VS2008 SP1 RTM project__, they do what they say on the tin.
    1. **GreaterThan & GreaterThanOrEqual** - numeric values.
    2. **LessThan & LessThanOrEqual** - numeric values.
    3. **DateRange** - filter values between two dates.
    4. **Range** - filter between two values.
    5. **Autocomplete** - Provides a method of pre-filtering huge Foreign Key list.
    6. **Contains** - equivalent to T-SQL LIKE ‘%search term%’
    7. **MultiForeignKey** - allows selecting several Foreign Key values at once.
    8. **StartsWith** - equivalent to T-SQL LIKE ‘search term%’
    9. **EndsWith** - equivalent to T-SQL LIKE ‘%search term’
    10. **DateFrom** - greater than a particular date.
    11. **DataTo** - less than a particular date.
    12. **Cascading** - Allows related Foreign Key column s to filter each other.
    13. **CascadingHierarchical** - provides a cascading filter for single foreign key columns that have parent tables the they can be filtered by. 
3. **Page Templates**
    1. **New Details and Edit page templates** that use the ChildrenList field template and a tab control to display selected child tables beneath the main FormView.
    2. **Wizard** - This is just like the Insert or Edit page templates but uses the standard ASP.Net a wizard control and allows specifying which page each field should appear on.
    3. **New List** page with inline Edit and Insert plus Refresh button.
    4. **Popup** Insert page templates. 
4. **Entity Templates**
    1. **Group** - This allows grouping fields into section with each section having a title.
    2. **Tabs** - Using Bootstrap Tabs
    3. **MultiColumn** - Allows the creation of form with a grid like structure. 
5. **Secured Dynamic Data** site with table and column security.
6. **New Project Template** - Menus and all the above features installed out of the box. 

Many of the templates are already available via NuGet from [here](https://www.nuget.org/packages?q=DynamicData) and as I get the project setup here the rest will become available from NuGet also. 