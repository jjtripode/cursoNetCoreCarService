#pragma checksum "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1cd8bec843c658eb94deb2c5af4232d9aad064"
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
#line 1 "C:\Users\cisco\Documents\repoVehiculos\Views\_ViewImports.cshtml"
using CarServiceFronted;

#line default
#line hidden
#line 2 "C:\Users\cisco\Documents\repoVehiculos\Views\_ViewImports.cshtml"
using CarServiceFronted.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1cd8bec843c658eb94deb2c5af4232d9aad064", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c26beb67ac006e4ef91bd3f08d4ba0f862bb27", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
    ViewData["Title"] = "Usuarios"; 

#line default
#line hidden
            BeginContext(63, 76, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(140, 17, false);
#line 5 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(157, 258, true);
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
#line 17 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
         foreach (var item in Model.Users) 
        {

#line default
#line hidden
            BeginContext(469, 42, true);
            WriteLiteral("       <tr>\n           <td>\n              ");
            EndContext();
            BeginContext(512, 26, false);
#line 21 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
         Write(item.IdentityUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(538, 48, true);
            WriteLiteral("\n           </td>\n           <td>\n              ");
            EndContext();
            BeginContext(587, 23, false);
#line 24 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
         Write(item.IdentityUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(610, 48, true);
            WriteLiteral("\n           </td>\n           <td>\n              ");
            EndContext();
            BeginContext(659, 20, false);
#line 27 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
         Write(item.RolesToString());

#line default
#line hidden
            EndContext();
            BeginContext(679, 54, true);
            WriteLiteral("\n           </td>\n               <td  class=\"EditUser\"");
            EndContext();
            BeginWriteAttribute("userId", " userId=\"", 733, "\"", 763, 1);
#line 29 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
WriteAttributeValue("", 742, item.IdentityUser.Id, 742, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(764, 269, true);
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
#line 38 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1043, 134, true);
            WriteLiteral("    </table>\n    \n<div class=\"modal fade\" id=\"editUserModel\">\n\n</div>\n\n\n    <div class=\"panel-footer add-item-form\">\n        \n        ");
            EndContext();
            BeginContext(1178, 76, false);
#line 48 "C:\Users\cisco\Documents\repoVehiculos\Views\Users\Index.cshtml"
   Write(await Html.PartialAsync("AddNewUserPartial", Model.GetAddNewUserViewModel()));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 23, true);
            WriteLiteral("\n\n    </div>\n</div>\n\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1294, 1040, true);
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

           return false;
     }");
                WriteLiteral(");\n\t\n\t</script>\n");
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
