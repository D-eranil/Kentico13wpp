#pragma checksum "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\Sections\_DancingGoat_TwoColumnSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a6f2e82bcf7b0f86306a9efe74c446cec290107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_Sections__DancingGoat_TwoColumnSection), @"mvc.1.0.view", @"/Components/Sections/_DancingGoat_TwoColumnSection.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\Sections\_DancingGoat_TwoColumnSection.cshtml"
using DancingGoat.Sections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6f2e82bcf7b0f86306a9efe74c446cec290107", @"/Components/Sections/_DancingGoat_TwoColumnSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_Sections__DancingGoat_TwoColumnSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kentico.PageBuilder.Web.Mvc.ComponentViewModel<ThemeSectionProperties>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper __Kentico_Content_Web_Mvc_WidgetZoneTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 116, "\"", 174, 3);
            WriteAttributeValue("", 124, "row", 124, 3, true);
            WriteAttributeValue(" ", 127, "row--with-cols-padding", 128, 23, true);
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13wpp\DancingGoatCore\Components\Sections\_DancingGoat_TwoColumnSection.cshtml"
WriteAttributeValue(" ", 150, Model.Properties.Theme, 151, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"col-md-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget-zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a6f2e82bcf7b0f86306a9efe74c446cec2901074929", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_WidgetZoneTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_WidgetZoneTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget-zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a6f2e82bcf7b0f86306a9efe74c446cec2901075875", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_WidgetZoneTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_WidgetZoneTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kentico.PageBuilder.Web.Mvc.ComponentViewModel<ThemeSectionProperties>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
