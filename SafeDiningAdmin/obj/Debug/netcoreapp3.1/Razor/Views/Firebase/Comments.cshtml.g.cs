#pragma checksum "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c99d2c2fde16636a85d03cfd51a2f951e082711c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Firebase_Comments), @"mvc.1.0.view", @"/Views/Firebase/Comments.cshtml")]
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
#line 1 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\_ViewImports.cshtml"
using SafeDiningAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\_ViewImports.cshtml"
using SafeDiningAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99d2c2fde16636a85d03cfd51a2f951e082711c", @"/Views/Firebase/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9b0d323086c3096abcfaa2a9b7534401de8aa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Firebase_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SafeDiningAdmin.Models.FirebaseReviews>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
  
    ViewData["Title"] = "Comments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Comments</h1>\r\n\r\n<table class=\"table\">\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
       Write(Html.DisplayNameFor(model => model.rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
       Write(Html.DisplayNameFor(model => model.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 28 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
       Write(Html.DisplayNameFor(model => model.timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
               Write(Html.DisplayFor(modelItem => item.timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
               Write(Html.ActionLink("DeleteComment", "DeleteComment", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>No Review for this Restaurant!</h2>\r\n");
#nullable restore
#line 59 "C:\Users\User\source\repos\SafeDiningAdmin\SafeDiningAdmin\Views\Firebase\Comments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SafeDiningAdmin.Models.FirebaseReviews>> Html { get; private set; }
    }
}
#pragma warning restore 1591