#pragma checksum "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23728475038d92aba55397c1c299a4fd4cc027d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23728475038d92aba55397c1c299a4fd4cc027d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7896da3f6da763382bceda5db6c3fb6fb64320e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23728475038d92aba55397c1c299a4fd4cc027d13701", async() => {
                WriteLiteral(@"
    <meta charset=""ISO-8859-1"">
    <link rel=""stylesheet""
          href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat""
          rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Lato""
          rel=""stylesheet"" type=""text/css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <style>
        .jumbotron {
            background-color: #f4511e;
            color: #fff;
            padding: 100px 25px;
            font-family: Montserrat, sans-serif;
        }

        .description {
            border-radius: 2px;
            background: #ffffff;
            box-shadow: 10px 10px 21px #8a8a8a, -10px -10px 21px #ffffff;
            border: 1px solid #f4511e;
            font-size: 16px !important;
            line-height: 1.42857143 !i");
                WriteLiteral(@"mportant;
            letter-spacing: 4px;
            font-family: Montserrat, sans-serif;
            width: 80%;
            margin: 0 auto;
            padding: 16px;
        }

        .utilityoptions {
            background-color: #f4511e;
            letter-spacing: 4px;
            border-radius: 0;
            font-family: Montserrat, sans-serif;
            flex-direction: row;
            flex-wrap: wrap;
            justify-content: space-evenly;
            align-items: stretch;
            display: flex;
            box-sizing: border-box;
            width: 100%;
        }

        .utilityelement {
            padding: 14px 16px;
            display: inline-block;
            flex-grow: 1;
            width: 100%;
            height: 100%;
        }

        .utilityoptions a {
            color: #fff !important;
            float: center;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
            font-size: 17px;
            border: 1px sol");
                WriteLiteral(@"id #f4511e;
            align-items: stretch;
            flex-grow: 1;
        }

            .utilityoptions a:hover {
                color: #f4511e !important;
                background-color: #fff !important;
            }
    </style>
    <title>CodeX Events</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23728475038d92aba55397c1c299a4fd4cc027d17078", async() => {
                WriteLiteral(@"
    <div class=""jumbotron text-center"">
        <h1>CodeX Events</h1>
        <p>Event Registration Portal</p>
    </div><br />
    <p class=""description text-center"">
        One stop resource to register for a corporate events with ease.<br /> <strong>Codex Events</strong>
        allows you to find all corporate events, manage your events, view availability status as well as the pre-requisites for attending the event.
        Raise a request for a event based on availabity and get to know the real-time status of your request.<br /><br />
        <b>SIGN IN TO CONTINUE<b>
    </p>
    <div class=""utilityoptions navbar-fixed-bottom"">
        <a href=""LoginAndReg/Login""><div class=""utilityelement"">Login</div></a>
        <a href=""LoginAndReg/Register""><div class=""utilityelement"">Register</div></a>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
