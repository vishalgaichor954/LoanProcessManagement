#pragma checksum "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\DSACorner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4157132e988880096de1c94f8d97afe6a3170f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DSACorner_DSACorner), @"mvc.1.0.view", @"/Views/DSACorner/DSACorner.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4157132e988880096de1c94f8d97afe6a3170f60", @"/Views/DSACorner/DSACorner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DSACorner_DSACorner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\DSACorner.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "DSA Corner";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .tile .tile-content {
        margin: 10px auto !important;
    }

    .tile .brand, .tile .tile-status {
        min-height: 30px !important;
    }
</style>
<div class=""container"">
</div>
<hr />
<div class=""container report-list"" style=""margin-top: 40px;"" runat=""server"" id=""grid"">
    <ul class=""nav tiles nomargin"">
");
#nullable restore
#line 22 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\DSACorner.cshtml"
         foreach (var itm in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\'col-lg-3 col-md-4 col-sm-6 col-xs-6\'>\r\n                <div class=\"tile bluediv bg-color-blueLight icon\">\r\n                    <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 660, "\"", 676, 1);
#nullable restore
#line 26 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\DSACorner.cshtml"
WriteAttributeValue("", 667, itm.Link, 667, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"tile-content\"><i><img");
            BeginWriteAttribute("src", " src=\"", 737, "\"", 752, 1);
#nullable restore
#line 27 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\DSACorner.cshtml"
WriteAttributeValue("", 743, itm.Icon, 743, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></i></div>\r\n                        <div class=\"brand\">");
#nullable restore
#line 28 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\DSACorner.cshtml"
                                      Write(itm.DSAName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </a>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 32 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\DSACorner.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591