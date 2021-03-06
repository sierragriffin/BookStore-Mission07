#pragma checksum "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3f78e33a7e2982b6c873d5b00a6878eb44ca2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineBookStore.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace OnlineBookStore.Views.Home
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
#line 4 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/_ViewImports.cshtml"
using OnlineBookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/_ViewImports.cshtml"
using OnlineBookStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3f78e33a7e2982b6c873d5b00a6878eb44ca2a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8654fd023d0c7aafaa0c64a78c1d5234e58cf44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::OnlineBookStore.Infrastructure.PaginationTagHelper __OnlineBookStore_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Index Page that lists Book Information-->\n");
#nullable restore
#line 2 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page - Book List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<!--Lists out information for each item stored in the database of type \"Book\"-->\n");
#nullable restore
#line 9 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
 foreach (Book book in Model.Books)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card card-outline-primary m-1 p-1\" style=\"background-color:#fcebe6\">\n\n        <div class=\"bg-faded p-1\">\n            <h3>\n                ");
#nullable restore
#line 15 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <span class=\"badge bg-info\" style=\"float:right\">\n");
            WriteLiteral("                    <small>");
#nullable restore
#line 18 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
                      Write(book.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                </span>\n            </h3>\n        </div>\n\n        <div class=\"card-text p-1\">\n            <ul>\n                <li>Author: ");
#nullable restore
#line 25 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
                       Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Publisher: ");
#nullable restore
#line 26 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
                          Write(book.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>ISBN: ");
#nullable restore
#line 27 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
                     Write(book.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Classification: ");
#nullable restore
#line 28 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
                               Write(book.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Category: ");
#nullable restore
#line 29 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
                         Write(book.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>Number of Pages: ");
#nullable restore
#line 30 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
                                Write(book.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ul>\n        </div>\n\n    </div>\n");
#nullable restore
#line 35 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--Dynamic page links, implements custom tag helpers-->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f3f78e33a7e2982b6c873d5b00a6878eb44ca2a8491", async() => {
                WriteLiteral("\n");
            }
            );
            __OnlineBookStore_Infrastructure_PaginationTagHelper = CreateTagHelper<global::OnlineBookStore.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__OnlineBookStore_Infrastructure_PaginationTagHelper);
#nullable restore
#line 38 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
__OnlineBookStore_Infrastructure_PaginationTagHelper.PageModel = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __OnlineBookStore_Infrastructure_PaginationTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OnlineBookStore_Infrastructure_PaginationTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 40 "/Users/sierragriffin/OneDrive - BYU Office 365/IS413/OnlineBookStore/OnlineBookStore/Views/Home/Index.cshtml"
__OnlineBookStore_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __OnlineBookStore_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OnlineBookStore_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __OnlineBookStore_Infrastructure_PaginationTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __OnlineBookStore_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n<!--Tag Helpers changes the code and turns it into html at runtime, they build dynamically-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
