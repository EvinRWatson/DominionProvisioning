#pragma checksum "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6e73a196fb056521053a5e964dfd5731a15ccd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StockLists_Index), @"mvc.1.0.view", @"/Views/StockLists/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e73a196fb056521053a5e964dfd5731a15ccd9", @"/Views/StockLists/Index.cshtml")]
    public class Views_StockLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominion.Models.StockList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrgID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrgID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 972, "\"", 1000, 1);
#nullable restore
#line 40 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
WriteAttributeValue("", 987, item.StockID, 987, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1053, "\"", 1081, 1);
#nullable restore
#line 41 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
WriteAttributeValue("", 1068, item.StockID, 1068, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1136, "\"", 1164, 1);
#nullable restore
#line 42 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
WriteAttributeValue("", 1151, item.StockID, 1151, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\EvinW\Documents\DominionProject\DominionProvisioning\App\Dominion\Views\StockLists\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominion.Models.StockList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
