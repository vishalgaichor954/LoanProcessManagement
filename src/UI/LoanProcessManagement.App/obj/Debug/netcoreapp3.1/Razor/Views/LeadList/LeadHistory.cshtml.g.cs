#pragma checksum "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645a3ba2f92ee4e1bac74154f46c12834ff5f040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeadList_LeadHistory), @"mvc.1.0.view", @"/Views/LeadList/LeadHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645a3ba2f92ee4e1bac74154f46c12834ff5f040", @"/Views/LeadList/LeadHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LeadList_LeadHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoanProcessManagement.Application.Features.LeadList.Query.LeadHistory.LeadHistoryQueryVm>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "LeadHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    table {
        white-space: nowrap;
        overflow-x: auto;
    }
    table thead th {
            white-space: nowrap;
        }
</style>
<div class=""container app"">
    <div class=""col-sm-12"">
        <div data-effect=""helix"" id=""panels"" class=""panel panel-info effect-helix in"" style=""transition: all 0.7s ease-in-out 0s;"">
            <div class=""panel-heading""><h5>History</h5></div>
            <div class=""panel-body"">
                <div class=""card"" style=""padding:5px;"">
                    <div id=""alertMsg"" visible=""false"" runat=""server"">
                        <asp:Label ID=""lblAlert"" runat=""server"" Style=""color: red""></asp:Label>
                        <div style=""margin-bottom: 10px""></div>
                    </div>
                    <table id=""History"" class=""table table-responsive-lg"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 29 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                               Write(Html.DisplayNameFor(model => model.Stage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 32 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                               Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 35 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 38 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                               Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 41 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                               Write(Html.DisplayNameFor(model => model.ReasonForReject));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </th>
                                <th>
                                    Product
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 49 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 53 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Stage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 56 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                                          
                                            var date = item.StartDate.ToString().Split(" ");
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
#nullable restore
#line 59 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                                   Write(date[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 62 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 65 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 68 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ReasonForReject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 71 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ProductsSold));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 74 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 80 "D:\Task1\LoanProcessManagement\src\UI\LoanProcessManagement.App\Views\LeadList\LeadHistory.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_Tabs.cshtml", (string)@ViewBag.lead_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </div>
</div>
<script>
    $(document).ready(function () {
        var usrTable = $('#History').dataTable({
            ""oLanguage"": {
                ""sZeroRecords"": ""No Records to Display"",
                ""sSearch"": ""Search ""
            },
            ""scrollX"": true,
            ""scrollCollapse"": true,
            ""iDisplayLength"": 15,
            ""aLengthMenu"": [[25, 50, 100, 200, 500], [25, 50, 100, 200, 500]],
            ""bSortClasses"": false,
            ""bPaginate"": true,
            ""bAutoWidth"": false,
            ""bProcessing"": true,
            ""bDestroy"": true
        });
        $('.btn1').click(function (e) {
            $('.btn1').removeClass(""selected"");
            $(e.target).addClass(""selected"");
        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoanProcessManagement.Application.Features.LeadList.Query.LeadHistory.LeadHistoryQueryVm>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591