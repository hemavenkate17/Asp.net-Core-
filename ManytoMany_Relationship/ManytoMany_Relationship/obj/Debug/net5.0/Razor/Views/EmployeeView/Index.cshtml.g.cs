#pragma checksum "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a5f1b544b27ba09bef805e5fec81437276d636"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeView_Index), @"mvc.1.0.view", @"/Views/EmployeeView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0a5f1b544b27ba09bef805e5fec81437276d636", @"/Views/EmployeeView/Index.cshtml")]
    public class Views_EmployeeView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ManytoMany_Relationship.Model.Employees>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.wfm_manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.lockstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.profile_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.wfm_manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.lockstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.profile_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1983, "\"", 2015, 1);
#nullable restore
#line 70 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
WriteAttributeValue("", 1998, item.employee_id, 1998, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2068, "\"", 2100, 1);
#nullable restore
#line 71 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
WriteAttributeValue("", 2083, item.employee_id, 2083, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2155, "\"", 2187, 1);
#nullable restore
#line 72 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
WriteAttributeValue("", 2170, item.employee_id, 2170, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "D:\Asp.net core learning\Task\ManytoMany_Relationship\ManytoMany_Relationship\Views\EmployeeView\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ManytoMany_Relationship.Model.Employees>> Html { get; private set; }
    }
}
#pragma warning restore 1591