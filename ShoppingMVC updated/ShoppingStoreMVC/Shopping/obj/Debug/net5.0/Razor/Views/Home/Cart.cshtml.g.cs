#pragma checksum "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a136423ae976150c630084a9dbe3242267e5d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a136423ae976150c630084a9dbe3242267e5d4", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLibrary.Tcart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cart</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a136423ae976150c630084a9dbe3242267e5d43733", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Item Name
            </th>
            <th>
                Qty
            </th>
            <th>
                Unit Price
            </th>
            <th>
                SubTotal
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Itemname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Minqty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Unitprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Subtot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n\r\n\r\n                <td style=\"display:none\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Itemid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"display:none\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"display:none\">\r\n                    ");
#nullable restore
#line 57 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Userpk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.ActionLink("Delete", "DeleteFromCart", new { id = item.Itemid }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("ss\r\n    </tbody>\r\n");
#nullable restore
#line 67 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
     foreach (var item in Model.Reverse().Take(1))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><h3>Total</h3></td>\r\n            <td><h3>");
#nullable restore
#line 71 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
               Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 74 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 76 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC updated\ShoppingStoreMVC\Shopping\Views\Home\Cart.cshtml"
Write(Html.ActionLink("Confirm Order", "ConfirmCart", new {}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLibrary.Tcart>> Html { get; private set; }
    }
}
#pragma warning restore 1591