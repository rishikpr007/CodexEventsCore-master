#pragma checksum "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\LoginAndReg\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f16613eaeb6eb6caadaca879f80f8a5dedb2c240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoginAndReg_Register), @"mvc.1.0.view", @"/Views/LoginAndReg/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f16613eaeb6eb6caadaca879f80f8a5dedb2c240", @"/Views/LoginAndReg/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7896da3f6da763382bceda5db6c3fb6fb64320e1", @"/Views/_ViewImports.cshtml")]
    public class Views_LoginAndReg_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodexEvents.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LoginAndReg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rishi\Desktop\CodexEventsCore-master\CodexEventsCore-master\Views\LoginAndReg\Register.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16613eaeb6eb6caadaca879f80f8a5dedb2c2405444", async() => {
                WriteLiteral(@"
	<meta charset=""ISO-8859-1"">
	<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
	<link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"" type=""text/css"">
	<link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"" type=""text/css"">
	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
	<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-validator/0.4.5/js/bootstrapvalidator.min.js""></script>
	<title>Register User</title>
	<style>
		.jumbotron {
			background-color: #f4511e;
			color: #fff;
			padding: 100px 25px;
			font-family: Montserrat, sans-serif;
		}

		h2 {
			font-size: 24px;
			text-transform: uppercase;
			color: #303030;
			font-weight: 600;
			margin-bottom: 30px;
		}

		.loginfooter {
			background-color: #f4511e;
			letter-spacing: 4px;
			border-radius: 0;
			width: 1");
                WriteLiteral(@"00%;
			box-sizing: border-box;
			padding: 14px 16px;
			width: 100%;
		}

			.loginfooter a {
				color: #fff !important;
				float: center;
				text-align: center;
				padding: 14px 16px;
				text-decoration: none;
				font-size: 17px;
				border: 1px solid #f4511e;
				display: inline-block;
				width: 100%;
				height: 100%;
			}

				.loginfooter a:hover {
					color: #f4511e !important;
					background-color: #fff !important;
				}

		.neomorphism {
			width: 85%;
			margin: 0 auto;
			border-radius: 16px;
			background: #ffffff;
			box-shadow: 10px 10px 21px #8a8a8a, -10px -10px 21px #ffffff;
			font-family: Montserrat, sans-serif;
			padding: 30px;
			padding-top: 50px;
			padding-bottom: 100px;
		}
	</style>
	<script>
$(document).ready(function() {
	$('#register_form').bootstrapValidator({
		// To use feedback icons, ensure that you use Bootstrap v3.1.0 or later
		feedbackIcons: {
			valid: 'glyphicon glyphicon-ok',
			invalid: 'glyphicon glyphicon-remove',
			validating: 'glyphicon glyphicon-refres");
                WriteLiteral(@"h'
		},
		fields: {
			firstName: {
				validators: {
						stringLength: {
						min: 2,
					},
						notEmpty: {
						message: 'Please enter your First Name'
					}
				}
			},
			 lastName: {
				validators: {
					 stringLength: {
						min: 2,
					},
					notEmpty: {
						message: 'Please enter your Last Name'
					}
				}
			},
			 date: {
				validators: {
					notEmpty: {
						message: 'Please enter your Date of Birth'
					}
				}
			},
			country: {
				validators: {
					notEmpty: {
						message: 'Please enter your Country'
					}
				}
			},
			 password: {
				validators: {
					 stringLength: {
						min: 7,
					},
					notEmpty: {
						message: 'Please enter your Password'
					}
				}
			},
			confirmPassword: {
				validators: {
					 stringLength: {
						min: 7,
					},
					notEmpty: {
						message: 'Please confirm your Password'
					},
					identical: {
						field: 'password',
						message: 'The password and its confirm are not the same'
					}
				}
			},
			email: {
				vali");
                WriteLiteral(@"dators: {
					notEmpty: {
						message: 'Please enter your Email Address'
					},
					emailAddress: {
						message: 'Please enter a valid Email Address'
					}
				}
			},
			phoneNumber: {
				validators: {
				  stringLength: {
						min: 10,
						max: 15,
					notEmpty: {
						message: 'Please enter your Contact No.'
					 }
				}
			},
				}
			}
		})
		.on('success.form.bv', function(e) {
			$('#success_message').slideDown({ opacity: ""show"" }, ""slow"") // Do something ...
				$('#register_form').data('bootstrapValidator').resetForm();
			// Prevent form submission
			e.preventDefault();
			// Get the form instance
			var $form = $(e.target);
			// Get the BootstrapValidator instance
			var bv = $form.data('bootstrapValidator');
			// Use Ajax to submit form data
			$.post($form.attr('action'), $form.serialize(), function(result) {
				console.log(result);
			}, 'json');
		});
});
	</script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16613eaeb6eb6caadaca879f80f8a5dedb2c24010527", async() => {
                WriteLiteral("\n\t<div class=\"jumbotron text-center\">\n\t\t<h1>CodeX Events</h1>\n\t\t<p>Event Registration Portal</p>\n\t</div>\n\n\t<h2 class=\"text-center\">User Registration</h2><br />\n\n\t<div class=\"neomorphism\">\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16613eaeb6eb6caadaca879f80f8a5dedb2c24010997", async() => {
                    WriteLiteral(@"

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">First Name</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
						<input class=""form-control"" placeholder=""Enter First Name"" type=""text"" name=""firstName"" />
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Last Name</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
						<input type=""text"" name=""lastName"" placeholder=""Last Name"" class=""form-control"" />
					</div>
				</div>
			</div>

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Date of birth</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-calendar""></i></span>
				");
                    WriteLiteral(@"		<input type=""date"" name=""dateOfBirth"" placeholder=""YYYY-MM-DD"" class=""form-control"" />
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Gender</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
						<label class=""radio-inline""><input type=""radio"" name=""gender"" value=""male"" />Male</label>
						<label class=""radio-inline""><input type=""radio"" name=""gender"" value=""female"" />Female</label>
						<label class=""radio-inline""><input type=""radio"" name=""gender"" value=""not_specified"" />Not Specified</label>
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Country</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-globe""></i></span>
						<input type=""text"" name=""country"" placeholder=""Countr");
                    WriteLiteral(@"y"" class=""form-control"" />
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Phone Number</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-earphone""></i></span>
						<input type=""text"" name=""phoneNumber"" placeholder=""+01234567890"" class=""form-control"" />
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">E-Mail</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope""></i></span>
						<input name=""email"" placeholder=""abcdef@ghi.xyz"" class=""form-control"" type=""email"">
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Password</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon");
                    WriteLiteral(@"""><i class=""glyphicon glyphicon-user""></i></span>
						<input type=""password"" name=""password"" placeholder=""Password"" class=""form-control"">
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Confirm Password</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
						<input type=""password"" name=""confirmPassword"" placeholder=""Confirm Password"" class=""form-control"">
					</div>
				</div>
			</div>
			<div class=""form-group"">
				<label class=""col-md-4 control-label""></label>
				<div class=""col-md-4"">
					<br>
					&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<button type=""submit"" class=""btn btn-warning"">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspREGISTER <span class=""glyphicon glyphicon-send""></span>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</button>
				</div>
			</div>
		");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\t</div>\n\t<br />\n\t<div class=\"loginfooter navbar-fixed-bottom\">\n\t\t<a href=\"ShowLogin\">Already a member? Click here  to go to the login page.</a>\n\t</div>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CodexEvents.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
