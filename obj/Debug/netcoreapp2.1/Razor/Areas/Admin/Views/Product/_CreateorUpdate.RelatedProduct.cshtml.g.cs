#pragma checksum "E:\projects\web3\Shop\Areas\Admin\Views\Product\_CreateorUpdate.RelatedProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e10c7dbd44600240d70413db98cdb932d683615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__CreateorUpdate_RelatedProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_CreateorUpdate.RelatedProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/_CreateorUpdate.RelatedProduct.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product__CreateorUpdate_RelatedProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e10c7dbd44600240d70413db98cdb932d683615", @"/Areas/Admin/Views/Product/_CreateorUpdate.RelatedProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a137d6b7e34ce471addfa227493297504d67088", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__CreateorUpdate_RelatedProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 245, true);
            WriteLiteral("\r\n\r\n<br />\r\n<button class=\"btn btn-dark mb-3\" type=\"button\" onclick=\"ShowSelectionProduct()\">انتخاب محصول</button>\r\n\r\n<div id=\"RelatedProducts\" class=\"list-group mt-3\">\r\n  \r\n</div>\r\n\r\n<div id=\"DivProductListSelection\" style=\"display:none\">\r\n    ");
            EndContext();
            BeginContext(274, 42, false);
#line 12 "E:\projects\web3\Shop\Areas\Admin\Views\Product\_CreateorUpdate.RelatedProduct.cshtml"
Write(await Component.InvokeAsync("ProductList"));

#line default
#line hidden
            EndContext();
            BeginContext(316, 375, true);
            WriteLiteral(@"

</div>
<script>
    var _managerList = new ProductListManager();
    var IDS = [];
    function ShowSelectionProduct() {

           OPenModal(DivProductListSelection, { title: 'محصول را از لیست زیر انتخاب نمایید', applyEvent: Register, eventLoad: LoadProduct });

    }

    function Register() {

        AJX.post(""/Admin/Product/SaveRelatedProducts"", { ID:");
            EndContext();
            BeginContext(692, 8, false);
#line 26 "E:\projects\web3\Shop\Areas\Admin\Views\Product\_CreateorUpdate.RelatedProduct.cshtml"
                                                       Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(700, 353, true);
            WriteLiteral(@",IDS: _managerList.getSeletedProductsId().join("";"") }, function () {
            GetRealtedProduct();
            alert(""عملیات انجام شد"");

        });
    }

    function LoadProduct() {
        _managerList.setSeletedProductsId(IDS);
    }


    function GetRealtedProduct() {

        AJX.get(""/Admin/Product/GetRelatedProducts"", { ID:");
            EndContext();
            BeginContext(1054, 8, false);
#line 40 "E:\projects\web3\Shop\Areas\Admin\Views\Product\_CreateorUpdate.RelatedProduct.cshtml"
                                                     Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 454, true);
            WriteLiteral(@"}, function (_list) { 

            var str = """";
            IDS = [];
            for (var i in _list) {
                IDS.push(_list[i].id.toString());
                str += '<a href=""#"" class=""list-group-item list-group-item-action"" data-id=""' + _list[i].id+'"">' + _list[i].name + '</a>';
            }

            document.getElementById(""RelatedProducts"").innerHTML = str;
        });

    }


    GetRealtedProduct();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
