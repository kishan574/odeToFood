#pragma checksum "C:\Users\Dell\source\repos\ode2Food\Pages\Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5fbe48a391d3f54958dbd94b3ba1234073217f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Greeting), @"mvc.1.0.razor-page", @"/Pages/Greeting.cshtml")]
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
#line 6 "C:\Users\Dell\source\repos\ode2Food\Pages\_ViewImports.cshtml"
using ode2Food.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\source\repos\ode2Food\Pages\_ViewImports.cshtml"
using ode2Food.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dell\source\repos\ode2Food\Pages\_ViewImports.cshtml"
using ode2Food.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dell\source\repos\ode2Food\Pages\_ViewImports.cshtml"
using ode2Food.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5fbe48a391d3f54958dbd94b3ba1234073217f", @"/Pages/Greeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed72e8a59f79d82ae64ad9cae5dd0fb9adbfbd5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Greeting : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 4 "C:\Users\Dell\source\repos\ode2Food\Pages\Greeting.cshtml"
Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    Hello World!\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Greeting> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Greeting> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Greeting>)PageContext?.ViewData;
        public Pages_Greeting Model => ViewData.Model;
    }
}
#pragma warning restore 1591
