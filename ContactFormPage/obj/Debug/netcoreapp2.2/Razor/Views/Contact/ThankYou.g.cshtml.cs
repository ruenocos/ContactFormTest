#pragma checksum "C:\Users\Wesse\source\repos\ContactFormPage\ContactFormPage\Views\Contact\ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f816da7c2eb2ac6e02069559f335ebabc71d74cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ThankYou), @"mvc.1.0.view", @"/Views/Contact/ThankYou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/ThankYou.cshtml", typeof(AspNetCore.Views_Contact_ThankYou))]
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
#line 1 "C:\Users\Wesse\source\repos\ContactFormPage\ContactFormPage\Views\_ViewImports.cshtml"
using ContactFormPage;

#line default
#line hidden
#line 2 "C:\Users\Wesse\source\repos\ContactFormPage\ContactFormPage\Views\_ViewImports.cshtml"
using ContactFormPage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f816da7c2eb2ac6e02069559f335ebabc71d74cd", @"/Views/Contact/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b035534301b008d1d15108414f1a5e2e5bd46d2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Wesse\source\repos\ContactFormPage\ContactFormPage\Views\Contact\ThankYou.cshtml"
  
    ViewData["Title"] = "ThankYou";

#line default
#line hidden
            BeginContext(46, 192, true);
            WriteLiteral("\r\n<div class=\"alert alert-success\" role=\"alert\">\r\n    Uw bericht is succesvol verstuurt.\r\n</div>\r\n\r\n<h5>Klik <a class=\"text-decoration-none\" href=\"/contact\">hier</a> om terug te gaan.</h5>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
