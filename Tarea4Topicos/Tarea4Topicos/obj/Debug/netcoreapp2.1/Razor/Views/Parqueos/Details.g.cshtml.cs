#pragma checksum "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "483da2a33bf901fa507db04a13c72141fcd6fa1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parqueos_Details), @"mvc.1.0.view", @"/Views/Parqueos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parqueos/Details.cshtml", typeof(AspNetCore.Views_Parqueos_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"483da2a33bf901fa507db04a13c72141fcd6fa1b", @"/Views/Parqueos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c592aea137a9f037cae706374ab488768f3f6ae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Parqueos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tarea4Topicos.Models.Parqueo>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Parqueo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(204, 47, false);
#line 14 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 43, false);
#line 17 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(338, 200, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Id Estacionamiento</th>\r\n            <th>Id Vehiculo</th>\r\n            <th>Placa Vehiculo</th>\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
         foreach (var item in Model.ListaEstacionamientos)
        {

#line default
#line hidden
            BeginContext(609, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(632, 22, false);
#line 31 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
       Write(item.EstacionamientoId);

#line default
#line hidden
            EndContext();
            BeginContext(654, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(674, 26, false);
#line 32 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
       Write(item.VehiculoId.VehiculoId);

#line default
#line hidden
            EndContext();
            BeginContext(700, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(720, 21, false);
#line 33 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
       Write(item.VehiculoId.Placa);

#line default
#line hidden
            EndContext();
            BeginContext(741, 20, true);
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(772, 33, true);
            WriteLiteral("    </table>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(805, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8f42601d3ba47ab91de86f39d863ce6", async() => {
                BeginContext(858, 4, true);
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
#line 40 "C:\Users\Fabian\OneDrive\Documents\GitHub\Tarea4Topicos\Tarea4Topicos\Tarea4Topicos\Views\Parqueos\Details.cshtml"
                           WriteLiteral(Model.ParqueoId);

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
            BeginContext(866, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(874, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac9cb628929a465a821f72c659de4ea9", async() => {
                BeginContext(896, 12, true);
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
            BeginContext(912, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tarea4Topicos.Models.Parqueo> Html { get; private set; }
    }
}
#pragma warning restore 1591
