#pragma checksum "D:\chon\chonticha2\chonticha2\Views\Home\Plus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b81d4836e3ea06ed6c40c9c5ac67617bb2e9b55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Plus), @"mvc.1.0.view", @"/Views/Home/Plus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Plus.cshtml", typeof(AspNetCore.Views_Home_Plus))]
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
#line 1 "D:\chon\chonticha2\chonticha2\Views\_ViewImports.cshtml"
using chonticha2;

#line default
#line hidden
#line 2 "D:\chon\chonticha2\chonticha2\Views\_ViewImports.cshtml"
using chonticha2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b81d4836e3ea06ed6c40c9c5ac67617bb2e9b55", @"/Views/Home/Plus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16bf6b523150ebb06ec0adea03fdad3192db543", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Plus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\chon\chonticha2\chonticha2\Views\Home\Plus.cshtml"
  
    ViewData["Title"] = "Plus";

#line default
#line hidden
            BeginContext(42, 38, true);
            WriteLiteral("\r\n<h1>Plus</h1>\r\n\r\nบวกกันได้ผลลัพธ์ = ");
            EndContext();
            BeginContext(81, 15, false);
#line 8 "D:\chon\chonticha2\chonticha2\Views\Home\Plus.cshtml"
              Write(ViewData["ans"]);

#line default
#line hidden
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
