#pragma checksum "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1cd43976a13258b4fd8f343787a48ee989dde0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Contact_Index), @"mvc.1.0.view", @"/Views/Admin/Contact/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1cd43976a13258b4fd8f343787a48ee989dde0f", @"/Views/Admin/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table id=""dtBasicExample"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
  <thead>
    <tr>
      <th class=""th-sm"" >#ID
      </th>
      <th class=""th-sm"">Họ tên
      </th>
      <th class=""th-sm"">Email
      </th>
      <th class=""th-sm"">Phone
      </th>
      <th class=""th-sm"">Chủ đề
      </th>
      <th class=""th-sm "">Nội dung
      </th>
      <th class=""th-sm text-center"">Thời gian
      </th>
      <th class=""th-sm text-center"">Trạng thái</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td >");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
     Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
     Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td data-toggle=\"modal\" data-target=\"#basicExampleModal-");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"d-flex justify-content-between show-message\">\r\n        ");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
    Write(@item.Message.Length > 25 ? @item.Message.Substring(0, 25) + "..." : @item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-eye\" aria-hidden=\"true\"></i> \r\n      </td>\r\n      <td class=\"text-center\">");
#nullable restore
#line 38 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
                         Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td class=\"text-center\">\r\n        ");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
    Write(@item.Status == false ? Html.Raw("<span style='width:60px' class='badge badge-warning status-message'>Chưa xem</span>") : @Html.Raw("<span style='width:60px' class='badge badge-success status-message'>Đã xem</span>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1584, "\"", 1615, 2);
            WriteAttributeValue("", 1589, "basicExampleModal-", 1589, 18, true);
#nullable restore
#line 50 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
WriteAttributeValue("", 1607, item.Id, 1607, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
          aria-hidden=""true"">
          <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
              <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">
                 <p>");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                 <p>\r\n                    <span style=\"font-size: 14px\"><span style=\"width:80px; display:inline-block\">Họ tên: </span>");
#nullable restore
#line 58 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                 </p>\r\n                 <p>\r\n                    <span style=\"font-size: 14px\"><span style=\"width:80px; display:inline-block\">Email: </span>");
#nullable restore
#line 61 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
                                                                                                          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                 </p>\r\n                 <p>\r\n                    <span style=\"font-size: 14px\"><span style=\"width:80px; display:inline-block\">Phone: </span>");
#nullable restore
#line 64 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
                                                                                                          Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                 </p>
                </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                  <span aria-hidden=""true"">&times;</span>
                </button>
              </div>
              <div class=""modal-body"">
                ");
#nullable restore
#line 72 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
           Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </div>\r\n              <div class=\"modal-footer\">\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 79 "C:\Users\Admin\Desktop\ProjectSE_Topic8_CarBooking\carbooking_netcore\Views\Admin\Contact\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css\">\r\n    <style>\r\n      .show-message{\r\n        cursor: pointer;\r\n      }\r\n      .show-message:hover{\r\n         color:blue;\r\n      }\r\n    </style>\r\n");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#dtBasicExample').DataTable( 
               {  
                 ""order"": [[ 0, ""desc"" ]]
               },
            );
            $('.dataTables_length').addClass('bs-select');
        });
    </script>
    <script>
     // change status contact while click show content 

      
     
      let showMessages  = document.querySelectorAll('.show-message');
      let statusMessage = document.querySelectorAll('.status-message');
      

        showMessages.forEach(function(item, index){

          item.addEventListener('click', function() {
          let idContact = this.dataset.target.slice(19);
        
          let url = ""/admin/contact/update-status/"" +  idContact;
          


          fetch(url)
                  .then(response => response.json())
                  .then(data => {
                    statusMes");
                WriteLiteral(@"sage[index].className = 'badge badge-success status-message'; 
                    statusMessage[index].innerText = 'Đã xem';
                  })
                  .catch(err => {
                      console.log(err);
                  })
          })
        })

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
