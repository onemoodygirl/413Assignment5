#pragma checksum "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06e18fd8836af741e123ed14dbc14ce7e9471a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/_ViewImports.cshtml"
using MoodyAssignment5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/_ViewImports.cshtml"
using MoodyAssignment5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e18fd8836af741e123ed14dbc14ce7e9471a9c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8825ced67b5607cbd897e3891e73a6ac0d1a5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">An Awesome List of Books to Read!</h1>\n    <br />\n</div>\n\n");
#nullable restore
#line 10 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n    <h3>");
#nullable restore
#line 13 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
   Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <p>Author: ");
#nullable restore
#line 14 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
          Write(x.AuthorFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
                         Write(x.AuthorLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Publisher: ");
#nullable restore
#line 15 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
             Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>ISBN: ");
#nullable restore
#line 16 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
        Write(x.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Classification/Category: ");
#nullable restore
#line 17 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
                           Write(x.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
                                     Write(x.Cat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Price: $");
#nullable restore
#line 18 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
          Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n");
#nullable restore
#line 20 "/Users/mallorymoody/Projects/MoodyAssignment5/MoodyAssignment5/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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