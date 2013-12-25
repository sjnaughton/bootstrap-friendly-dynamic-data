using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotAClue.Web.UI.BootstrapWebControls
{
    [Designer("NotAClue.Web.UI.BootstrapWebControls.BootstrapTabContainerDesigner, AjaxControlToolkit")]
    [ParseChildren(typeof(Tab))]
    [DefaultProperty("TabClick")]
    [ToolboxData("<{0}:BootstrapTabContainer runat=server></{0}:BootstrapTabContainer>")]
    [System.Drawing.ToolboxBitmap(typeof(BootstrapTabs), "Tabs.BootstrapTabs.ico")]
    public class BootstrapTabs : WebControl, IPostBackEventHandler
    {

        private Control _templateContainer;

        public string Title { get; set; }

        public Control TemplateContainer
        {
            get
            {
                this.EnsureChildControls();

                return _templateContainer;
            }
        }

        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(ContentTemplate))]
        [DefaultValue((string)null)]
        public ITemplate TabContent { get; set; }

        protected override void CreateChildControls()
        {
            if (TabContent != null)
            {
                _templateContainer = new ContentTemplate();
                TabContent.InstantiateIn(_templateContainer);
                Controls.Add(_templateContainer);
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            writer.WriteBeginTag("div");
            writer.WriteAttribute("id", ClientID);
            writer.Write(HtmlTextWriter.TagRightChar);

            base.Render(writer);

            writer.WriteEndTag("div");
        }

        /// <summary>
        /// Searches the current naming container for a server control with the specified id parameter.
        /// </summary>
        /// <param name="id">The identifier for the control to be found.</param>
        /// <returns>The specified control, or null if the specified control does not exist.</returns>
        public new Control FindControl(string id)
        {
            return this.TemplateContainer.Controls.All().Where(c => c.ID == id).FirstOrDefault();
        }

        public void RaisePostBackEvent(string eventArgument)
        {
            throw new NotImplementedException();
        }
    }
}
