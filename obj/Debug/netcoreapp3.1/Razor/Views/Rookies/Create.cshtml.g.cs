#pragma checksum "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e67bfa0cf2fc6a843182c759b6d5f7315a07810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Create), @"mvc.1.0.view", @"/Views/Rookies/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e67bfa0cf2fc6a843182c759b6d5f7315a07810", @"/Views/Rookies/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52b4fd03dca6eec01964923ddc24fe6066e6410", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
  
    ViewData["Title"] = "Create New Person";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 77, "\"", 119, 1);
#nullable restore
#line 6 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
WriteAttributeValue("", 84, Url.ActionLink("Index", "Rookies"), 84, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info mr-5\"><i class=\"fa fa-arrow-left mr-2\" aria-hidden=\"true\"></i>Back</a>\r\n<h3 class=\"d-inline-block mb-0\">");
#nullable restore
#line 7 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n    <hr />\r\n        <div>");
#nullable restore
#line 10 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
        Write(ViewBag.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"row\">\r\n    <div class=\"col-6 offset-3\">\r\n");
#nullable restore
#line 13 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
       Write(Html.LabelFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.EditorFor(model => model.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 37 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
       Write(Html.LabelFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 43 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
       Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 44 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 49 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 50 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 51 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 55 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
       Write(Html.LabelFor(model => model.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 56 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.EditorFor(model => model.BirthPlace, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 57 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.BirthPlace, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\LENOVO\Documents\C# ASP .Net Core Session DI\Views\Rookies\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
