#pragma checksum "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d8d7921f621a832f92906ef71f6db2f2a234aff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 5 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
using Social.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8d7921f621a832f92906ef71f6db2f2a234aff", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(84, 122, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n  <div class=\"col-md-12\">\r\n    <div class=\"jumbotron\">\r\n      <p class=\"lead\">Don\'t have an account? ");
            EndContext();
            BeginContext(207, 56, false);
#line 11 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
                                        Write(Html.ActionLink("Register here.", "Register", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(263, 81, true);
            WriteLiteral("</p>\r\n    </div>\r\n  </div>\r\n</div>\r\n<div class=\"row\">\r\n  <div class=\"col-md-6\">\r\n");
            EndContext();
#line 17 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
     using (Html.BeginForm())
    {
      

#line default
#line hidden
            BeginContext(389, 66, false);
#line 19 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
 Write(Html.LabelFor(user => user.UserName, new { @class = "form-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(464, 70, false);
#line 20 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
 Write(Html.TextBoxFor(user => user.UserName, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(545, 66, false);
#line 22 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
 Write(Html.LabelFor(user => user.Password, new { @class = "form-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(620, 71, false);
#line 23 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
 Write(Html.PasswordFor(user => user.Password, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(702, 73, false);
#line 25 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
 Write(Html.LabelFor(user => user.ConfirmPassword, new { @class = "form-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(784, 78, false);
#line 26 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
 Write(Html.PasswordFor(user => user.ConfirmPassword, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(864, 78, true);
            WriteLiteral("      <br>\r\n      <input type=\"submit\" value=\"Log\" class=\"btn btn-warning\"> \r\n");
            EndContext();
#line 29 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Login.cshtml"
    }

#line default
#line hidden
            BeginContext(949, 203, true);
            WriteLiteral("  </div>\r\n    <div class=\"col-md-6\">\r\n    <h3>Join <span style=\"color: orange;\">stack</span><strong>underflow</strong></h3>\r\n    <hr>\r\n    <p>Discuss the latest trends.</p>\r\n    <p></p>\r\n  </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
