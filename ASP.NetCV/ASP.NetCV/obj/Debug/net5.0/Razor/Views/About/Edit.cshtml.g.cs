#pragma checksum "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\About\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47895b9a9f668f56d6ed6b3d8193dc89e8536a02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Edit), @"mvc.1.0.view", @"/Views/About/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47895b9a9f668f56d6ed6b3d8193dc89e8536a02", @"/Views/About/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb577c3bb17a1433fcf34e0434a7299160d4e58", @"/_ViewImports.cshtml")]
    public class Views_About_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\ASP.NETCV\ASP.NetCV\ASP.NetCV\Views\About\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-8"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">Bio & Skills</h5>
        <div class=""bio-info padding-30"">
            <textarea class=""form-control"" placeholder=""Write your description here""></textarea>
            <div class=""skills margin-top-50"">

                <!-- SKILLS -->
                <h6>Add A Skill</h6>

                <!-- Sound Engineering -->
                <div class=""row"">

                    <!-- Categories -->
                    <div class=""col-sm-6"">
                        <select class=""selectpicker"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47895b9a9f668f56d6ed6b3d8193dc89e8536a024089", async() => {
                WriteLiteral(" All Categories");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47895b9a9f668f56d6ed6b3d8193dc89e8536a025084", async() => {
                WriteLiteral("Web Design");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47895b9a9f668f56d6ed6b3d8193dc89e8536a026074", async() => {
                WriteLiteral("Development");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                        <span class=""add-custm"">or <a href=""#.""> Add A Custom Category</a></span>
                    </div>

                    <!--  Skills -->
                    <div class=""col-sm-6"">
                        <select class=""selectpicker"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47895b9a9f668f56d6ed6b3d8193dc89e8536a027373", async() => {
                WriteLiteral("Skills");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47895b9a9f668f56d6ed6b3d8193dc89e8536a028359", async() => {
                WriteLiteral("HTML5 CSS3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47895b9a9f668f56d6ed6b3d8193dc89e8536a029349", async() => {
                WriteLiteral("Photoshop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                        <span class=""add-custm"">or <a href=""#.""> Add A Custom Skills</a></span>
                    </div>
                </div>

                <!-- Disply Type -->
                <div class=""disply-type"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""radio radio-inline"">
                                <input type=""radio"" id=""inlineRadio1"" value=""option1"" name=""radioInline"">
                                <label for=""inlineRadio1""> Display As Bar </label>
                            </div>
                        </div>
                        <div class=""col-sm-8"">
                            <div class=""radio radio-inline"">
                                <input type=""radio"" id=""inlineRadio2"" value=""option1"" name=""radioInline"">
                                <label for=""inlineRadio2""> Display As Tag </label>
                            </div>
          ");
            WriteLiteral(@"              </div>
                    </div>
                </div>

                <!-- Skill Info -->
                <div class=""skill-type-info"">
                    <label>
                        Skill Level
                        <input type=""text"" class=""form-control"" placeholder=""0"">
                    </label>
                    <label>
                        Skill Description
                        <textarea class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2839, "\"", 2853, 0);
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                    </label>
                </div>
                <!-- ADD MORE-->
                <a href=""#"" class=""btn""><i class=""fa fa-plus""></i> Add Skill</a>
            </div>
        </div>
    </div>

    <!-- Professional Experience -->
    <div class=""inside-sec margin-top-30"">
        <!-- Professional Experience -->
        <h5 class=""tittle"">Professional Experience</h5>
        <div class=""padding-30 exp-history"">

            <!-- ADD Professional -->
            <div class=""exp"">
                <div class=""row"">
                    <div class=""col-sm-7"">
                        <label>
                            Duration
                            <input type=""text"" class=""form-control"" placeholder=""YYYY - YYYY"">
                        </label>
                        <label>
                            Job Title
                            <input type=""text"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3806, "\"", 3820, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </label>\r\n                        <label>\r\n                            Company Name\r\n                            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4000, "\"", 4014, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </label>\r\n                        <label>\r\n                            Location\r\n                            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4190, "\"", 4204, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </label>
                    </div>

                    <!-- UPLOAD IMG -->
                    <div class=""col-sm-5"">
                        <label class=""btn-file"">
                            <i class=""fa fa-camera""></i> Click to attach logo
                            <input type=""file"" style=""display: none;"">
                        </label>
                    </div>

                    <!-- ADD DETAILS -->
                    <div class=""col-sm-12"">
                        <label>
                            Details
                            <textarea class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4837, "\"", 4851, 0);
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                        </label>
                        <!-- ADD MORE-->
                        <a href=""#"" class=""btn margin-top-20""><i class=""fa fa-plus""></i> Add Experience</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Academic Background -->
    <div class=""inside-sec margin-top-30"">
        <!-- Academic Background -->
        <h5 class=""tittle"">Academic Background</h5>
        <div class=""padding-30 exp-history"">

            <!-- ADD EXP -->
            <div class=""exp"">
                <div class=""row"">
                    <div class=""col-sm-7"">
                        <label>
                            Qualification
                            <input type=""text"" class=""form-control"" placeholder=""YYYY - YYYY"">
                        </label>
                        <label>
                            Degree
                            <input type=""text"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 5852, "\"", 5866, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </label>\r\n                        <label>\r\n                            Institute / University Name\r\n                            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6061, "\"", 6075, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </label>\r\n                        <label>\r\n                            Year of Obtention\r\n                            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6260, "\"", 6274, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </label>
                    </div>

                    <!-- UPLOAD IMG -->
                    <div class=""col-sm-5"">
                        <label class=""btn-file"">
                            <i class=""fa fa-camera""></i> Click to add diploma
                            <input type=""file"" style=""display: none;"">
                        </label>
                    </div>

                    <!-- ADD DETAIL -->
                    <div class=""col-sm-12"">
                        <label>
                            Details
                            <textarea class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6906, "\"", 6920, 0);
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                        </label>
                        <!-- ADD MORE -->
                        <a href=""#"" class=""btn margin-top-20""><i class=""fa fa-plus""></i> Add Experience</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Save Info -->
    <div class=""save-info""> <a href=""#."" class=""btn"">Cancel</a> <a href=""#."" class=""btn"">Save Settings</a> </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
