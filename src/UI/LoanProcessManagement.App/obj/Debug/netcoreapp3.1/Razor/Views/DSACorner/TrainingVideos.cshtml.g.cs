#pragma checksum "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\TrainingVideos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6889cc015be7f199ac0d42c5cd2249ac6bbad193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DSACorner_TrainingVideos), @"mvc.1.0.view", @"/Views/DSACorner/TrainingVideos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6889cc015be7f199ac0d42c5cd2249ac6bbad193", @"/Views/DSACorner/TrainingVideos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DSACorner_TrainingVideos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\TrainingVideos.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Training Videos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .tile .tile-content {
        margin: 10px auto !important;
    }

    .tile .brand, .tile .tile-status {
        min-height: 50px !important;
        font-size: 17px;
        padding: 10px;
    }
</style>
<div class=""container app"">
    <div class=""col-sm-12"">
        <div data-effect=""helix"" id=""panels"" class=""panel panel-info effect-helix in"" style=""transition: all 0.7s ease-in-out 0s;"">

            <div class=""panel-heading""><h5>Training Videos</h5></div>
            <div class=""panel-body"">
                <div class=""card"" style=""padding:5px;"">
                    <ul class=""nav nav-pills nav-sidebar flex-column""
                        data-widget=""treeview"">
");
#nullable restore
#line 26 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\TrainingVideos.cshtml"
                         foreach (var itm in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 973, "\"", 989, 1);
#nullable restore
#line 29 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\TrainingVideos.cshtml"
WriteAttributeValue("", 980, itm.Link, 980, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                                    <i class=\"far fa-circle nav-icon\"></i>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 32 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\TrainingVideos.cshtml"
                                   Write(itm.TrainingVideoName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 36 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\DSACorner\TrainingVideos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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