#pragma checksum "C:\Users\user\source\repos\DotNetCoreWebAppSample\DotNetCoreWebAppSample\Views\Error\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89137467e7fee68e899a6feca53f0a82cbdf9c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Index), @"mvc.1.0.view", @"/Views/Error/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/Index.cshtml", typeof(AspNetCore.Views_Error_Index))]
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
#line 1 "C:\Users\user\source\repos\DotNetCoreWebAppSample\DotNetCoreWebAppSample\Views\_ViewImports.cshtml"
using DotNetCoreWebAppSample;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\DotNetCoreWebAppSample\DotNetCoreWebAppSample\Views\_ViewImports.cshtml"
using DotNetCoreWebAppSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89137467e7fee68e899a6feca53f0a82cbdf9c4", @"/Views/Error/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f75139a8de2f80b981d27b5671a6ce8dc646d03", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\source\repos\DotNetCoreWebAppSample\DotNetCoreWebAppSample\Views\Error\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 708, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    

<div class=""row"">
    <div class=""col"">
        <h2>Wanna Throw Some Exception?</h2>
        <p>Will run the following:</p>
        <pre>
            throw new SystemException(""This is a generated system exception in ErrorController.ThrowException"");
        </pre>
        <a href=""/Error/ThrowException"">Throw!</a>
    </div>
</div>
<div class=""row"">
    <div class=""col"">
        <h2>Wanna Kill this application instance?</h2>
        <p>Will run the following:</p>
        <pre>
            Environment.Exit(-1);
        </pre>
        <a href=""/Error/Kill"">Kill!</a>
    </div>
</div>
");
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
