#pragma checksum "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0ec1c27e3c9215c79f033b1a2b4a5aaecb1564d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Edit), @"mvc.1.0.view", @"/Views/Rookies/Edit.cshtml")]
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
#line 1 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\_ViewImports.cshtml"
using C__ASP_.Net_Core_MVC_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\_ViewImports.cshtml"
using C__ASP_.Net_Core_MVC_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0ec1c27e3c9215c79f033b1a2b4a5aaecb1564d", @"/Views/Rookies/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7538022d8580b6a43ae5a81db92364af6121d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
  
    ViewData["Title"] = "Edit Person";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 71, "\"", 113, 1);
#nullable restore
#line 6 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
WriteAttributeValue("", 78, Url.ActionLink("Index", "Rookies"), 78, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info mr-5\"><i class=\"fa fa-arrow-left mr-2\" aria-hidden=\"true\"></i>Back</a>\r\n<h3 class=\"d-inline-block mb-0\">");
#nullable restore
#line 7 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n    <hr />\r\n        <div>");
#nullable restore
#line 10 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
        Write(ViewBag.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"row\">\r\n    <div class=\"col-6 offset-3\">\r\n");
#nullable restore
#line 13 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
       Write(Html.LabelFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.EditorFor(model => model.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 37 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
       Write(Html.LabelFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 43 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
       Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 44 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 49 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 50 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 51 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 55 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
       Write(Html.LabelFor(model => model.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 56 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.EditorFor(model => model.BirthPlace, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 57 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.BirthPlace, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-6\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\LENOVO\Documents\C# ASP .Net Core MVC 2\Views\Rookies\Edit.cshtml"
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