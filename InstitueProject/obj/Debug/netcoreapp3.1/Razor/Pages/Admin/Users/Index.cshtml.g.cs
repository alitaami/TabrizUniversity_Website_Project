#pragma checksum "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d610593b44b029180869fa97b9a5f02c103925ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/Index.cshtml")]
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
#line 1 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\_ViewImports.cshtml"
using InstitueProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\_ViewImports.cshtml"
using InstitueProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
using Institue.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d610593b44b029180869fa97b9a5f02c103925ee", @"/Pages/Admin/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d046dc64c5e27cc8e19c0ef9a5fe005755ef7", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:aliceblue;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
  
    Layout = "_Layout";



#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n<p>لیست کاربران</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d610593b44b029180869fa97b9a5f02c103925ee4889", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <input name=""lastname"" type=""text"" class=""form-control col-3"" placeholder=""نام خانوادگی"" style=""margin:5px;"" aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
        <div class=""col-1""></div>
        <input name=""StNumber"" type=""text"" class=""form-control col-3"" placeholder=""شماره دانشجویی"" aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
        <div class=""col-1""></div>
        <div>
            <button type=""submit"" class=""btn btn-primary"">جستجو</button>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d610593b44b029180869fa97b9a5f02c103925ee5730", async() => {
                    WriteLiteral(" ریست کردن جدول");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""card-body"">
    <div class=""table-responsive"" tabindex=""1"" style="" overflow: hidden; outline: none;"">
        <table class=""table "">
            <thead>
                <tr>
                    <th scope=""col"">نام </th>
                    <th scope=""col"">نام کاربری</th>
                    <th scope=""col"">ایمیل</th>
                    <th scope=""col"">تاریخ تولد</th>
                    <th scope=""col"">تلفن همراه</th>
                    <th scope=""col"">تلفن ثابت</th>
                    <th scope=""col"">نشانی</th>
                    <th scope=""col"">رشته تحصیلی</th>
                    <th scope=""col"">تاریخ ورود</th>
                    <th scope=""col"">شماره دانشجویی</th>
                    <th scope=""col"">دوره</th>
");
            WriteLiteral("                    <th scope=\"col\">وضعیت</th>\r\n");
            WriteLiteral("                    <th scope=\"col\">دستورات</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                 foreach (var user in Model.user.Users.Where(i => i.IsDelete == false && i.IsTeacher == false))
                {
                    var x = _user.GetMajorName(user.UserId);


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 54 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                                     Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 55 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 56 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 57 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 58 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 59 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.HomeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </td>\r\n                        <td><span style=\"font-size:9px;\">");
#nullable restore
#line 60 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                    Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></td>\r\n                        <td>\r\n                            <span style=\"font-size:10px;\">\r\n");
#nullable restore
#line 63 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                 if (x != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                               Write(x.MajorTitle);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                 

                                }
                               
                               else {
 

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n                        </td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 75 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.UniversitySignDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 76 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.StudentNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span style=\"font-size:10px;\">");
#nullable restore
#line 77 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                     Write(user.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
            WriteLiteral("                        <td>\r\n");
#nullable restore
#line 80 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                             if (user.IsActive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"text-success  \">فعال</p>\r\n");
#nullable restore
#line 83 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"text-danger \">غیرفعال</p>\r\n");
#nullable restore
#line 87 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n");
            WriteLiteral("                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4131, "\"", 4172, 2);
            WriteAttributeValue("", 4138, "/Admin/Users/EditUser/", 4138, 22, true);
#nullable restore
#line 92 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue("", 4160, user.UserId, 4160, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:aliceblue;\" class=\"btn btn-sm btn-warning\">ویرایش</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4272, "\"", 4320, 2);
            WriteAttributeValue("", 4279, "/Admin/Users/IndexUserLesson/", 4279, 29, true);
#nullable restore
#line 93 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue("", 4308, user.UserId, 4308, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:aliceblue;\" class=\"btn btn-danger\">درس ها</a>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <nav aria-label=\"...\" class=\"mb-3\">\r\n        <ul class=\"pagination pagination-sm\">\r\n");
#nullable restore
#line 108 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
             for (int i = 1; i <= Model.user.PageCount; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 4730, "\"", 4790, 2);
            WriteAttributeValue("", 4738, "page-item", 4738, 9, true);
#nullable restore
#line 110 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue(" ", 4747, (i==Model.user.CurrentPage)?"active":"", 4748, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4834, "\"", 4863, 2);
            WriteAttributeValue("", 4841, "/Admin/Users?PageId=", 4841, 20, true);
#nullable restore
#line 111 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue("", 4861, i, 4861, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 111 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 113 "C:\Users\Sarv\source\repos\InstitueProject\InstitueProject\Pages\Admin\Users\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </ul>\r\n    </nav>\r\n</div>\r\n ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Institue.Core.Services.Interface.IUserService _user { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InstitueProject.Pages.Admin.Users.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InstitueProject.Pages.Admin.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InstitueProject.Pages.Admin.Users.IndexModel>)PageContext?.ViewData;
        public InstitueProject.Pages.Admin.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
