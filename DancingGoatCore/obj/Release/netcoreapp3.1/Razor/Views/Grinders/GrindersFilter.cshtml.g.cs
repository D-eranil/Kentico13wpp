#pragma checksum "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Grinders\GrindersFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d4d6f65255f12dd9b5656c69d696dc97a7aeab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grinders_GrindersFilter), @"mvc.1.0.view", @"/Views/Grinders/GrindersFilter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d4d6f65255f12dd9b5656c69d696dc97a7aeab", @"/Views/Grinders/GrindersFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Grinders_GrindersFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.GrinderFilterViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Grinders\GrindersFilter.cshtml"
Write(HtmlLocalizer["Manufacturer"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Grinders\GrindersFilter.cshtml"
Write(Html.EditorFor(model => Model.Manufacturers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h4>");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Grinders\GrindersFilter.cshtml"
Write(HtmlLocalizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Grinders\GrindersFilter.cshtml"
Write(Html.EditorFor(model => Model.Prices));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h4>");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Grinders\GrindersFilter.cshtml"
Write(HtmlLocalizer["Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Views\Grinders\GrindersFilter.cshtml"
Write(Html.EditorFor(model => Model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.GrinderFilterViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
