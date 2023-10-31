using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BookstoreMVC.Helpers
{

    public class CutomEmailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:francisgbohunmi@gmail.com");
            output.Content.SetContent("my-email");
        }
    }
}