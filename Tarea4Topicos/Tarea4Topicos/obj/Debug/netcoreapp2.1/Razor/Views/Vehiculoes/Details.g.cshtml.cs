#pragma checksum "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c2c831759b1f92d73e92cd8a60833c8e40692bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehiculoes_Details), @"mvc.1.0.view", @"/Views/Vehiculoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehiculoes/Details.cshtml", typeof(AspNetCore.Views_Vehiculoes_Details))]
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
#line 1 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\_ViewImports.cshtml"
using Tarea4Topicos;

#line default
#line hidden
#line 2 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\_ViewImports.cshtml"
using Tarea4Topicos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2c831759b1f92d73e92cd8a60833c8e40692bd", @"/Views/Vehiculoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c592aea137a9f037cae706374ab488768f3f6ae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehiculoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tarea4Topicos.Models.Vehiculo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 145, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Vehiculo</h4>\r\n    <hr />\r\n    <div>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(229, 41, false);
#line 15 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(270, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(326, 37, false);
#line 18 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(363, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(419, 40, false);
#line 21 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Anio));

#line default
#line hidden
            EndContext();
            BeginContext(459, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(515, 36, false);
#line 24 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Anio));

#line default
#line hidden
            EndContext();
            BeginContext(551, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(607, 51, false);
#line 27 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoVehiculoRef));

#line default
#line hidden
            EndContext();
            BeginContext(658, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(714, 59, false);
#line 30 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
           Write(Html.DisplayFor(model => model.TipoVehiculoRef.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(773, 215, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Id Estacionamiento</th>\r\n            <th>Parqueo</th>\r\n            <th>Total a Pagar</th>\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
         foreach (var item in Model.ListaEstacionamientos)
        {

#line default
#line hidden
            BeginContext(1059, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(1082, 22, false);
#line 45 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
       Write(item.EstacionamientoId);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1124, 26, false);
#line 46 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
       Write(item.ParqueoId.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1170, 16, false);
#line 47 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
       Write(item.TotalAPagar);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 22, true);
            WriteLiteral("</td>\r\n\r\n\r\n    </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1219, 33, true);
            WriteLiteral("    </table>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1252, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56708fbbf18443e9bb5c5078d17ca846", async() => {
                BeginContext(1306, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Vehiculoes\Details.cshtml"
                           WriteLiteral(Model.VehiculoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1314, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1322, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aaaf23ebd76407c92704c9cf571e644", async() => {
                BeginContext(1344, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1360, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tarea4Topicos.Models.Vehiculo> Html { get; private set; }
    }
}
#pragma warning restore 1591
