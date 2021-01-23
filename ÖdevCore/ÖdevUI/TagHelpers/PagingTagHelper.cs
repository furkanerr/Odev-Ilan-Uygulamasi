using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ÖdevUI.TagHelpers
{
    [HtmlTargetElement("ads-list-pager")]
    public class PagingTagHelper:TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int  PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName="div";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='pagination justify-content-center'>");

            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat("<li class='list-group-item '>");
                stringBuilder.AppendFormat("<a href='/ilan/ilanlar?page={0}&category={1}'>{2}</a>",
                    i,CurrentCategory,i);
                stringBuilder.Append("</li>");
            }

            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}