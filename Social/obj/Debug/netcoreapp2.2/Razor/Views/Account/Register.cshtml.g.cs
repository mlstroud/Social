#pragma checksum "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d819af070a9defab46452001111118bcecd322a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
using Social.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d819af070a9defab46452001111118bcecd322a2", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(84, 119, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n  <div class=\"col-md-12\">\r\n    <div class=\"jumbotron\">\r\n      <p class=\"lead\">Already registered? ");
            EndContext();
            BeginContext(204, 52, false);
#line 11 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
                                     Write(Html.ActionLink("Sign in here.", "Login", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(256, 81, true);
            WriteLiteral("</p>\r\n    </div>\r\n  </div>\r\n</div>\r\n<div class=\"row\">\r\n  <div class=\"col-md-6\">\r\n");
            EndContext();
#line 17 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
     using (Html.BeginForm("Register", "Account", FormMethod.Post))
    {
      

#line default
#line hidden
            BeginContext(420, 66, false);
#line 19 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.LabelFor(user => user.UserName, new { @class = "form-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(495, 70, false);
#line 20 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.TextBoxFor(user => user.UserName, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(576, 63, false);
#line 22 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.LabelFor(user => user.Email, new { @class = "form-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(648, 67, false);
#line 23 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.TextBoxFor(user => user.Email, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(726, 66, false);
#line 25 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.LabelFor(user => user.Password, new { @class = "form-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(801, 71, false);
#line 26 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.PasswordFor(user => user.Password, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(883, 73, false);
#line 28 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.LabelFor(user => user.ConfirmPassword, new { @class = "form-label"}));

#line default
#line hidden
            EndContext();
            BeginContext(965, 78, false);
#line 29 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
 Write(Html.PasswordFor(user => user.ConfirmPassword, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 83, true);
            WriteLiteral("      <br>\r\n      <input type=\"submit\" value=\"Register\" class=\"btn btn-warning\"> \r\n");
            EndContext();
#line 32 "D:\Desktop\TeamWEek\Social.Solution\Social\Views\Account\Register.cshtml"
    }

#line default
#line hidden
            BeginContext(1135, 203, true);
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