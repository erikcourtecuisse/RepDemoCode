#pragma checksum "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ef6c90c77cdcbb8178688b19dbcf245e004522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Projet.EmploiDuTemps.Pages.EmploiDuTemps.Pages_EmploiDuTemps_Index), @"mvc.1.0.razor-page", @"/Pages/EmploiDuTemps/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmploiDuTemps/Index.cshtml", typeof(Projet.EmploiDuTemps.Pages.EmploiDuTemps.Pages_EmploiDuTemps_Index), null)]
namespace Projet.EmploiDuTemps.Pages.EmploiDuTemps
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\_ViewImports.cshtml"
using Projet.EmploiDuTemps;

#line default
#line hidden
#line 3 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\_ViewImports.cshtml"
using Projet.EmploiDuTemps.Data;

#line default
#line hidden
#line 3 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#line 4 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
using Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ef6c90c77cdcbb8178688b19dbcf245e004522", @"/Pages/EmploiDuTemps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1d462c5dc8d6a95d32f690f437c92255cf58c2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmploiDuTemps_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "prev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "today", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "next", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
  
    ViewData["Title"] = "Emploi du Temps";

#line default
#line hidden
            BeginContext(170, 837, true);
            WriteLiteral(@"
<style type=""text/css"">
    caption  {
        margin: auto;
        font-family: Arial, Times, ""Times New Roman"", serif;
        font-weight: bold;
        font-size: 1.2em;
        color: #009900;
        margin-bottom: 20px;
    }

    table {
        margin: auto;
        border: 4px outset black;
        border-collapse: collapse;
        display: inline-block;
        vertical-align: top;
    }

    th {
        background-color: #006600;
        color: white;
        font-size: 1.1em;
        font-family: Arial, ""Arial Black"", Times, ""Times New Roman"", serif;
        border: 1px solid red;
    }

    td {
        border: 1px solid black;
        padding: 5px;
    }

    .tdHeader {
        text-align: center;
    }
</style>

<h2>Emploi du Temps</h2>

<p>
    Semaine N° :
</p>
");
            EndContext();
            BeginContext(1007, 622, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "036ece9943c048b1a57cd5933286b8a8", async() => {
                BeginContext(1027, 40, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(1067, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f367411795d54fd39625584cb0051773", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 52 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumeroSemaine);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 52 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                                     WriteLiteral(ViewBag.Semaine);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1160, 75, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\" style=\"margin-top:5px\">\r\n        ");
                EndContext();
                BeginContext(1235, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae4859ea1ab4411caeeaa5a2bfddfd5d", async() => {
                    BeginContext(1267, 26, true);
                    WriteLiteral("Afficher l\'emploi du temps");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1302, 35, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n\r\n        ");
                EndContext();
                BeginContext(1337, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "000e2c3a2135448eb60abba3a9ddd999", async() => {
                    BeginContext(1407, 1, true);
                    WriteLiteral("<");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-date", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 59 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                            WriteLiteral(Model.NumeroSemaine);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1417, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1427, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c25496676764eb4adf5d5f4886b331e", async() => {
                    BeginContext(1498, 11, true);
                    WriteLiteral("Aujourd\'hui");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-date", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 60 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                             WriteLiteral(Model.NumeroSemaine);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1518, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1528, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a6ee3adb584c58a9b9d72b3af83d09", async() => {
                    BeginContext(1598, 1, true);
                    WriteLiteral(">");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-date", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 61 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                            WriteLiteral(Model.NumeroSemaine);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1608, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1629, 19, true);
            WriteLiteral("\r\n\r\n        <div>\r\n");
            EndContext();
#line 66 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
             foreach (DateTime jour in ViewBag.JoursSemaine)
            {

#line default
#line hidden
            BeginContext(1725, 169, true);
            WriteLiteral("                <table>\r\n                    <tr style=\"background: #8b8080; color: white;\">\r\n                        <td class=\"tdHeader\">\r\n                            ");
            EndContext();
            BeginContext(1895, 57, false);
#line 71 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                       Write(DateTimeFormatInfo.CurrentInfo.GetDayName(jour.DayOfWeek));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 37, true);
            WriteLiteral(" <br />\r\n                            ");
            EndContext();
            BeginContext(1990, 18, false);
#line 72 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                       Write(jour.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 75 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                     foreach (Seance seance in ViewBag.Seances)
                    {
                        

#line default
#line hidden
#line 77 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                         if (seance.Jour.ToString("d") == jour.ToString("d"))
                        {
                            String heureDebut = TimeSpan.FromHours(seance.HeureDebut).ToString("hh':'mm");
                            String heureDeFin = TimeSpan.FromHours(seance.HeureDebut + seance.Duree).ToString("hh':'mm");

#line default
#line hidden
            BeginContext(2493, 191, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <ul>\r\n                                        <li><strong>Heure de début :</strong>");
            EndContext();
            BeginContext(2685, 10, false);
#line 84 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                                        Write(heureDebut);

#line default
#line hidden
            EndContext();
            BeginContext(2695, 77, true);
            WriteLiteral(" </li>\r\n                                        <li><strong>Durée :</strong> ");
            EndContext();
            BeginContext(2773, 12, false);
#line 85 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                                Write(seance.Duree);

#line default
#line hidden
            EndContext();
            BeginContext(2785, 90, true);
            WriteLiteral(" heures</li>\r\n                                        <li><strong>Heure de fin :</strong> ");
            EndContext();
            BeginContext(2876, 10, false);
#line 86 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                                       Write(heureDeFin);

#line default
#line hidden
            EndContext();
            BeginContext(2886, 75, true);
            WriteLiteral("</li>\r\n                                        <li><strong>Type :</strong> ");
            EndContext();
            BeginContext(2962, 26, false);
#line 87 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                               Write(seance.TypeSeance.Intitule);

#line default
#line hidden
            EndContext();
            BeginContext(2988, 77, true);
            WriteLiteral("</li>\r\n                                        <li><strong>Groupe :</strong> ");
            EndContext();
            BeginContext(3066, 36, false);
#line 88 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                                 Write(seance.Enseignement.Groupe.NomGroupe);

#line default
#line hidden
            EndContext();
            BeginContext(3102, 73, true);
            WriteLiteral("</li>\r\n                                        <li><strong>UE :</strong> ");
            EndContext();
            BeginContext(3176, 33, false);
#line 89 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                             Write(seance.Enseignement.UE.NomComplet);

#line default
#line hidden
            EndContext();
            BeginContext(3209, 81, true);
            WriteLiteral("</li>\r\n                                        <li><strong>Enseignant :</strong> ");
            EndContext();
            BeginContext(3291, 28, false);
#line 90 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                                     Write(seance.Enseignant.NomComplet);

#line default
#line hidden
            EndContext();
            BeginContext(3319, 76, true);
            WriteLiteral("</li>\r\n                                        <li><strong>Salle :</strong> ");
            EndContext();
            BeginContext(3396, 21, false);
#line 91 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                                                                Write(seance.Salle.NomSalle);

#line default
#line hidden
            EndContext();
            BeginContext(3417, 124, true);
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 95 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                        }

#line default
#line hidden
#line 95 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(3591, 26, true);
            WriteLiteral("                </table>\r\n");
            EndContext();
#line 98 "F:\Fac S2 M1\Projet_v1.0\Projet\Projet.EmploiDuTemps\Pages\EmploiDuTemps\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3632, 20, true);
            WriteLiteral("        </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet.EmploiDuTemps.Pages.Seances.EmploiDuTemps.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet.EmploiDuTemps.Pages.Seances.EmploiDuTemps.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet.EmploiDuTemps.Pages.Seances.EmploiDuTemps.IndexModel>)PageContext?.ViewData;
        public Projet.EmploiDuTemps.Pages.Seances.EmploiDuTemps.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
