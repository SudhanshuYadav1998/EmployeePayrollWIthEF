#pragma checksum "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f25399fa664a2dafc0002f2f918167e985ac4ad0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emp__ViewAll), @"mvc.1.0.view", @"/Views/Emp/_ViewAll.cshtml")]
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
#line 1 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\_ViewImports.cshtml"
using EmpPayrollMVCWithAjax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\_ViewImports.cshtml"
using EmpPayrollMVCWithAjax.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25399fa664a2dafc0002f2f918167e985ac4ad0", @"/Views/Emp/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5361d70033b658db2eea495340ebb4fb924d7ba7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Emp__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmpPayrollMVCWithAjax.Models.EmpModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 8 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.EmpID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.EmpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfileImg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 947, "\"", 1049, 5);
            WriteAttributeValue("", 957, "showInPopup(\'", 957, 13, true);
#nullable restore
#line 32 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
WriteAttributeValue("", 970, Url.Action("AddOrEdit","Emp",null,Context.Request.Scheme), 970, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1028, "\',\'Add", 1028, 6, true);
            WriteAttributeValue(" ", 1034, "New", 1035, 4, true);
            WriteAttributeValue(" ", 1038, "Employee\')", 1039, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Add New</a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmpID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmpName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               <img");
            BeginWriteAttribute("src", " src=\"", 1468, "\"", 1503, 1);
#nullable restore
#line 46 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
WriteAttributeValue("", 1474, Url.Content(item.ProfileImg), 1474, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2081, "\"", 2197, 4);
            WriteAttributeValue("", 2091, "showInPopup(\'", 2091, 13, true);
#nullable restore
#line 65 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
WriteAttributeValue("", 2104, Url.Action("AddOrEdit","Emp",new {id=item.EmpID},Context.Request.Scheme), 2104, 73, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2177, "\',\'Update", 2177, 9, true);
            WriteAttributeValue(" ", 2186, "Employee\')", 2187, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">\r\n                              <i class=\"fas fa-pencil-alt\"></i> Edit</a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f25399fa664a2dafc0002f2f918167e985ac4ad013264", async() => {
                WriteLiteral("\r\n                                   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f25399fa664a2dafc0002f2f918167e985ac4ad013558", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 68 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.EmpID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                   <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                                   \r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
                                                            WriteLiteral(item.EmpID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Sudhanshu\OneDrive\Desktop\EmployeePayrollmvcajax\EmployeePayrollMVCWithAjax\EmpPayrollMVCWithAjax\Views\Emp\_ViewAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmpPayrollMVCWithAjax.Models.EmpModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591