#pragma checksum "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d8dd7bcae14978361da77ff717f0c8bfc4af9c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManager_ChangeUserRole), @"mvc.1.0.view", @"/Views/UserManager/ChangeUserRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManager/ChangeUserRole.cshtml", typeof(AspNetCore.Views_UserManager_ChangeUserRole))]
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
#line 1 "C:\asp\A1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#line 3 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
using Assignment1.Models;

#line default
#line hidden
#line 1 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
using Assignment1.Areas.Identity.Data;

#line default
#line hidden
#line 2 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8dd7bcae14978361da77ff717f0c8bfc4af9c9", @"/Views/UserManager/ChangeUserRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManager_ChangeUserRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelContainer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
  
    ViewData["Title"] = "Change User Role";

#line default
#line hidden
#line 9 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(215, 44, true);
            WriteLiteral("    <h2>Change User Role Confirmation</h2>\r\n");
            EndContext();
            BeginContext(261, 73, true);
            WriteLiteral("    <div>\r\n        <hr />\r\n\r\n        <div class=\"container centerText\">\r\n");
            EndContext();
#line 17 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
             if ((Model.GetModel<Assignment1User>().Email) == "a@a.a")
            {

#line default
#line hidden
            BeginContext(421, 269, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-lg-12"">
                        <h1>You can't Change the primary admin account!!!!!</h1>
                    </div>
                </div>
                <div class=""row"">
                    ");
            EndContext();
            BeginContext(690, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "903bbe2a1a5349fa8b6c079eabf9f97f", async() => {
                BeginContext(712, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(728, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 27 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(802, 157, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-lg-3\"></div>\r\n                    <div class=\"col-lg-6\">\r\n                        <h3>");
            EndContext();
            BeginContext(960, 66, false);
#line 33 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                       Write(Html.DisplayNameFor(model => model.GetModel<Assignment1User>().Id));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1029, 62, false);
#line 33 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                                                                                            Write(Html.DisplayFor(model => model.GetModel<Assignment1User>().Id));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 35, true);
            WriteLiteral("</h3>\r\n                        <h3>");
            EndContext();
            BeginContext(1127, 72, false);
#line 34 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                       Write(Html.DisplayNameFor(model => model.GetModel<Assignment1User>().UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1202, 68, false);
#line 34 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.GetModel<Assignment1User>().UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 35, true);
            WriteLiteral("</h3>\r\n                        <h3>");
            EndContext();
            BeginContext(1306, 69, false);
#line 35 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                       Write(Html.DisplayNameFor(model => model.GetModel<Assignment1User>().Email));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1378, 65, false);
#line 35 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                                                                                               Write(Html.DisplayFor(model => model.GetModel<Assignment1User>().Email));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 58, true);
            WriteLiteral("</h3>\r\n                        <h3>Current Role(s):</h3>\r\n");
            EndContext();
#line 37 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                         foreach (var item in Model.GetModel<UserSpecs>().CurrentRole)
                        {

#line default
#line hidden
            BeginContext(1616, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1644, 494, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e9ec85b56d487b855a507a96e2a45d", async() => {
                BeginContext(1678, 82, true);
                WriteLiteral("\r\n                                <h4>\r\n                                    <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1760, "\"", 1773, 1);
#line 41 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
WriteAttributeValue("", 1768, item, 1768, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1774, 73, true);
                WriteLiteral(" type=\"text\" disabled=\"disabled\" />\r\n                                    ");
                EndContext();
                BeginContext(1847, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a9658139c494619b8ee290622ceb4ec", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 42 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1886, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1924, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "526f79caae3e4fc5a7ff6b8d26774e2f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 43 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GetModel<Assignment1User>().Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1988, 143, true);
                WriteLiteral(" <input type=\"submit\" value=\"Remove From Role\" class=\"btn btn-default\" />\r\n                                </h4>\r\n                             ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                        }

#line default
#line hidden
            BeginContext(2167, 542, true);
            WriteLiteral(@"                        </div>
                    <div class=""col-lg-3""></div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-6"">
                        <h1>Select a New Role</h1>
                    </div>
                    <div class=""col-lg-3""></div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-6"">
                        ");
            EndContext();
            BeginContext(2709, 728, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bbb3d0512de43ed94e85d76272706bd", async() => {
                BeginContext(2733, 60, true);
                WriteLiteral("\r\n                            <select name=\"selectedRole\">\r\n");
                EndContext();
#line 62 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                                 foreach (var item in Model.GetModel<UserSpecs>().AvailableRoles)
                                {

#line default
#line hidden
                BeginContext(2927, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2963, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3be00f5e7ef4d5daab3d7ecf306e425", async() => {
                    BeginContext(2986, 4, false);
#line 64 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                                                     Write(item);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 64 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                                       WriteLiteral(item);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2999, 3, true);
                WriteLiteral(" \r\n");
                EndContext();
#line 65 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
                                }

#line default
#line hidden
                BeginContext(3037, 139, true);
                WriteLiteral("                            </select>\r\n                            <br />\r\n                            <br />\r\n                            ");
                EndContext();
                BeginContext(3176, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78ee9c7689234b0baae7efeb7bbf3c2f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 69 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GetModel<Assignment1User>().Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3240, 126, true);
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Add Role\" class=\"btn btn-default\" /> |\r\n                            ");
                EndContext();
                BeginContext(3366, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f577a655b40430f8b0d23613f88ce4b", async() => {
                    BeginContext(3388, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
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
                EndContext();
                BeginContext(3404, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3437, 104, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-lg-3\"></div>\r\n                </div>\r\n");
            EndContext();
#line 76 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
            }

#line default
#line hidden
            BeginContext(3556, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 79 "C:\asp\A1\Assignment1\Views\UserManager\ChangeUserRole.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
