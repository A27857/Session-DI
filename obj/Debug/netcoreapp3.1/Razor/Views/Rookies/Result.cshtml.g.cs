#pragma checksum "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04fa632ecf87b1181f569520010b9202da4f436f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Result), @"mvc.1.0.view", @"/Views/Rookies/Result.cshtml")]
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
#line 1 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\_ViewImports.cshtml"
using SessionDI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\_ViewImports.cshtml"
using SessionDI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Result.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fa632ecf87b1181f569520010b9202da4f436f", @"/Views/Rookies/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52b4fd03dca6eec01964923ddc24fe6066e6410", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Result.cshtml"
  
    ViewData["Title"] = "Result Page";
    var name = HttpContextAccessor.HttpContext.Session.GetString("DELETE_NAME_TEMP");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 233, "\"", 275, 1);
#nullable restore
#line 8 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Result.cshtml"
WriteAttributeValue("", 240, Url.ActionLink("Index", "Rookies"), 240, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info mr-5\"><i class=\"fa fa-arrow-left mr-2\"\r\n            aria-hidden=\"true\"></i>Back</a>\r\n    <h3 class=\"d-inline-block mb-0\">");
#nullable restore
#line 10 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Result.cshtml"
                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n<hr />\r\n<h3 style=\"color: green;\">Person ");
#nullable restore
#line 13 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Result.cshtml"
                            Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" was removed from the list successfully!</h3>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
