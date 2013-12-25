using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotAClue.Web.UI.BootstrapWebControls
{
    [ParseChildren(typeof(BootstrapTabs), DefaultProperty = "BootstrapTabs", ChildrenAsProperties = true)]
    public class Tab : WebControl
    {

        private List<BootstrapTabs> _BootstrapTabs;

        public Tab()  : base("tabs")
        {
            _BootstrapTabs = new List<BootstrapTabs>();
        }

        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TemplateContainer(typeof(BootstrapTabs))]
        public List<BootstrapTabs> BootstrapTabs { get { return this._BootstrapTabs; } }

        [Category("Behavior")]
        [DefaultValue(false)]
        [Description("Set to true to allow an already selected tab to become unselected again upon reselection.")]
        public bool Collapsible { get; set; }

        [TypeConverter(typeof(Boolean))]
        [Category("Appearance")]
        [DefaultValue(null)]
        [Description("Disables (true) or enables (false) the tab.")]
        public new dynamic Disabled { get; set; }

        [Category("Behavior")]
        [DefaultValue("click")]
        [Description("The type of event to be used for selecting a tab.")]
        public string Event { get; set; }

        [TypeConverter(typeof(String))]
        [Category("Behavior")]
        [DefaultValue(null)]
        [Description("Specifies if and how to animate the hiding of the panel.")]
        public dynamic Hide { get; set; }

        [TypeConverter(typeof(String))]
        [Category("Behavior")]
        [DefaultValue(null)]
        [Description("Specifies if and how to animate the showing of the panel.")]
        public dynamic Show { get; set; }

        [Category("Behavior")]
        [DefaultValue(0)]
        [Description("Zero-based index of the tab to be selected on initialization. To set all tabs to unselected pass -1 as value.")]
        public int Active { get; set; }

        [Category("Action")]
        [Description("This event is triggered when clicking a tab.")]
        public event EventHandler ActiveTabChanged;

        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Div; }
        }

        public override ControlCollection Controls
        {
            get
            {
                this.EnsureChildControls();
                return base.Controls;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            this.Controls.Clear();

            if (BootstrapTabs != null)
            {
                foreach (BootstrapTabs page in BootstrapTabs)
                {
                    this.Controls.Add(page);
                }
            }

            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {

            this.RenderBeginTag(writer);

            writer.WriteBeginTag("ul");

            writer.Write(HtmlTextWriter.TagRightChar);

            if (BootstrapTabs != null)
            {
                foreach (BootstrapTabs page in BootstrapTabs)
                {
                    writer.WriteFullBeginTag("li");

                    writer.WriteBeginTag("a");
                    writer.WriteAttribute("href", "#" + page.ClientID);
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write(page.Title);
                    writer.WriteEndTag("a");

                    writer.WriteEndTag("li");
                }
            }

            writer.WriteEndTag("ul");

            this.RenderChildren(writer);

            this.RenderEndTag(writer);
        }
    }
}
