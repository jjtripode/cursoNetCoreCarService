#pragma checksum "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1164e091b6b323730de53df3b03ef642fc96f43c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1164e091b6b323730de53df3b03ef642fc96f43c", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c26beb67ac006e4ef91bd3f08d4ba0f862bb27", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
    ViewData["Title"] = "Usuarios"; 

#line default
#line hidden
            BeginContext(66, 77, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(144, 17, false);
#line 5 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(161, 270, true);
            WriteLiteral(@"</div>
    
<table id=""usersTable"" class=""table table-hover"">
        <thead>
            <tr>
                <td>Nombre</td>
                <td>Email</td>
                <td>Roles </td>
                <td>Editar</td>
            </tr>
        </thead>

");
            EndContext();
#line 17 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
         foreach (var item in Model.Users) 
        {

#line default
#line hidden
            BeginContext(487, 44, true);
            WriteLiteral("       <tr>\r\n           <td>\r\n              ");
            EndContext();
            BeginContext(532, 26, false);
#line 21 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
         Write(item.IdentityUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(558, 51, true);
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n              ");
            EndContext();
            BeginContext(610, 23, false);
#line 24 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
         Write(item.IdentityUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(633, 51, true);
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n              ");
            EndContext();
            BeginContext(685, 20, false);
#line 27 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
         Write(item.RolesToString());

#line default
#line hidden
            EndContext();
            BeginContext(705, 56, true);
            WriteLiteral("\r\n           </td>\r\n               <td  class=\"EditUser\"");
            EndContext();
            BeginWriteAttribute("userId", " userId=\"", 761, "\"", 791, 1);
#line 29 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
WriteAttributeValue("", 770, item.IdentityUser.Id, 770, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(792, 278, true);
            WriteLiteral(@" > 
                <span class=""table-remove"">
                <button type=""button""
                  class=""btn btn-danger btn-rounded btn-sm my-0"">
                  Editar Rol
                  </button>
                  </span> 
            </td> 
        </tr>
");
            EndContext();
#line 38 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1081, 143, true);
            WriteLiteral("    </table>\r\n    \r\n<div class=\"modal fade\" id=\"editUserModel\">\r\n\r\n</div>\r\n\r\n\r\n    <div class=\"panel-footer add-item-form\">\r\n        \r\n        ");
            EndContext();
            BeginContext(1225, 76, false);
#line 48 "D:\Practicas\CursoNetCoreCarService\Views\Users\Index.cshtml"
   Write(await Html.PartialAsync("AddNewUserPartial", Model.GetAddNewUserViewModel()));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 30, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1348, 1072, true);
                WriteLiteral(@"
	<script type=""text/javascript"">

 $(function () {

           $(""#usersTable .EditUser"").click(function () {
             
                var userId = $(this).closest(""tr"").find(""td"").eq(3).attr(""userId"");
                $.ajax({
                    type: ""Get"",
                    url: ""/Users/EditUser"",
                    data: 'userId=' + userId,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""html"",
                    success: function (response) {
                         $('#editUserModel').html('');
                        $('#editUserModel').html(response);
                       $(""#editUserModel"").modal();
                    },
                    failure: function (response) {
                        alert(response.responseText);
                    },
                    error: function (response) {
                        alert(response.responseText);
                    }
                });
           });

   ");
                WriteLiteral("        return false;\r\n     });\r\n\t\r\n\t</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
