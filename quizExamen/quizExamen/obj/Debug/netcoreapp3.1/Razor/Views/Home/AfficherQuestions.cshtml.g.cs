#pragma checksum "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf2ad5b755ef2d4d573dcbc5c1f31bebd362e80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AfficherQuestions), @"mvc.1.0.view", @"/Views/Home/AfficherQuestions.cshtml")]
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
#line 1 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\_ViewImports.cshtml"
using quizExamen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\_ViewImports.cshtml"
using quizExamen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf2ad5b755ef2d4d573dcbc5c1f31bebd362e80", @"/Views/Home/AfficherQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403bf4fee665cb6241f0457b8f1457b5ddd5ff6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AfficherQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<quizExamen.Models.Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Soumettre"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Tests/Post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
  
    ViewData["Title"] = "AfficherQuestions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf2ad5b755ef2d4d573dcbc5c1f31bebd362e806596", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <fieldset");
                BeginWriteAttribute("id", " id=\"", 259, "\"", 280, 1);
#nullable restore
#line 14 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
WriteAttributeValue("", 264, item.QuestionId, 264, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <legend> ");
#nullable restore
#line 15 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
                Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </legend>\r\n");
#nullable restore
#line 16 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
             foreach (ItemOption element in @ViewBag.listeOptions)
            {
                if (element.QuestionId == item.QuestionId)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 558, "\"", 581, 1);
#nullable restore
#line 20 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
WriteAttributeValue("", 565, item.QuestionId, 565, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 582, "\"", 603, 1);
#nullable restore
#line 20 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
WriteAttributeValue("", 590, element.Text, 590, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <label");
                BeginWriteAttribute("for", " for=\"", 612, "\"", 634, 1);
#nullable restore
#line 20 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
WriteAttributeValue("", 618, item.QuestionId, 618, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
                                                                                                                Write(element.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label> <br />\r\n");
#nullable restore
#line 21 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </fieldset>\r\n");
#nullable restore
#line 25 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cdf2ad5b755ef2d4d573dcbc5c1f31bebd362e8010367", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf2ad5b755ef2d4d573dcbc5c1f31bebd362e8011821", async() => {
                    WriteLiteral("Annuler");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\maxim\Documents\GitHub\QuizProjetServeur\quizExamen\quizExamen\Views\Home\AfficherQuestions.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<quizExamen.Models.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
