#pragma checksum "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8450d8e03783a740f092628bc953f4b35b2b06c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_DisplayTemplates_SearchResultPageItemModel), @"mvc.1.0.view", @"/Views/Search/DisplayTemplates/SearchResultPageItemModel.cshtml")]
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
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8450d8e03783a740f092628bc953f4b35b2b06c4", @"/Views/Search/DisplayTemplates/SearchResultPageItemModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_DisplayTemplates_SearchResultPageItemModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.SearchResultPageItemModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row search-tile\">\r\n    <div class=\"col-md-4 col-lg-3\">\r\n");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
         if (!string.IsNullOrEmpty(Model.ImagePath))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 202, "\"", 219, 1);
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
WriteAttributeValue("", 209, Model.Url, 209, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 220, "\"", 240, 1);
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
WriteAttributeValue("", 228, Model.Title, 228, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 264, "\"", 286, 1);
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
WriteAttributeValue("", 270, Model.ImagePath, 270, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 287, "\"", 305, 1);
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
WriteAttributeValue("", 293, Model.Title, 293, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 306, "\"", 326, 1);
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
WriteAttributeValue("", 314, Model.Title, 314, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" />\r\n            </a>\r\n");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-8 col-lg-9 search-tile-content\">\r\n        <h3 class=\"h4 search-tile-title\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 510, "\"", 527, 1);
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
WriteAttributeValue("", 517, Model.Url, 517, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </h3>\r\n        <div class=\"search-tile-badge\">");
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
                                  Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"search-tile-subtitle\">");
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
                                     Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 18 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Search\DisplayTemplates\SearchResultPageItemModel.cshtml"
        Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.SearchResultPageItemModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
