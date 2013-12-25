using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace NotAClue.Web.UI.BootstrapWebControls
{
	public static class HelperExtensionMethods
	{

		static public void WriteTargetAttribute(this HtmlTextWriter writer, string targetValue)
		{
			if ((writer != null) && (!String.IsNullOrEmpty(targetValue)))
			{
				//  If the targetValue is _blank then we have an opportunity to use attributes other than "target"
				//  which allows us to be compliant at the XHTML 1.1 Strict level. Specifically, we can use a combination
				//  of "onclick" and "onkeypress" to achieve what we want to achieve when we used to render
				//  target='blank'.
				//
				//  If the targetValue is other than _blank then we fall back to using the "target" attribute.
				//  This is a heuristic that can be refined over time.
				if (targetValue.Equals("_blank", StringComparison.OrdinalIgnoreCase))
				{
					string js = "window.open(this.href, '_blank', ''); return false;";
					writer.WriteAttribute("onclick", js);
					writer.WriteAttribute("onkeypress", js);
				}
				else
				{
					writer.WriteAttribute("target", targetValue);
				}
			}
		}
	}
}
