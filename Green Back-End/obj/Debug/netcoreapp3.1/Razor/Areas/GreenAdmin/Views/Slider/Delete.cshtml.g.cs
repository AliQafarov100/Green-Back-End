#pragma checksum "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\Slider\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "202d78bb7a26a6f938d31a0d5b03e5a863e820af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GreenAdmin_Views_Slider_Delete), @"mvc.1.0.view", @"/Areas/GreenAdmin/Views/Slider/Delete.cshtml")]
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
#line 1 "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\_ViewImports.cshtml"
using Green_Back_End.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\_ViewImports.cshtml"
using Green_Back_End.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202d78bb7a26a6f938d31a0d5b03e5a863e820af", @"/Areas/GreenAdmin/Views/Slider/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13393cdd994ddcb5658068444a66a8f3267cf51", @"/Areas/GreenAdmin/Views/_ViewImports.cshtml")]
    public class Areas_GreenAdmin_Views_Slider_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Slider>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\Slider\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <p>Id</p>\r\n        <h4>");
#nullable restore
#line 9 "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\Slider\Delete.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div>\r\n        <p>Title</p>\r\n        <h4>");
#nullable restore
#line 13 "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\Slider\Delete.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div>\r\n        <p>Description</p>\r\n        <h4>");
#nullable restore
#line 17 "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\Slider\Delete.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div>\r\n        <p>Order</p>\r\n        <h4>");
#nullable restore
#line 21 "C:\Users\M S I\source\repos\Green Back-End\Green Back-End\Areas\GreenAdmin\Views\Slider\Delete.cshtml"
       Write(Model.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "202d78bb7a26a6f938d31a0d5b03e5a863e820af5188", async() => {
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-danger\">\r\n        Delete\r\n    </button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Slider> Html { get; private set; }
    }
}
#pragma warning restore 1591
