#pragma checksum "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77e3b8be9464b9447f47c7bf59b6495d20fc8505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FindFriends), @"mvc.1.0.view", @"/Views/Home/FindFriends.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FindFriends.cshtml", typeof(AspNetCore.Views_Home_FindFriends))]
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
#line 5 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
using Social.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e3b8be9464b9447f47c7bf59b6495d20fc8505", @"/Views/Home/FindFriends.cshtml")]
    public class Views_Home_FindFriends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
 foreach(ApplicationUser user in Model)
{

#line default
#line hidden
            BeginContext(100, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(106, 84, false);
#line 9 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
Write(Html.ActionLink($"{@user.UserName}", "Profile", "Home", new { name = user.UserName}));

#line default
#line hidden
            EndContext();
            BeginContext(190, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
     using (Html.BeginForm("AddFriend", "Home"))
    {
      

#line default
#line hidden
            BeginContext(262, 39, false);
#line 13 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
 Write(Html.Hidden("userName", @user.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(303, 72, true);
            WriteLiteral("      <input type=\"submit\" class=\"btn btn-primary\" value=\"Add Friend\">\r\n");
            EndContext();
#line 15 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
    }

#line default
#line hidden
#line 15 "D:\Desktop\teamweek\Social.Solution\social\Views\Home\FindFriends.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
