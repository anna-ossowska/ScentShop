#pragma checksum "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46ae3e812a71999123f2124d7b005363cb5904ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfume_List), @"mvc.1.0.view", @"/Views/Perfume/List.cshtml")]
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
#line 1 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\_ViewImports.cshtml"
using ScentShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\_ViewImports.cshtml"
using ScentShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\_ViewImports.cshtml"
using ScentShop.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ae3e812a71999123f2124d7b005363cb5904ad", @"/Views/Perfume/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1176cd2a4e1d2057cb7f0b63a83271defc30c9fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfume_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PerfumesListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Type text here"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Perfume", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"bannerlist\">\r\n    <div class=\"bannerlist-content\">\r\n        <h3>Get 20% off</h3>\r\n        <div class=\"bannerlist-divider\"></div>\r\n        <p>first purchase</p>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("<div id=\"list-container\">\r\n    <div class=\"list-sortdata\">\r\n");
            WriteLiteral("        <div class=\"list-sortdata-group\">");
#nullable restore
#line 16 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                    Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"divider-horizontal\"></div>\r\n\r\n");
            WriteLiteral("        <div class=\"list-sortdata-group\">\r\n            <h3 class=\"filter-header\">Filter by</h3>\r\n            <ul class=\"filter-list\">\r\n                <li class=\"filter-item\">");
#nullable restore
#line 23 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                   Write(Html.ActionLink("Product Name", "List", new { sortOrder = ViewBag.NameSortParam }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"filter-item\">");
#nullable restore
#line 24 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                   Write(Html.ActionLink("Price", "List", new { sortOrder = ViewBag.PriceSortParam }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"filter-item\">");
#nullable restore
#line 25 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                   Write(Html.ActionLink("Brand", "List", new { sortOrder = ViewBag.BrandSortParam }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"filter-item\">");
#nullable restore
#line 26 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                   Write(Html.ActionLink("Capacity (ml)", "List", new { sortOrder = ViewBag.CapacitySortParam }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"divider-horizontal\"></div>\r\n\r\n");
            WriteLiteral(@"        <div class=""list-sortdata-group"">
            <h3 class=""populartags-header"">Popular tags</h3>
            <span class=""tag-light"">Gucci</span>
            <span class=""tag-light"">Dior</span>
            <span class=""tag-light"">Pour Homme</span>
            <span class=""tag-light"">Chanel</span>
            <span class=""tag-light"">J'adore</span>
            <span class=""tag-light"">Versace</span>
        </div>
    </div>

");
            WriteLiteral("    <div class=\"list-search\">\r\n        <div class=\"list-search-box\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ae3e812a71999123f2124d7b005363cb5904ad8899", async() => {
                WriteLiteral("\r\n                <div class=\"search-form-group\">\r\n                    <div class=\"search-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46ae3e812a71999123f2124d7b005363cb5904ad9286", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 49 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <button class=\"search-bt\" type=\"submit\" value=\"Filter\">\r\n                            <i class=\"fas fa-search\"></i>\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n");
            WriteLiteral("        <div class=\"list-cards\">\r\n");
#nullable restore
#line 61 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
             foreach (var perfume in Model.Perfumes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46ae3e812a71999123f2124d7b005363cb5904ad12778", async() => {
                WriteLiteral("\r\n                    <div class=\"list-card\">\r\n                        <div class=\"list-card-bg\">\r\n                            <img class=\"list-card-picture\"");
                BeginWriteAttribute("src", " src=\"", 2723, "\"", 2746, 1);
#nullable restore
#line 66 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
WriteAttributeValue("", 2729, perfume.ImageUrl, 2729, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2747, "\"", 2753, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"list-card-details\">\r\n                            <h3 class=\"name\">");
#nullable restore
#line 69 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                        Write(perfume.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                            <p class=\"brand\">");
#nullable restore
#line 70 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                        Write(perfume.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p class=\"price\">$");
#nullable restore
#line 71 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                         Write(perfume.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
                                                                                          WriteLiteral(perfume.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\tomas\Documents\anna\repos\ScentShop\ScentShop\ScentShop\Views\Perfume\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PerfumesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
