using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
//using NotAClue;

namespace NotAClue.Web.UI.BootstrapWebControls
{
	/// <summary>
	/// Class BootstrapMenu.
	/// </summary>
	[ControlValueProperty("SelectedValue")]
	[DefaultEvent("MenuItemClick")]
	//[Designer("System.Web.UI.Design.WebControls.MenuDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SupportsEventValidation]
	[ToolboxData("<{0}:BootstrapMenu runat=\"server\"></{0}:BootstrapMenu>")]
    [System.Drawing.ToolboxBitmap(typeof(BootstrapTabs), "Tabs.BootstrapMenu.ico")]
    public class BootstrapMenu : Menu
	{
		/// <summary>
		/// Adds tag attributes and writes the markup for the opening tag of the control to the output stream emitted to the browser or device.
		/// </summary>
		/// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> containing methods to build and render the device-specific output.</param>
		public override void RenderBeginTag(HtmlTextWriter writer)
		{
			// don't call base.RenderBeginTag()
		}

		protected override void Render(HtmlTextWriter writer)
		{
			writer.Indent++;
			BuildItems(this.Items, true, writer);
			writer.Indent--;
			writer.WriteLine();
		}

		/// <summary>
		/// Performs final markup and writes the HTML closing tag of the control to the output stream emitted to the browser or device.
		/// </summary>
		/// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> containing methods to build and render the device-specific output.</param>
		public override void RenderEndTag(HtmlTextWriter writer)
		{
			// don't call base.RenderEndTag()
		}

		/// <summary>
		/// Builds the items.
		/// </summary>
		/// <param name="items">The items.</param>
		/// <param name="isRoot">if set to <c>true</c> [is root].</param>
		/// <param name="writer">The writer.</param>
		private void BuildItems(MenuItemCollection items, bool isRoot, HtmlTextWriter writer)
		{
			//<ul class="nav">
			//	<li class="active"><a href="#">Home</a></li>
			//	<li><a href="#">Link</a></li>
			//	<li><a href="#">Link</a></li>
			//	<li class="dropdown">
			//		<a class="dropdown-toggle"
			//			data-toggle="dropdown"
			//			href="#">Dropdown
			//			<b class="caret"></b>
			//		</a>
			//		<ul class="dropdown-menu">
			//			<li>
			//				<a id="A1" href="/Categories/List.aspx">Categories</a>
			//			</li>
			//			<li>
			//				<a id="A2" href="/CustomerDemographics/List.aspx">CustomerDemographics</a>
			//			</li>
			//		</ul>
			//	</li>
			//</ul>
			if (items.Count > 0)
			{
				writer.WriteLine();

				writer.WriteBeginTag("ul");
				if (isRoot)
				{
					var navClass = "nav";
					if (!String.IsNullOrEmpty(this.CssClass))
						navClass += " " + this.CssClass;
					writer.WriteAttribute("class", navClass);
				}
				else
					writer.WriteAttribute("class", "dropdown-menu");

				writer.Write(HtmlTextWriter.TagRightChar);
				writer.Indent++;

				foreach (MenuItem item in items)
				{
					BuildItem(item, writer);
				}

				writer.Indent--;
				writer.WriteLine();
				writer.WriteEndTag("ul");
			}
		}

		/// <summary>
		/// Builds the item.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <param name="writer">The writer.</param>
		private void BuildItem(MenuItem item, HtmlTextWriter writer)
		{
			if (item != null && writer != null)
			{
				writer.WriteLine();
				writer.WriteBeginTag("li");

				string cssClass = (item.ChildItems.Count > 0) ? "dropdown" : "";
				string selectedStatusClass = GetSelectStatusClass(item);
				if (!String.IsNullOrEmpty(selectedStatusClass))
					cssClass += " " + selectedStatusClass;

				writer.WriteAttribute("class", cssClass);

				writer.Write(HtmlTextWriter.TagRightChar);
				writer.Indent++;
				writer.WriteLine();

				if (IsLink(item))
				{
					writer.WriteBeginTag("a");
					if (!String.IsNullOrEmpty(item.NavigateUrl))
						writer.WriteAttribute("href", Page.Server.HtmlEncode(this.ResolveClientUrl(item.NavigateUrl)));
					else
						writer.WriteAttribute("href", Page.ClientScript.GetPostBackClientHyperlink(this, "b" + item.ValuePath.Replace(this.PathSeparator.ToString(), "\\"), true));

					cssClass = GetItemClass(this, item);
					writer.WriteAttribute("class", cssClass);
					writer.WriteTargetAttribute(item.Target);

					if (!String.IsNullOrEmpty(item.ToolTip))
						writer.WriteAttribute("title", item.ToolTip);
					else if (!String.IsNullOrEmpty(this.ToolTip))
						writer.WriteAttribute("title", this.ToolTip);

					writer.Write(HtmlTextWriter.TagRightChar);
					writer.Indent++;
					writer.WriteLine();
					writer.Write(item.Text);

					writer.Indent--;
					writer.WriteEndTag("a");
				}
				else if ((item.ChildItems != null) && (item.ChildItems.Count > 0))
				{
					//.btn-navbar is used as the toggle for collapsed navbar content
					//<a class="dropdown-toggle" data-toggle="dropdown" href="#">Tables&nbsp;<b class="caret"></b></a>
					writer.WriteBeginTag("a");
					writer.WriteAttribute("class", "dropdown-toggle");
					writer.WriteAttribute("data-toggle", "dropdown");
					writer.WriteAttribute("href", "#");
					writer.Write(HtmlTextWriter.TagRightChar);
					writer.Write(item.Text);
					// add space between text and caret
					writer.Write("&nbsp;");
					writer.WriteBeginTag("b");
					writer.WriteAttribute("class", "caret");
					writer.Write(HtmlTextWriter.TagRightChar);
					writer.WriteEndTag("b");
					writer.WriteEndTag("a");

					BuildItems(item.ChildItems, false, writer);
				}
				else
				{
					// no link here this is just a menu item with no function
					writer.WriteBeginTag("li");
					writer.WriteAttribute("class", GetItemClass(this, item));
					writer.Write(HtmlTextWriter.TagRightChar);
					writer.Indent++;
					writer.WriteLine();
				}

				writer.Indent--;
				writer.WriteLine();
				writer.WriteEndTag("li");
			}
		}

		/// <summary>
		/// Determines whether the specified item is link.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if the specified item is link; otherwise, <c>false</c>.</returns>
		private bool IsLink(MenuItem item)
		{
			return (item != null) && item.Enabled && (!String.IsNullOrEmpty(item.NavigateUrl) || item.Selectable);
		}

		/// <summary>
		/// Gets the item class.
		/// </summary>
		/// <param name="menu">The menu.</param>
		/// <param name="item">The item.</param>
		/// <returns>System.String.</returns>
		private string GetItemClass(Menu menu, MenuItem item)
		{
			string value = "";
			if (item != null)
			{
				if (((item.Depth < menu.StaticDisplayLevels) && (menu.StaticItemTemplate != null)) || ((item.Depth >= menu.StaticDisplayLevels) && (menu.DynamicItemTemplate != null)))
					value = "";
				else if (IsLink(item))
					value = "";

				string selectedStatusClass = GetSelectStatusClass(item);
				if (!String.IsNullOrEmpty(selectedStatusClass))
					value += " " + selectedStatusClass;
			}
			return value.Trim();
		}

		/// <summary>
		/// Gets the select status class.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>System.String.</returns>
		private string GetSelectStatusClass(MenuItem item)
		{
			string value = String.Empty;
			if (item.Selected || IsChildItemSelected(item) || IsParentItemSelected(item))
				value = "active";

			return value.Trim();
		}

		/// <summary>
		/// Determines whether [is child item selected] [the specified item].
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if [is child item selected] [the specified item]; otherwise, <c>false</c>.</returns>
		private bool IsChildItemSelected(MenuItem item)
		{
			bool bRet = false;

			if ((item != null) && (item.ChildItems != null))
				bRet = IsChildItemSelected(item.ChildItems);

			return bRet;
		}

		/// <summary>
		/// Determines whether [is child item selected] [the specified items].
		/// </summary>
		/// <param name="items">The items.</param>
		/// <returns><c>true</c> if [is child item selected] [the specified items]; otherwise, <c>false</c>.</returns>
		private bool IsChildItemSelected(MenuItemCollection items)
		{
			bool bRet = false;

			if (items != null)
			{
				foreach (MenuItem item in items)
				{
					if (item.Selected || IsChildItemSelected(item.ChildItems))
					{
						bRet = true;
						break;
					}
				}
			}

			return bRet;
		}

		/// <summary>
		/// Determines whether [is parent item selected] [the specified item].
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if [is parent item selected] [the specified item]; otherwise, <c>false</c>.</returns>
		private bool IsParentItemSelected(MenuItem item)
		{
			bool bRet = false;

			if ((item != null) && (item.Parent != null))
			{
				if (item.Parent.Selected)
					bRet = true;
				else
					bRet = IsParentItemSelected(item.Parent);
			}

			return bRet;
		}

		///// <summary>
		///// Clear the embedded header styles that ASP.NET automatically adds for the menu.
		///// </summary>
		///// <param name="e"></param>
		///// <remarks>
		///// Patch provided by LonelyRollingStar via CodePlex issue #2714:
		///// 
		///// The ASP.NET Menu control automatically adds several styles to the embedded header style. For example:
		///// 
		///// <c>.ctl00_ucMenu_MenuCBM_0 { background-color:white;visibility:hidden;display:none;position:absolute;left:0px;top:0px; }</c>
		///// 
		///// This is unnecessary and probably breaks your ability to fully style your menu with external stylesheets.
		///// 
		///// The culprit is an internal method of the Menu control called EnsureRenderSettings. It calls 
		///// <c>this.Page.Header.StyleSheet.CreateStyleRule()</c> several times, adding style rules to the embedded stylesheet. 
		///// <c>EnsureRenderSettings</c> is called at the beginning of the Menu's <c>OnPreRender</c> method. 
		///// 
		///// Hey, the menu adapter exposes OnPreRender! That means we're getting closer to an answer, right? 
		///// Right, but if we override <c>OnPreRender</c> and don't call the base implementation we'll be 
		///// missing some important functionality. This uses internal methods so we cannot emulate it in the menu adapter.
		///// 
		///// The solution is a bit of a hack, but it's quick and direct. We override <c>OnPreRender</c> and after calling 
		///// the base implementation as normal, we clear the embedded header styles that were just added.
		///// </remarks>
		//protected override void OnPreRender(EventArgs e)
		//{
		//	base.OnPreRender(e);

		//	// Clear the embedded header styles that ASP.NET automatically adds for the menu
		//	var selectorStyles = this.Page.Header.StyleSheet.GetPrivateField("_selectorStyles") as ArrayList;
		//	if (selectorStyles != null)
		//		selectorStyles.Clear();
		//}
	}
}
