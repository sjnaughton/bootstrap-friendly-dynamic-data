using System;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web.UI.WebControls;

namespace $safeprojectname$
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                System.Collections.IList visibleTables = Global.DefaultModel.VisibleTables;
                if (visibleTables.Count == 0)
                    throw new InvalidOperationException("There are no accessible tables. Make sure that at least one data model is registered in Global.asax and scaffolding is enabled or implement custom pages.");

                Menu1.Items.Add(new MenuItem("Home", "Home") { NavigateUrl = "~/Default.aspx" });
                var tables = new MenuItem("Tables") { Selectable = false };
                foreach (MetaTable table in visibleTables)
                {
                    tables.ChildItems.Add(new MenuItem(table.DisplayName, table.Name) { NavigateUrl = table.ListActionPath });
                }
                Menu1.Items.Add(tables);
            }
        }
    }
}
