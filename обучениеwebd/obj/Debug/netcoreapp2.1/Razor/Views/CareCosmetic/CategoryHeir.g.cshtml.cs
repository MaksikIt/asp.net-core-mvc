#pragma checksum "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\CareCosmetic\CategoryHeir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba53b0755116a80e22db6439e95f7af81feba9de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CareCosmetic_CategoryHeir), @"mvc.1.0.view", @"/Views/CareCosmetic/CategoryHeir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CareCosmetic/CategoryHeir.cshtml", typeof(AspNetCore.Views_CareCosmetic_CategoryHeir))]
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
#line 1 "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\_ViewImports.cshtml"
using обучениеwebd;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba53b0755116a80e22db6439e95f7af81feba9de", @"/Views/CareCosmetic/CategoryHeir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e7f6bc1e43b9ce57f04ca860627f8b1617cc25", @"/Views/_ViewImports.cshtml")]
    public class Views_CareCosmetic_CategoryHeir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<div>\r\n    <h2 class=\"h2_margin\">");
            EndContext();
            BeginContext(34, 35, false);
#line 2 "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\CareCosmetic\CategoryHeir.cshtml"
                     Write(Model.AllCategories[0].CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(69, 163, true);
            WriteLiteral("</h2>\r\n\r\n    <div class=\"album py-5 bg-body-tertiary\">\r\n        <div class=\"container\">\r\n            <div class=\"row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3\">\r\n");
            EndContext();
#line 7 "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\CareCosmetic\CategoryHeir.cshtml"
                  foreach (var cosmetic in Model.AllCareCosmetics)
                    {
                        if (cosmetic.Category == Model.AllCategories[0].CategoryName)
                        {

#line default
#line hidden
            BeginContext(437, 177, true);
            WriteLiteral("                        <div class=\"col\">\r\n                            <div class=\"card shadow-sm\">\r\n                                <img class=\"bd-placeholder-img card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 614, "\"", 633, 1);
#line 13 "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\CareCosmetic\CategoryHeir.cshtml"
WriteAttributeValue("", 620, cosmetic.Img, 620, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(634, 344, true);
            WriteLiteral(@" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Заполнитель: миниатюра"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" _mstaria-label=""4468347"" _mstHash=""18"" style=""direction: ltr; text-align: left;"">
                                <div class=""card-body"">
                                    <h3>");
            EndContext();
            BeginContext(979, 21, false);
#line 15 "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\CareCosmetic\CategoryHeir.cshtml"
                                   Write(cosmetic.CosmeticName);

#line default
#line hidden
            EndContext();
            BeginContext(1000, 1046, true);
            WriteLiteral(@"</h3>
                                    <p class=""card-text"" _msttexthash=""125699210"" _msthash=""21"" style=""direction: ltr; text-align: left;"">Это более широкая карточка с вспомогательным текстом ниже в качестве естественного введения в дополнительный контент. Этот контент немного длиннее.</p>
                                    <div class=""d-flex justify-content-between align-items-center"">
                                        <div class=""btn-group"">
                                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"" _msttexthash=""799227"" _msthash=""22"" style=""direction: ltr;"">Подробнее</button>
                                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"" _msttexthash=""1402778"" _msthash=""23"" style=""direction: ltr;"">модуляция</button>
                                        </div>
                                        <small class=""text-body-secondary"" _msttexthash=""711386"" _msthash=""24"" style=""direction: ltr; tex");
            WriteLiteral("t-align: left;\">Цена: ");
            EndContext();
            BeginContext(2047, 14, false);
#line 22 "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\CareCosmetic\CategoryHeir.cshtml"
                                                                                                                                                          Write(cosmetic.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2061, 162, true);
            WriteLiteral("</small>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 27 "C:\Users\maksi\source\repos\обучениеwebd\обучениеwebd\Views\CareCosmetic\CategoryHeir.cshtml"
       
                        }
                    }
                 

#line default
#line hidden
            BeginContext(2302, 57, true);
            WriteLiteral("             </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
