#pragma checksum "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "319a2b907ece7ff0e32628fc6b99a78e23df2104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 2 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\_ViewImports.cshtml"
using ASP.NetCV.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\_ViewImports.cshtml"
using ASP.NetCV.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\_ViewImports.cshtml"
using ASP.NetCV.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"319a2b907ece7ff0e32628fc6b99a78e23df2104", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb577c3bb17a1433fcf34e0434a7299160d4e58", @"/_ViewImports.cshtml")]
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Portfolio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Open Imagination"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-8"">

    <!-- MAIN NAV -->

    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">PORTFOLIO</h5>

        <!-- PORTFOLIO -->
        <section class=""portfolio padding-top-50 padding-bottom-50"">
            <!-- Work Filter -->
            <ul class=""tabs portfolio-filter text-center margin-bottom-30"">
                <li class=""filter"" data-filter=""all"">all</li>
                <li class=""filter"" data-filter="".brand"">Branding</li>
                <li class=""filter"" data-filter="".design"">designing</li>
                <li class=""filter"" data-filter="".photo"">photography</li>
                <li class=""filter"" data-filter="".visual"">visual design</li>
            </ul>

            <!-- PORTFOLIO ITEMS -->
            <div id=""Container"" class=""item-space row col-3"">
");
#nullable restore
#line 27 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <article class=\"portfolio-item mix  design photo visual\">\r\n                        <div class=\"portfolio-image\">\r\n                            <a href=\"#.\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "319a2b907ece7ff0e32628fc6b99a78e23df21045430", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1221, "~/uploads/images/", 1221, 17, true);
#nullable restore
#line 32 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 1238, item.ImgPath, 1238, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </a>
                            <div class=""portfolio-overlay style-4"">
                                <div class=""detail-info"">
                                    <div class=""position-center-center"">
                                        <h3 class=""no-margin"">");
#nullable restore
#line 36 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <span><a href=\"#.\">");
#nullable restore
#line 37 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml"
                                                      Write(item.NameDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span> <a href=\"#.\" class=\"go\"><i");
            BeginWriteAttribute("class", " class=\"", 1652, "\"", 1670, 1);
#nullable restore
#line 37 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1660, item.Icon, 1660, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a> <a href=\"#.\" class=\"go\"><i class=\"fa fa-link\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </article>\r\n");
#nullable restore
#line 43 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\Portfolio\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!-- ITEM -->\r\n                <!-- ITEM -->\r\n             \r\n            </div>\r\n        </section>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
