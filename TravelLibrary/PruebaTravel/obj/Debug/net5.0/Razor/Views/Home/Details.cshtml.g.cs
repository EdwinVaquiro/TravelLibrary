#pragma checksum "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e609730e1ef3bcbbbbeff711e0da399f2150c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\_ViewImports.cshtml"
using PruebaTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\_ViewImports.cshtml"
using PruebaTravel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e609730e1ef3bcbbbbeff711e0da399f2150c8", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d955d20c58b4a647905bafc19d8cc516bc706720", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PruebaTravel.Models.DetalleLibros>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h1>");
#nullable restore
#line 10 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
           Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n                <div class=\"col-8\">\r\n                    <p class=\"text-justify\">\r\n                        Sinopsis: <br>\r\n                        ");
#nullable restore
#line 17 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
                   Write(item.Sinopsis);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n                <div class=\"col-4\">\r\n                    <p class=\"text-justify\">\r\n                        Autor del libro: ");
#nullable restore
#line 23 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
                                    Write(item.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                        Número de páginas: ");
#nullable restore
#line 24 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
                                      Write(item.Npaginas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
                    </p>
                </div>

              

            </div>

        </div>

            <div class=""card-footer"">
               <div class=""row"">
                   <div class=""col-md-12"">
                       <p>
                          Editorial: ");
#nullable restore
#line 38 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
                                Write(item.Editorial);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                          Sede de la editorial: ");
#nullable restore
#line 39 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
                                           Write(item.SedeEditorial);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       </p>\r\n                   </div>\r\n               </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\Edwin Sandoval\OneDrive\Desktop\PruebaTravel\PruebaTravel\Views\Home\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PruebaTravel.Models.DetalleLibros>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591