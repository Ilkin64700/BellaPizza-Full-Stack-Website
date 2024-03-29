#pragma checksum "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769548685a69f80d65ce0b894f0b5e9051a324c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuProduct_MenuProduct), @"mvc.1.0.view", @"/Views/MenuProduct/MenuProduct.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\BellaPizza\Views\_ViewImports.cshtml"
using BellaPizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\BellaPizza\Views\_ViewImports.cshtml"
using BellaPizza.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\BellaPizza\Views\_ViewImports.cshtml"
using BellaPizza.Models.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\BellaPizza\Views\_ViewImports.cshtml"
using BellaPizza.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\BellaPizza\Views\_ViewImports.cshtml"
using BellaPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\BellaPizza\Views\_ViewImports.cshtml"
using BellaPizza.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769548685a69f80d65ce0b894f0b5e9051a324c2", @"/Views/MenuProduct/MenuProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a22315670fe6371671d73a823e37e3220ee9e89", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuProduct_MenuProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampaignVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
  
    ViewData["Title"] = "MenuProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""blog-page-header"">
    <div class=""header-img-overlay-black""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8  text-white"">
                <h1>Menyu</h1>
                <p class=""lead"">Menyu</p>
            </div>
        </div>
    </div>
</section>

<section>
    <nav class=""navbar navbar-expand-lg navbar-light bg-light menuBar"">
        <div class=""container"">
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse""
                    data-target=""#navbarTogglerDemo02"" aria-controls=""navbarTogglerDemo02"" aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
                <ul class=""navbar-nav mr-auto mt-2 mt-lg-0 ml-auto"">

");
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                     foreach (MenuItemGroup menuItemGroup in Model.MenuItemGroups)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item \">\r\n                            <a class=\"nav-link\" data-filter=\".cat-");
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                                               Write(menuItemGroup.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                           Write(menuItemGroup.MenuItemGroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    <div class=\"wrap-max-width vendor-list__wrap\">\r\n        <div class=\"cuisines-panel\">\r\n            <ul class=\"cuisines-panel__slider\">\r\n");
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                 foreach (MenuItemGroup menuItemGroup2 in Model.MenuItemGroups)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li name=\"k_postu\" class=\"cuisines-panel__slide cuisines-panel__slide--is-hidden\">\r\n                        <a class=\"cuisines-panel__slide-btn\" data-filter=\".cat-");
#nullable restore
#line 50 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                                                            Write(menuItemGroup2.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                       Write(menuItemGroup2.MenuItemGroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 54 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"py-10 about-us-section sectionList\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row product-list\">\r\n");
#nullable restore
#line 64 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
             foreach (MenuItemGroup group in Model.MenuItemGroups)
            {
                if (group.MenuItems.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 2448, "\"", 2486, 4);
            WriteAttributeValue("", 2456, "col-sm-12", 2456, 9, true);
            WriteAttributeValue(" ", 2465, "mix", 2466, 4, true);
            WriteAttributeValue(" ", 2469, "cat-", 2470, 5, true);
            WriteAttributeValue("", 2474, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                    
#nullable restore
#line 68 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                               Write(group.Id);

#line default
#line hidden
#nullable disable
                                                                             
                PopWriter();
            }
            ), 2474, 12, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h2 class=\"anchor\"><b>");
#nullable restore
#line 69 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                         Write(group.MenuItemGroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                    foreach (MenuItem menuItem in group.MenuItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 2718, "\"", 2760, 5);
            WriteAttributeValue("", 2726, "col-lg-3", 2726, 8, true);
            WriteAttributeValue(" ", 2734, "mb-4", 2735, 5, true);
            WriteAttributeValue(" ", 2739, "mix", 2740, 4, true);
            WriteAttributeValue(" ", 2743, "cat-", 2744, 5, true);
            WriteAttributeValue("", 2748, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                            
#nullable restore
#line 73 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                                       Write(group.Id);

#line default
#line hidden
#nullable disable
                                                                                     
                PopWriter();
            }
            ), 2748, 12, false);
            EndWriteAttribute();
            WriteLiteral(" data-order=\"");
#nullable restore
#line 73 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                                                                 Write(group.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2820, "\"", 2922, 3);
            WriteAttributeValue("", 2830, "AjaxGet(\'", 2830, 9, true);
#nullable restore
#line 74 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
WriteAttributeValue("", 2839, Url.Action("GetDetail","Home", new { Id = menuItem.Id }, Context.Request.Scheme), 2839, 81, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2920, "\')", 2920, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"menu-box-with-order p-div\" data-toggle=\"modal\" data-target=\"#productModal\">\r\n                                    <div class=\"menu-box-img-price img flex align-items-center r-relative\">\r\n");
#nullable restore
#line 77 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                         if (menuItem.IsNew == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"menu-box-new\">\r\n                                                <span class=\"food-new\">Yeni</span>\r\n                                            </span>\r\n");
#nullable restore
#line 82 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "769548685a69f80d65ce0b894f0b5e9051a324c213488", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3572, "~/images/", 3572, 9, true);
#nullable restore
#line 83 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
AddHtmlAttributeValue("", 3581, menuItem.ImagePath, 3581, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"mt-3 px-3 textSec\">\r\n                                        <h5 class=\"text-green pizza-name-here mb-0\">");
#nullable restore
#line 86 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                                                               Write(menuItem.MenuItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <small class=\"section-text-grey\">\r\n                                            ");
#nullable restore
#line 88 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                       Write(menuItem.MenuItemDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </small>

                                        <span class=""menu-box-price "">
                                            <span class=""food-price"">
                                                <span class=""now-price"">
                                                    ");
#nullable restore
#line 94 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                                               Write(menuItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""manat""
                                                                          style=""font-weight:bold;"">₼</span>
                                                </span>
                                            </span>
                                        </span>
                                    </div>

                                </div>
                            </a>
                        </div>
");
#nullable restore
#line 104 "C:\Users\ASUS\source\repos\BellaPizza\Views\MenuProduct\MenuProduct.cshtml"
                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
            WriteLiteral(@"</section>

<div class=""modal fade"" id=""productModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""productModalLabel""
     style=""padding-right: 16px;"" aria-modal=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"" id=""dataProduct"">


            </div>
        </div>
    </div>
</div>




");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/mixitup/3.3.1/mixitup.min.js""></script>
    <script>
        if ($('.row.product-list').length > 0) {
            var containerEl = document.querySelector('.row.product-list');
            var mixer = mixitup(containerEl);
            mixer.filter('.cat-1');
        }

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampaignVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
