#pragma checksum "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e5920203830c259de217b7e3e80ece19c0d1a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Default_Single), @"mvc.1.0.view", @"/Areas/Users/Views/Default/Single.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e5920203830c259de217b7e3e80ece19c0d1a7", @"/Areas/Users/Views/Default/Single.cshtml")]
    public class Areas_Users_Views_Default_Single : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDemoCore.EDM.Tblproduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("example"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml"
  
    ViewData["Title"] = "Single";
    Layout = "~/Areas/Users/Views/User_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"products\">\r\n    <div class=\"container\">\r\n        <div class=\"agileinfo_single\">\r\n\r\n            <div class=\"col-md-4 agileinfo_single_left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f6e5920203830c259de217b7e3e80ece19c0d1a74898", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 333, "~/Products/", 333, 11, true);
#nullable restore
#line 13 "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml"
AddHtmlAttributeValue("", 344, Model.Image1, 344, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-8 agileinfo_single_right\">\r\n                <h2>");
#nullable restore
#line 16 "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml"
               Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                <div class=""rating1"">
                    <span class=""starRating"">
                        <input id=""rating5"" type=""radio"" name=""rating"" value=""5"">
                        <label for=""rating5"">5</label>
                        <input id=""rating4"" type=""radio"" name=""rating"" value=""4"">
                        <label for=""rating4"">4</label>
                        <input id=""rating3"" type=""radio"" name=""rating"" value=""3""");
            BeginWriteAttribute("checked", " checked=\"", 985, "\"", 995, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <label for=""rating3"">3</label>
                        <input id=""rating2"" type=""radio"" name=""rating"" value=""2"">
                        <label for=""rating2"">2</label>
                        <input id=""rating1"" type=""radio"" name=""rating"" value=""1"">
                        <label for=""rating1"">1</label>
                    </span>
                </div>
                <div class=""w3agile_description"">
                    <h4>Description :</h4>
                    <p>
                       ");
#nullable restore
#line 34 "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"snipcart-item block\">\r\n                    <div class=\"snipcart-thumb agileinfo_single_right_snipcart\">\r\n                        <h4 class=\"m-sing\">₹ ");
#nullable restore
#line 39 "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml"
                                         Write(Model.Cost-(Model.Cost*Model.Discount/100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>₹ ");
#nullable restore
#line 39 "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml"
                                                                                              Write(Model.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h4>
                    </div>
                    <div class=""snipcart-details agileinfo_single_right_details"">
                        <form method=""post"">
                            <fieldset>
                                <input type=""hidden"" name=""cmd"" value=""_cart"">
                                <input type=""hidden"" name=""add"" value=""1"">
                                <input type=""hidden"" name=""business"" value="" "">
                                <input type=""hidden"" name=""item_name"" value=""pulao basmati rice"">
                                <input type=""hidden"" name=""amount"" value=""21.00"">
                                <input type=""hidden"" name=""discount_amount"" value=""1.00"">
                                <input type=""hidden"" name=""currency_code"" value=""USD"">
                                <input type=""hidden"" name=""return"" value="" "">
                                <input type=""hidden"" name=""cancel_return"" value="" "">
                                <input type=""butto");
            WriteLiteral(@"n"" id=""btn"" name=""submit"" value=""Add to cart"" class=""button"">
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $(""#btn"").click(function (){
            $.ajax({
                url: ""/Users/Default/AddToCart"",
                type: ""GET"",
                data: { id: ");
#nullable restore
#line 69 "C:\Ankit Patel\Lectures\RajBatch\ProjectDemoCore\ProjectDemoCore\Areas\Users\Views\Default\Single.cshtml"
                       Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
                dataType: ""text"",
                success: function (msg) {
                    alert(msg);
                    window.location.href = ""/Users/Default/Products"";
                }
            });
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDemoCore.EDM.Tblproduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
