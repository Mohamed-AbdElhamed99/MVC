using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MVC.Migrations;
using System;

namespace MVC.HTMLBuilder
{
    public static class TextExtention
    {
        public static string TextComponent(this IHtmlHelper helper , string target)
        {
            return $"<div class=\"form-group row\">\r\n    <label asp-for=\"{target}\" class=\"col-sm-3 col-form-label\">{target}</label>\r\n    <div class=\"col-sm-9\">\r\n        <input asp-for=\"{target}\" class=\"form-control\">\r\n        <span asp-validation-for=\"{target}\" class=\"text-danger\"></span>\r\n    </div>\r\n</div>";
        }
    }
}
