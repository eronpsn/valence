#pragma checksum "C:\Workspace.app\Valence\Valence.WebApp\Views\Home\Autenticar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b504532b38eecfebab849b8e81266587a0f44db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Autenticar), @"mvc.1.0.view", @"/Views/Home/Autenticar.cshtml")]
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
#line 1 "C:\Workspace.app\Valence\Valence.WebApp\Views\_ViewImports.cshtml"
using Valence.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace.app\Valence\Valence.WebApp\Views\_ViewImports.cshtml"
using Valence.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b504532b38eecfebab849b8e81266587a0f44db", @"/Views/Home/Autenticar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9af1e790732951dd6f3f93f7cf7fe4931780659", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Autenticar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("init()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Workspace.app\Valence\Valence.WebApp\Views\Home\Autenticar.cshtml"
  
    ViewData["Title"] = "Autenticar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b504532b38eecfebab849b8e81266587a0f44db3963", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Desire2Learn Auth SDK Sample</title>
	<style type = ""text/css"">
		table.plain
		{
		  border-color: transparent;
		  border-collapse: collapse;
		}

		table td.plain
		{
		  padding: 5px;
		  border-color: transparent;
		}

		table th.plain
		{
		  padding: 6px 5px;
		  text-align: left;
		  border-color: transparent;
		}

		tr:hover
		{
			background-color: transparent !important;
		}

		.error
		{
			color: #FF0000;
		}
	</style>
	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type = ""text/javascript""></script>

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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b504532b38eecfebab849b8e81266587a0f44db5562", async() => {
                WriteLiteral("\r\n\t<input type=\"button\" name=\"authBtn\" value=\"Load Defaults\" id=\"resetButton\" onclick=\"defaults()\"/>\r\n\t<hr />\r\n\t<table>\r\n\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t\t<b>Host: </b>\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t<input name=\"hostField\" type=\"text\" style=\"width:20em\"");
                BeginWriteAttribute("value", " value=\"", 1115, "\"", 1123, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"hostField\" />\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t<b>Port:</b>\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t<input name=\"portField\" type=\"text\" style=\"width:20em\"");
                BeginWriteAttribute("value", " value=\"", 1258, "\"", 1266, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""portField"" />
			</td>
			<td>
				<input id=""schemeField"" type=""checkbox"" name=""schemeField"" checked=""true"" />
				HTTPS
			</td>
		</tr>
		<tr>
			<td>
				<b>App ID:</b>
			</td>
			<td>
				<input name=""appIdField"" type=""text"" style=""width:20em""");
                BeginWriteAttribute("value", " value=\"", 1533, "\"", 1541, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"appIdField\" />\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t<b>App Key:</b>\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t<input name=\"appKeyField\" type=\"text\" style=\"width:20em\"");
                BeginWriteAttribute("value", " value=\"", 1682, "\"", 1690, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""appKeyField"" />
			</td>
		</tr>
	</table>
	<div id=""userDiv"">
		<br />
		<span>This information is returned by the authentication server and is valid only for this application:</span>
		<table>
			<tr>
				<td>
					<b>User ID:</b>
				</td>
				<td>
					<input name=""userIdField"" type=""text"" style=""width:20em"" id=""userIdField"" />
				</td>
			</tr>
			<tr>
				<td>
					<b>User Key:</b>
				</td>
				<td>
					<input name=""userKeyField"" type=""text"" style=""width:20em"" id=""userKeyField"" />
				</td>
			</tr>
		</table>
		<input type=""button"" name=""authBtn"" value=""Deauthenticate"" id=""deauthButton"" onclick=""deauthenticate()"">
	</div>
	<span id=""authNotice"">Note: to authenticate against the test server, you can user username
						  ""sampleapiuser"" and password ""Tisabiiif"".
	</span><br />
	<input type=""button"" name=""authBtn"" value=""Authenticate"" id=""authenticateButton"" onclick=""authenticateUser(); ui()""/><br />
    <input type=""button"" id=""manualBtn"" value=""Manually set creden");
                WriteLiteral(@"tials"" onclick=""setCredentials()"" />
    <input type=""button"" name=""authBtn"" value=""Save"" id=""manualAuthBtn"" hidden=true onclick=""saveCredentials()""/>

	<hr />
	<table>
		<tr>
			<td>
				<b>Examples:</b>
			</td>
			<td>
				<button type=""button"" onclick=""exampleGetVersions()"">
					Get Versions</button>
			</td>
		</tr>
		<tr>
			<td>
			</td>
			<td>
				<button type=""button"" onclick=""exampleWhoAmI()"">
					WhoAmI</button>
			</td>
		</tr>
		<tr>
			<td></td>
			<td>
				<button type=""button"" onclick=""exampleCreateUser()"">
					Create User</button>
			</td>
		</tr>
	</table>
	<br />
	<b>Method:</b>&nbsp;
	<input value=""GET"" name=""method"" type=""radio"" id=""GETField"" onclick=""hideData()"" />GET
	&nbsp;
	<input value=""POST"" name=""method"" type=""radio"" id=""POSTField"" onclick=""showData()"" />POST
    &nbsp;
    <input value=""PUT"" name=""method"" type=""radio"" id=""PUTField"" onclick=""showData()"" />PUT
    &nbsp;
    <input value=""DELETE"" name=""method"" type=""radio"" id=""DELETEField"" o");
                WriteLiteral(@"nclick=""hideData()"" />DELETE<br />
	<b>Action:</b>&nbsp;<input name=""actionField"" type=""text"" id=""actionField"" style=""width:600px;"" /><br />
	<b id=""dataFieldLabel"">Data:</b><br />
	<textarea name=""dataField"" rows=""2"" cols=""20"" id=""dataField"" style=""height:400px;width:600px;"">
</textarea><br />
	<b id=""responseFieldLabel"" hidden=""false"">Response:</b><br />
	<textarea name=""responseField"" hidden=""false"" rows=""2"" cols=""20"" id=""responseField"" style=""height:400px;width:600px;"">
</textarea><br />
	<input type=""button"" name=""submitButton"" value=""Submit"" id=""submitButton"" onclick=""doAPIRequest()""/>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
	function deleteAllCookies() {
		var cookies = document.cookie.split("";"");

		for (var i = 0; i < cookies.length; i++) {
			var cookie = cookies[i];
			var eqPos = cookie.indexOf(""="");
			var name = eqPos > -1 ? cookie.substr(0, eqPos) : cookie;
			document.cookie = name + ""=;expires=Thu, 01 Jan 1970 00:00:00 GMT"";
		}
	}

	function setCookie(obj) {
		deleteAllCookies();
		document.cookie = ""GettingStartedSettings="" + escape(JSON.stringify(obj));
	}

	function getCookie() {
		var obj = {}
		try {
			cookie = document.cookie.match(/GettingStartedSettings=[^;]*;?/)[0].replace(/[^=]*=/, '').replace(/;?\ *$/, '');
			obj = JSON.parse(unescape(cookie));
		} catch(e) {
			// ignore
		}
		return obj;
	}

	function showData() {
		document.getElementById(""dataFieldLabel"").hidden = false;
		document.getElementById(""dataField"").hidden=false;
	}

	function hideData() {
		document.getElementById(""dataFieldLabel"").hidden = true;
		document.getElementById(");
            WriteLiteral(@"""dataField"").hidden=true;
	}

	function exampleGetVersions() {
		hideData();
		document.getElementById(""GETField"").checked = true;
		document.getElementById(""actionField"").value = ""/d2l/api/versions/"";
	}

	function exampleWhoAmI() {
		hideData();
		document.getElementById(""GETField"").checked = true;
		document.getElementById(""actionField"").value = ""/d2l/api/lp/1.0/users/whoami"";
	}

    function exampleCreateUser() {
        showData();
        document.getElementById(""POSTField"").checked = true;
        document.getElementById(""actionField"").value = ""/d2l/api/lp/1.0/users/"";
        document.getElementById(""dataField"").value = ""{\n  \""OrgDefinedId\"": \""<string>\"",\n  \""FirstName\"": \""<string>\"",\n  \""MiddleName\"": \""<string>\"",\n  \""LastName\"": \""<string>\"",\n  \""ExternalEmail\"": \""<string>|null\"",\n  \""UserName\"": \""<string>\"",\n  \""RoleId\"": \""<number>\"",\n  \""IsActive\"": \""<boolean>\"",\n  \""SendCreationEmail\"": \""<boolean>\""\n}"";
    }

    function setCredentials() {
        docum");
            WriteLiteral(@"ent.getElementById(""manualAuthBtn"").hidden = false;
        document.getElementById(""deauthButton"").hidden = true;
        document.getElementById(""userDiv"").hidden = false;
        document.getElementById(""userIdField"").hidden = false;
        document.getElementById(""userKeyField"").hidden = false;
        document.getElementById(""manualBtn"").hidden = true;
        document.getElementById(""authenticateButton"").hidden = true;
        document.getElementById(""authNotice"").hidden = true;
    }

	function saveCredentials() {
		var values = getCookie();
		values.userId = document.getElementById(""userIdField"").value;
		values.userKey = document.getElementById(""userKeyField"").value;
		setCookie(values);
		window.location.replace('index.html');
	}

	function ui() {
		hideData();
		if(document.getElementById(""userIdField"").value === """") document.getElementById(""userIdField"").value = localStorage.userId || """";
		if(document.getElementById(""userKeyField"").value === """") document.getElementById(""user");
            WriteLiteral(@"KeyField"").value = localStorage.userKey || """";
		if(document.getElementById(""userIdField"").value !== """") {
			document.getElementById(""userIdField"").disabled = true;
			document.getElementById(""userKeyField"").disabled = true;
			document.getElementById(""manualBtn"").hidden = true;
			document.getElementById(""authenticateButton"").hidden = true;
			document.getElementById(""authNotice"").hidden = true;
			document.getElementById(""hostField"").disabled = true;
			document.getElementById(""portField"").disabled = true;
			document.getElementById(""appKeyField"").disabled = true;
			document.getElementById(""appIdField"").disabled = true;
		} else {
			document.getElementById(""userIdField"").hidden = true;
			document.getElementById(""userKeyField"").hidden = true;
			document.getElementById(""userDiv"").hidden = true;
			document.getElementById(""hostField"").disabled = false;
			document.getElementById(""portField"").disabled = false;
			document.getElementById(""appKeyField"").disabled = false;
			document.getElem");
            WriteLiteral(@"entById(""appIdField"").disabled = false;
		}
	}

	function defaults() {
		setCookie({});
		window.location.replace('index.html');
	}

	function init() {
		var values = getCookie();
		if(typeof values.host == 'undefined' || values.host === '') values.host = ""ava.grupotiradentes.com"";
		if(typeof values.port == 'undefined' || values.port === '') values.port = 443;
		if(typeof values.scheme == 'undefined' || values.scheme === '') values.scheme = ""https"";
		if(typeof values.appId == 'undefined' || values.appId === '') values.appId = ""iWAAJYnl0IMj9CM94T8A3w"";
		if(typeof values.appKey == 'undefined' || values.appKey === '') values.appKey = ""TrHRH1CvZUccEeQUp5Ufvg"";
		setCookie(values);

		document.getElementById(""hostField"").value = values.host;
		document.getElementById(""portField"").value = values.port;
		document.getElementById(""schemeField"").checked = ( values.scheme === ""https"" );
		document.getElementById(""appIdField"").value = values.appId;
		document.getElementById(""appKeyField"").value =");
            WriteLiteral(" values.appKey;\r\n\r\n\t\tui();\r\n\t}\r\n</script>\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
