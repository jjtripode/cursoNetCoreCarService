#pragma checksum "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bdecec4d1d8ceb5f8499911c4a7b677f1ac2ffd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bdecec4d1d8ceb5f8499911c4a7b677f1ac2ffd", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c26beb67ac006e4ef91bd3f08d4ba0f862bb27", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
   ViewData["Title"] = "Services History"; 

#line default
#line hidden
            BeginContext(131, 77, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(209, 17, false);
#line 6 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(226, 435, true);
            WriteLiteral(@"</div>

    <table id=""vehiclesTable"" class=""table table-hover"">
        <thead>
            <tr>
                <td>&#x2714;</td>
                <td>Marca</td>
                <td>Model</td>
                <td>Antiguedad</td>
                <td>Patente</td>
                <td>Proximo Service</td>
                <td>Crear Service</td>
                <td>Detalle Services</td>
            </tr>
        </thead>
");
            EndContext();
#line 21 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
         foreach (var item in Model.Items) {

#line default
#line hidden
            BeginContext(707, 130, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\" class=\"done-checkbox\">\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(838, 10, false);
#line 26 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(848, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(872, 10, false);
#line 27 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(882, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(906, 33, false);
#line 28 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.ManufacturingDate.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(939, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(963, 20, false);
#line 29 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.CarLicensePlate);

#line default
#line hidden
            EndContext();
            BeginContext(983, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1007, 25, false);
#line 30 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
           Write(item.GetNextCarServices());

#line default
#line hidden
            EndContext();
            BeginContext(1032, 43, true);
            WriteLiteral("</td>\r\n            <td class=\"CrearService\"");
            EndContext();
            BeginWriteAttribute("vehicleId", " vehicleId=\"", 1075, "\"", 1095, 1);
#line 31 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1087, item.ID, 1087, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1096, 282, true);
            WriteLiteral(@">
                <span class=""table-remove"">
                <button type=""button""
                  class=""btn btn-danger btn-rounded btn-sm my-0"">Agregar Service
                  </button>
                  </span>
            </td>
            <td class=""DetalleService""");
            EndContext();
            BeginWriteAttribute("vehicleId", " vehicleId=\"", 1378, "\"", 1398, 1);
#line 38 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1390, item.ID, 1390, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1399, 263, true);
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
#line 47 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1673, 333, true);
            WriteLiteral(@"    </table>

<<<<<<< HEAD
    
<div class=""modal fade"" id=""createNewServiceDialog"">
=======
    <div class=""modal fade"" id=""myModal"">
>>>>>>> 0b875ab950edfbf4df447d8c256316d960170838

    </div>
    <div class=""modal fade"" id=""DetailsServieDialog"">

    </div>

    <div class=""panel-footer add-item-form"">

        ");
            EndContext();
            BeginContext(2007, 71, false);
#line 64 "D:\Practicas\CursoNetCoreCarService\Views\Vehicles\Index.cshtml"
   Write(await Html.PartialAsync("AddVehiclePartial", Model.AddVehicleViewModel));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 26, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2121, 2643, true);
                WriteLiteral(@"
	<script type=""text/javascript"">

 $(function () {
 
           $(""#vehiclesTable .CrearService"").click(function () {
             
                var vehicleId = $(this).closest(""tr"").find(""td"").eq(6).attr(""vehicleId"");

                $.ajax({
                    type: ""Get"",
                    url: ""/Vehicles/CreateService"",
                    data: 'vehicleId=' + vehicleId,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""html"",
                    success: function (response) {
                         $('#createNewServiceDialog').html('');
                        $('#createNewServiceDialog').html(response);
                        $('#dtpDateService').datepicker({
                            format: 'dd/mm/yyyy',
                            uiLibrary: 'bootstrap4',
                            setDate: new Date()
                        });
                       $(""#createNewServiceDialog"").modal();
                    },
  ");
                WriteLiteral(@"                  failure: function (response) {
                        alert(response.responseText);
                    },
                    error: function (response) {
                        alert(response.responseText);
                    }
                });
           });

           $(""#vehiclesTable .DetalleService"").click(function () {
              
              var vehicleId = $(this).closest(""tr"").find(""td"").eq(6).attr(""vehicleId"");
              alert(vehicleId);
                $.ajax({
                    type: ""Get"",
                    url: ""/Vehicles/DetailsService"",
                    data: 'vehicleId=' + vehicleId,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""html"",
                    success: function (response) {
                        $('#DetailsServieDialog').html('');
                        $('#DetailsServieDialog').html(response);
                        
                        $('#DetailsServie");
                WriteLiteral(@"Dialog').modal();
                    },
                    failure: function (response) {
                       
                        $('#DetailsServieDialog').html('');
                        $('#DetailsServieDialog').html(response);
                    },
                    error: function (response) {
                        $('#DetailsServieDialog').html('');
                        $('#DetailsServieDialog').html(response);
                        
                    }
                });
           });

           return false;
     });



	
	</script>
");
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
