#pragma checksum "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c91979c33a13398b4e11b00641c4c18ad67aa055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Listado), @"mvc.1.0.view", @"/Views/Producto/Listado.cshtml")]
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
#line 1 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\_ViewImports.cshtml"
using WebAppTDSII_2020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\_ViewImports.cshtml"
using WebAppTDSII_2020.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91979c33a13398b4e11b00641c4c18ad67aa055", @"/Views/Producto/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2e66fdb1d31ffceb55103cdaef6c0447e16f4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Listado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppTDSII_2020.Models.Producto>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<h2>Listado de Productos || ASP.NET CORE MVC </h2>\r\n<br />\r\n<label>Filtrar por nombre</label>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c91979c33a13398b4e11b00641c4c18ad67aa0553435", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-xs-3"">
            <input name=""FiltroByName"" class=""form-control"" placeholder=""Ingresar Nombre""/>
        </div>
        <div class=""col-xs-4"">
            <button class=""btn btn-info"">Buscar <span class=""glyphicon glyphicon-search""></span></button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<table class=""table table-bordered"">
    <!--table-bordered es una tabla con bordes-->
    <thead>
        <tr class=""bg-warning"">
            <th>IdProducto</th>
            <th>Código</th>
            <th>Nombre</th>
            <th>Unidad Medida</th>
            <th>Precio</th>
            <th>Stock</th>
            <th>Fecha Creación</th>
        </tr>

");
#nullable restore
#line 31 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
         foreach (var item in ViewBag.LProducto)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
               Write(item.IdProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
               Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
               Write(item.UnidadMedida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
               Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
               Write(item.FechaRegistro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\JERSON\source\repos\WebAppTDSII-2020\WebAppTDSII-2020\Views\Producto\Listado.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </thead>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppTDSII_2020.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
