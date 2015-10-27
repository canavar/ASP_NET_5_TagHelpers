using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace ASP_NET_5_TagHelpers
{
    public class InputGroupTagHelper : TagHelper
    {
        public string Id { set; get; }

        public string Domain { set; get; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var br = new TagBuilder("br").ToString(TagRenderMode.SelfClosing);
            // Outer Tag : 
            output.TagName = "div";
            output.Attributes.Add("class", "input-group");

            // Inner Input : 
            var name = new TagBuilder("input");
            name.MergeAttribute("type", "text");
            name.MergeAttribute("class", "form-control");
            name.MergeAttribute("placeholder", "Recipient's username");
            name.MergeAttribute("aria-describedby", this.Id);

            // Span : 
            var span = new TagBuilder("span");
            span.MergeAttribute("class", "input-group-addon");
            span.MergeAttribute("id", this.Id);
            span.InnerHtml = this.Domain;
            
            output.Content.SetContent(name.ToString() + span.ToString());
        }
    }
}
