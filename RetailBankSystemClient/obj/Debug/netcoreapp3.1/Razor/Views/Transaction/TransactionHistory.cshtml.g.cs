#pragma checksum "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a385908aac7a1cd9ef7c9c68b88b6a519cb75481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_TransactionHistory), @"mvc.1.0.view", @"/Views/Transaction/TransactionHistory.cshtml")]
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
#line 1 "E:\RetailBankingSystem\RetailBankSystemClient\Views\_ViewImports.cshtml"
using RetailBankSystemClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RetailBankingSystem\RetailBankSystemClient\Views\_ViewImports.cshtml"
using RetailBankSystemClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a385908aac7a1cd9ef7c9c68b88b6a519cb75481", @"/Views/Transaction/TransactionHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a73e3a792625f43bb39507199164f87925f61d", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_TransactionHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RetailBankSystemClient.ViewModels.TransactionHistoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
  
    ViewData["Title"] = "TransactionHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Transaction History</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.source_balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.destination_balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfTransaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span>Rs.</span> ");
#nullable restore
#line 46 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
                            Write(Html.DisplayFor(modelItem => item.source_balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span>Rs.</span>  ");
#nullable restore
#line 49 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
                             Write(Html.DisplayFor(modelItem => item.destination_balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfTransaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 56 "E:\RetailBankingSystem\RetailBankSystemClient\Views\Transaction\TransactionHistory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RetailBankSystemClient.ViewModels.TransactionHistoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591