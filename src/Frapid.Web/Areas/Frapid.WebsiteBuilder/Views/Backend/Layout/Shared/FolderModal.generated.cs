﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Frapid.Web;
    
    #line 1 "..\..\Views\Backend\Layout\Shared\FolderModal.cshtml"
    using Frapid.WebsiteBuilder;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Backend/Layout/Shared/FolderModal.cshtml")]
    public partial class _Views_Backend_Layout_Shared_FolderModal_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Backend_Layout_Shared_FolderModal_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"ui small modal\"");

WriteLiteral(" id=\"FolderModal\"");

WriteLiteral(">\r\n    <i");

WriteLiteral(" class=\"close icon\"");

WriteLiteral("></i>\r\n    <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 5 "..\..\Views\Backend\Layout\Shared\FolderModal.cshtml"
   Write(Resources.CreateANewFolder);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui padded form\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <label>");

            
            #line 10 "..\..\Views\Backend\Layout\Shared\FolderModal.cshtml"
                  Write(Resources.Location);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"ui container label\"");

WriteLiteral(" data-container=\"\"");

WriteLiteral("></div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <label>");

            
            #line 14 "..\..\Views\Backend\Layout\Shared\FolderModal.cshtml"
                  Write(Resources.FolderName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n            </div>\r\n            <button");

WriteLiteral(" class=\"ui button\"");

WriteLiteral(" onclick=\"createFolder(this);\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Backend\Layout\Shared\FolderModal.cshtml"
                                                               Write(Resources.Create);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
