#pragma checksum "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6735f3128e79a6f42497c411f302bbd7c4e3ba3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Index), @"mvc.1.0.view", @"/Views/Vehicles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicles/Index.cshtml", typeof(AspNetCore.Views_Vehicles_Index))]
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
#line 1 "D:\Practicas\CursoNetCoreCarService\Views\_ViewImports.cshtml"
using CarServiceFronted;

#line default
#line hidden
#line 2 "D:\Practicas\CursoNetCoreCarService\Views\_ViewImports.cshtml"
using CarServiceFronted.Models;

#line default
#line hidden
#line 2 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
using CarServiceFronted.Extensions;

#line default
#line hidden
#line 3 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6735f3128e79a6f42497c411f302bbd7c4e3ba3f", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c26beb67ac006e4ef91bd3f08d4ba0f862bb27", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
    ViewData["Title"] = "Services History"; 

#line default
#line hidden
            BeginContext(133, 77, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(211, 17, false);
#line 7 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(228, 432, true);
            WriteLiteral(@"</div>
   
    <table id=""vehiclesTable"" class=""table table-hover"">
        <thead>
            <tr>
                <td>&#x2714;</td>
                <td>Marca</td>
                <td>Model</td>
                <td>Año</td>
                <td>Patente</td>
                <td>Proximo Service</td>
                <td>Crear Service</td> 
                <td>Detalle Services</td>
            </tr>
        </thead>
");
            EndContext();
#line 22 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
         foreach (var item in Model.Items) {

#line default
#line hidden
            BeginContext(706, 130, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\" class=\"done-checkbox\">\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(837, 10, false);
#line 27 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(847, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(871, 10, false);
#line 28 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(881, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(905, 22, false);
#line 29 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.ManufacturingDate);

#line default
#line hidden
            EndContext();
            BeginContext(927, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(951, 20, false);
#line 30 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.CarLicensePlate);

#line default
#line hidden
            EndContext();
            BeginContext(971, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(995, 25, false);
#line 31 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.GetNextCarServices());

#line default
#line hidden
            EndContext();
            BeginContext(1020, 44, true);
            WriteLiteral("</td>\r\n            <td  class=\"CrearService\"");
            EndContext();
            BeginWriteAttribute("vehicleId", " vehicleId=\"", 1064, "\"", 1084, 1);
#line 32 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1076, item.ID, 1076, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1085, 287, true);
            WriteLiteral(@" > 
                <span class=""table-remove"">
                <button type=""button""
                  class=""btn btn-danger btn-rounded btn-sm my-0"">Agregar Service
                  </button>
                  </span> 
            </td> 
            <td  class=""DetalleService""");
            EndContext();
            BeginWriteAttribute("vehicleId", " vehicleId=\"", 1372, "\"", 1392, 1);
#line 39 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1384, item.ID, 1384, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1393, 299, true);
            WriteLiteral(@"> 
                                <span class=""table-remove"">
                <button type=""button""
                  class=""btn btn-danger btn-rounded btn-sm my-0"">Detalle Servicios
                  </button>
                  </span> 
                 </td> 
            
        </tr>
");
            EndContext();
#line 48 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1703, 198, true);
            WriteLiteral("    </table>\r\n\r\n    \r\n<div class=\"modal fade\" id=\"myModal\">\r\n\r\n</div>\r\n<div class=\"modal fade\" id=\"DetailsServieDialog\">\r\n\r\n</div>\r\n\r\n    <div class=\"panel-footer add-item-form\">\r\n        \r\n        ");
            EndContext();
            BeginContext(1902, 71, false);
#line 61 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
   Write(await Html.PartialAsync("AddVehiclePartial", Model.AddVehicleViewModel));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 30, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2020, 2293, true);
                WriteLiteral(@"
	<script type=""text/javascript"">

 $(function () {
 $(""#dialog"").dialog({
                autoOpen: false,
                modal: true,
                title: ""Agregar Servicio""
            });


           $(""#vehiclesTable .CrearService"").click(function () {
             
                var vehicleId = $(this).closest(""tr"").find(""td"").eq(6).attr(""vehicleId"");

              

                $.ajax({
                    type: ""Get"",
                    url: ""/Vehicles/CreateService"",
                    data: 'vehicleId=' + vehicleId,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""html"",
                    success: function (response) {
                         $('#myModal').html('');
                        $('#myModal').html(response);
                       $(""#myModal"").modal();
                    },
                    failure: function (response) {
                        alert(response.responseText);
               ");
                WriteLiteral(@"     },
                    error: function (response) {
                        alert(response.responseText);
                    }
                });
           });

           $(""#vehiclesTable .DetalleService"").click(function () {
              var vehicleId = $(this).closest(""tr"").find(""td"").eq(6).attr(""vehicleId"");
              
                $.ajax({
                    type: ""Get"",
                    url: ""/Vehicles/DetailsService"",
                    data: 'vehicleId=' + vehicleId,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""html"",
                    success: function (response) {
                        $('#DetailsServieDialog').html('');
                        $('#DetailsServieDialog').html(response);
                        $('#DetailsServieDialog').modal();
                    },
                    failure: function (response) {
                        alert('failure: ' + response.responseText);
               ");
                WriteLiteral("     },\r\n                    error: function (response) {\r\n                        alert(\'error: \' + response.responseText);\r\n                    }\r\n                });\r\n           });\r\n\r\n           return false;\r\n     });\r\n\r\n\r\n\r\n\t\r\n\t</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
