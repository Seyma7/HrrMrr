#pragma checksum "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e6392162b7fd465986b0c204a3ad016664fa9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PetAdvert_PetAdvertDetails), @"mvc.1.0.view", @"/Views/PetAdvert/PetAdvertDetails.cshtml")]
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
#line 1 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\_ViewImports.cshtml"
using HrrMrr.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\_ViewImports.cshtml"
using HrrMrr.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e6392162b7fd465986b0c204a3ad016664fa9a", @"/Views/PetAdvert/PetAdvertDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cd817e84608d06fff6ed432f954defe0f10164", @"/Views/_ViewImports.cshtml")]
    public class Views_PetAdvert_PetAdvertDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HrrMrr.Entities.PetAdverts>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
  
    ViewData["Title"] = "Detay";
    Layout = "~/Views/Shared/_LayoutAfterLoginUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-content"">

    <div class=""container h-100"">

        <div class=""card-body box-profile"">
            <ul class=""list-group list-group-unbordered mb-3"">
                <li>
                    <p class=""profile-user-img text-center"">
                        ");
#nullable restore
#line 15 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
                   Write(Model.ImageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("=");
#nullable restore
#line 15 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
                                     Write("~/image/"+ Model.PetAdvertId.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
                         if (Model.ImageFile != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 600, "\"", 622, 1);
#nullable restore
#line 18 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 606, Model.ImageFile, 606, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:250px;align-content:center\" />\r\n");
#nullable restore
#line 19 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n                </li>\r\n\r\n                <li class=\"list-group-item\">\r\n                    <b>Adı</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 870, "\"", 888, 1);
#nullable restore
#line 24 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 877, Model.Name, 877, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 889, "\"", 914, 1);
#nullable restore
#line 24 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 903, Model.Name, 903, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 915, "\"", 931, 1);
#nullable restore
#line 24 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 920, Model.Name, 920, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 932, "\"", 951, 1);
#nullable restore
#line 24 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 940, Model.Name, 940, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>Türü</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 1103, "\"", 1133, 1);
#nullable restore
#line 27 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1110, Model.PetType.TypeName, 1110, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1134, "\"", 1171, 1);
#nullable restore
#line 27 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1148, Model.PetType.TypeName, 1148, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1172, "\"", 1200, 1);
#nullable restore
#line 27 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1177, Model.PetType.TypeName, 1177, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1201, "\"", 1232, 1);
#nullable restore
#line 27 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1209, Model.PetType.TypeName, 1209, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>Cinsiyeti</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 1389, "\"", 1409, 1);
#nullable restore
#line 30 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1396, Model.Gender, 1396, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1410, "\"", 1437, 1);
#nullable restore
#line 30 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1424, Model.Gender, 1424, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1438, "\"", 1456, 1);
#nullable restore
#line 30 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1443, Model.Gender, 1443, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1457, "\"", 1478, 1);
#nullable restore
#line 30 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1465, Model.Gender, 1465, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>Kaç Aylık</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 1635, "\"", 1654, 1);
#nullable restore
#line 33 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1642, Model.Month, 1642, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1655, "\"", 1682, 0);
            WriteLiteral("@");
            WriteLiteral("Model.Month");
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1683, "\"", 1700, 1);
#nullable restore
#line 33 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1688, Model.Month, 1688, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1701, "\"", 1721, 1);
#nullable restore
#line 33 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1709, Model.Month, 1709, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>Kilosu</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 1875, "\"", 1895, 1);
#nullable restore
#line 36 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1882, Model.Weight, 1882, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1896, "\"", 1923, 1);
#nullable restore
#line 36 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1910, Model.Weight, 1910, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1924, "\"", 1942, 1);
#nullable restore
#line 36 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1929, Model.Weight, 1929, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1943, "\"", 1964, 1);
#nullable restore
#line 36 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 1951, Model.Weight, 1951, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>Açıklama</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 2120, "\"", 2145, 1);
#nullable restore
#line 39 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2127, Model.Description, 2127, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2146, "\"", 2178, 1);
#nullable restore
#line 39 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2160, Model.Description, 2160, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2179, "\"", 2202, 1);
#nullable restore
#line 39 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2184, Model.Description, 2184, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2203, "\"", 2229, 1);
#nullable restore
#line 39 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2211, Model.Description, 2211, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>Hikayesi</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 2385, "\"", 2404, 1);
#nullable restore
#line 42 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2392, Model.Story, 2392, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2405, "\"", 2431, 1);
#nullable restore
#line 42 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2419, Model.Story, 2419, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2432, "\"", 2449, 1);
#nullable restore
#line 42 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2437, Model.Story, 2437, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2450, "\"", 2470, 1);
#nullable restore
#line 42 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2458, Model.Story, 2458, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>Lokasyonu</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 2627, "\"", 2649, 1);
#nullable restore
#line 45 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2634, Model.Location, 2634, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2650, "\"", 2679, 1);
#nullable restore
#line 45 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2664, Model.Location, 2664, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2680, "\"", 2700, 1);
#nullable restore
#line 45 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2685, Model.Location, 2685, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2701, "\"", 2724, 1);
#nullable restore
#line 45 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2709, Model.Location, 2709, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>İlan Sahibi</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 2883, "\"", 2906, 1);
#nullable restore
#line 48 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2890, Model.User.Name, 2890, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2907, "\"", 2937, 1);
#nullable restore
#line 48 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2921, Model.User.Name, 2921, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2938, "\"", 2959, 1);
#nullable restore
#line 48 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2943, Model.User.Name, 2943, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2960, "\"", 2984, 1);
#nullable restore
#line 48 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 2968, Model.User.Name, 2968, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <b>İlan Tarihi</b> <a class=\"float-right\"><input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 3143, "\"", 3161, 1);
#nullable restore
#line 51 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 3150, Model.Date, 3150, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 3162, "\"", 3187, 1);
#nullable restore
#line 51 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 3176, Model.Date, 3176, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3188, "\"", 3204, 1);
#nullable restore
#line 51 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 3193, Model.Date, 3193, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3205, "\"", 3224, 1);
#nullable restore
#line 51 "C:\Users\seymagol\Desktop\HrrMrr\HrrMrr.Presentation\Views\PetAdvert\PetAdvertDetails.cshtml"
WriteAttributeValue("", 3213, Model.Date, 3213, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                </li>\r\n            </ul>\r\n            \r\n        </div>\r\n    </div>\r\n    <br /><br /><br />\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HrrMrr.Entities.PetAdverts> Html { get; private set; }
    }
}
#pragma warning restore 1591
