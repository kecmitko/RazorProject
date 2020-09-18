using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication10.TagHelpers
{
    [HtmlTargetElement("my-first-tag-helper")]
    public class MyFirstTagHelper : TagHelper
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            var sb = new StringBuilder();
            sb.AppendFormat("<div style='border: 1px solid {0}'>", "red");
            sb.AppendFormat("<h1>{0}</h1>", this.Header);
            sb.AppendFormat("<p>This is some text for the banner! {0}</h1>", this.Text);
            sb.AppendFormat("<p>Active till {0} </p>", DateTime.Now);
            sb.AppendFormat("</div>");

            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
