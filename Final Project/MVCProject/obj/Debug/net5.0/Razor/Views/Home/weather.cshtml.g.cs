#pragma checksum "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "016b4d837f4c78daadfa85858623c0b110a3a314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_weather), @"mvc.1.0.view", @"/Views/Home/weather.cshtml")]
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
#line 1 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016b4d837f4c78daadfa85858623c0b110a3a314", @"/Views/Home/weather.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f87f51910e1016d2b81c8d4107669623c21b1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_weather : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 1 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n<p><b>Forecast Date: </b>");
#nullable restore
#line 4 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
                    Write(Model.forecastDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Location: </b>");
#nullable restore
#line 6 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
               Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Temperature: </b>");
#nullable restore
#line 8 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
                  Write(Model.temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Feels Like: </b>");
#nullable restore
#line 10 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
                 Write(Model.feelsLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Desciptor: </b>");
#nullable restore
#line 12 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
                Write(Model.descriptor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Image Path: </b>");
#nullable restore
#line 14 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
                 Write(Model.imagePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Wind Speed: </b>");
#nullable restore
#line 16 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
                 Write(Model.windSpeed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Wind Direction: </b>");
#nullable restore
#line 18 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
                     Write(Model.windDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p><b>Pressure: </b>");
#nullable restore
#line 20 "C:\Users\joesc\OneDrive\Desktop\C#\gitRepo\Final Project\MVCProject\Views\Home\weather.cshtml"
               Write(Model.pressure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
