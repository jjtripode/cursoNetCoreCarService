#pragma checksum "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31da992f1ca175e5addaf95d03d7e5338a4a362f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Automoviles_Index), @"mvc.1.0.view", @"/Views/Automoviles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Automoviles/Index.cshtml", typeof(AspNetCore.Views_Automoviles_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Practicas\CursoNetCoreCarService\Views\_ViewImports.cshtml"
using CarServiceFronted;

#line default
#line hidden
#line 2 "D:\Practicas\CursoNetCoreCarService\Views\_ViewImports.cshtml"
using CarServiceFronted.Models;

#line default
#line hidden
#line 2 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
using cursoNetCoreCarService.Models;

#line default
#line hidden
#line 4 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
using CursoNetCoreCarService.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31da992f1ca175e5addaf95d03d7e5338a4a362f", @"/Views/Automoviles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c26beb67ac006e4ef91bd3f08d4ba0f862bb27", @"/Views/_ViewImports.cshtml")]
    public class Views_Automoviles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
  
  ViewData["Title"] = "Services History";

#line default
#line hidden
            BeginContext(176, 74, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n\t<div class=\"panel-heading\">");
            EndContext();
            BeginContext(251, 17, false);
#line 10 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(268, 223, true);
            WriteLiteral("</div>\r\n\t\t<table class=\"table table-hover\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<td>&#x2714;</td>\r\n\t\t\t\t\t<td>Marca</td>\r\n\t\t\t\t\t<td>Model</td>\r\n\t\t\t\t\t<td>Año</td>\r\n\t\t\t\t\t<td>Service</td>\r\n\t\t\t\t\t<td>Agregar</td>\r\n\t\t\t\t</tr>\r\n\t\t  </thead>\r\n");
            EndContext();
#line 22 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
           foreach (var item in Model.Items)
		  {

#line default
#line hidden
            BeginContext(538, 90, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<input type=\"checkbox\" class=\"done-checkbox\">\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(629, 10, false);
#line 28 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
               Write(item.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(639, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(655, 10, false);
#line 29 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
               Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(665, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(681, 9, false);
#line 30 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
               Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(690, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(706, 25, false);
#line 31 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
               Write(item.GetNextCarServices());

#line default
#line hidden
            EndContext();
            BeginContext(731, 43, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>agregar</td>\r\n\t\t\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 35 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
		  }

#line default
#line hidden
            BeginContext(781, 61, true);
            WriteLiteral("\t  </table>\r\n\r\n  <div class=\"panel-footer add-item-form\">\r\n  ");
            EndContext();
            BeginContext(843, 51, false);
#line 39 "D:\Practicas\CursoNetCoreCarService\Views\Automoviles\Index.cshtml"
Write(await Html.PartialAsync("AddCarPartial", new Car()));

#line default
#line hidden
            EndContext();
            BeginContext(894, 18, true);
            WriteLiteral("\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
