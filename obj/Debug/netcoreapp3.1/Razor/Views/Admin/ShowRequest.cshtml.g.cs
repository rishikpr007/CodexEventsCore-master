#pragma checksum "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b075d91c0591f1343d1346a034c4ec80dff4f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowRequest), @"mvc.1.0.view", @"/Views/Admin/ShowRequest.cshtml")]
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
#line 1 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\_ViewImports.cshtml"
using CodexEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\_ViewImports.cshtml"
using CodexEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b075d91c0591f1343d1346a034c4ec80dff4f3", @"/Views/Admin/ShowRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7896da3f6da763382bceda5db6c3fb6fb64320e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ShowRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
  
    UserRequest userRequest = ViewBag.UserRequest;
    int eventId = ViewBag.EventId;
    string eventName = ViewBag.EventName;
    int registrationsOver = ViewBag.RegistrationsOver;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22b075d91c0591f1343d1346a034c4ec80dff4f35306", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"" type=""text/css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <meta charset=""ISO-8859-1"">
    <style>
        body {
            font: 400 15px Lato, sans-serif;
            line-height: 1.8;
            color: #818181;
        }

        h2 {
            font-size: 24px;
            text-transform: uppercase;
            color: #303030;
            font-weight: 600;
            margin-top: 30px;
        }
        .navbar {
            margin-bottom: 0;
            background-color: #f4511e;
            z-index: 9999;
            border: 0;
            font-size: 12px !important;
  ");
                WriteLiteral(@"          line-height: 1.42857143 !important;
            letter-spacing: 4px;
            border-radius: 0;
            font-family: Montserrat, sans-serif;
        }

            .navbar li a, .navbar .navbar-brand {
                color: #fff !important;
            }


        .userdetail {
            width: 30%;
        }

        .user-details-table {
            width: 85%;
            margin: 0 auto;
            border-radius: 16px;
            background: #ffffff;
            box-shadow: 10px 10px 21px #8a8a8a, -10px -10px 21px #ffffff;
            font-family: Montserrat, sans-serif;
            padding-top: 40px;
        }

        .createEventFooter {
            background-color: #f4511e;
            letter-spacing: 4px;
            border-radius: 0;
            width: 100%;
            box-sizing: border-box;
            padding: 14px 16px;
            width: 100%;
            align-self: stretch;
        }

            .createEventFooter a {
                color: #fff !important;
           ");
                WriteLiteral(@"     float: center;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                font-size: 17px;
                border: 1px solid #f4511e;
                display: inline-block;
                width: 100%;
                height: 100%;
                align-self: stretch;
            }

                .createEventFooter a:hover {
                    color: #f4511e !important;
                    background-color: #fff !important;
                }

        .profile-buttons {
            display: flex;
            height: 30px;
            justify-content: space-around;
            flex-wrap: wrap;
            align-content: center;
            align-items: stretch;
        }

            .profile-buttons a, button {
                align-self: auto;
                width: 200px;
                padding: 20px;
            }
    </style>
    <title>Manage Request</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22b075d91c0591f1343d1346a034c4ec80dff4f39361", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-default navbar-fixed-top"">
        <div class=""navbar-header"">
            <a class=""navbar-brand"" href=""ShowDashboard"">CodeX Events</a>
        </div>
    </nav>


    <div class=""user-details-table"">
        <h2 class=""profileheading"">Event ID: ");
#nullable restore
#line 122 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
                                        Write(eventId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n        <h2 class=\"profileheading\">Event Name: ");
#nullable restore
#line 123 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
                                          Write(eventName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n        <table class=\"table\">\n            <tr>\n                <td class=\"userdetail\">Request ID</td>\n                <td>");
#nullable restore
#line 127 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
               Write(userRequest.RegistrationId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td class=\"userdetail\">User ID</td>\n                <td>");
#nullable restore
#line 131 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
               Write(userRequest.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td class=\"userdetail\">Name</td>\n                <td>");
#nullable restore
#line 135 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
               Write(userRequest.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td class=\"userdetail\">Request Status</td>\n                <td>");
#nullable restore
#line 139 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
               Write(userRequest.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            </tr>\n        </table>\n    </div>\n\n");
#nullable restore
#line 144 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
     if (registrationsOver == 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"profile-buttons\">\n            <a");
                BeginWriteAttribute("href", " href=\"", 4376, "\"", 4435, 2);
                WriteAttributeValue("", 4383, "ApproveRequest?requestId=", 4383, 25, true);
#nullable restore
#line 147 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
WriteAttributeValue("", 4408, userRequest.RegistrationId, 4408, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button type=\"button\" class=\"btn btn-success\">APPROVE</button></a>\n            <a");
                BeginWriteAttribute("href", " href=\"", 4518, "\"", 4576, 2);
                WriteAttributeValue("", 4525, "RejectRequest?requestId=", 4525, 24, true);
#nullable restore
#line 148 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
WriteAttributeValue("", 4549, userRequest.RegistrationId, 4549, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button type=\"button\" class=\"btn btn-danger\">REJECT</button></a>\n        </div>\n");
#nullable restore
#line 150 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <div class=\"createEventFooter navbar-fixed-bottom\">\n        <a");
                BeginWriteAttribute("href", " href=\"", 4731, "\"", 4769, 2);
                WriteAttributeValue("", 4738, "ManageRequests?eventId=", 4738, 23, true);
#nullable restore
#line 153 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Admin\ShowRequest.cshtml"
WriteAttributeValue("", 4761, eventId, 4761, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Back to Pending Requests</a>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
