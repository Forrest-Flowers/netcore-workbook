using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.TagHelpers
{
    [HtmlTargetElement("*", Attributes = "day-of-the-week")]
    public class DayOfWeekTagHelper : TagHelper
    {
        public DateTime TodoDate { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var stringDate = TodoDate > DateTime.Now.AddDays(-7)
                ? TodoDate.DayOfWeek.ToString()
                : TodoDate.ToString("MM/dd/yyyy");

            output.Content.SetContent(stringDate);
        }
    }
}
