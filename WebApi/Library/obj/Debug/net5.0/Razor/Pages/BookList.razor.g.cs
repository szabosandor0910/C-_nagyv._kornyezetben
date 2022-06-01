#pragma checksum "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c1b106cd39af3684a2623fa602ff63a342d577f"
// <auto-generated/>
#pragma warning disable 1591
namespace Library.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\_Imports.razor"
using Library.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class BookList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Könyvek listája</h3>");
#nullable restore
#line 5 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
 if (Books == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "href", 
#nullable restore
#line 11 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
               $"books/Kolcsonzes"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "class", "btn btn-info table-btn");
            __builder.AddMarkupContent(5, "Kölcsönzés");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Könyv neve</th>\n                <th>Bent van-e</th>\n                <th>Kinél van</th>\n                <th>Mikor kölcsönözték</th>\n                <th>Mikorra hozzák vissza</th></tr></thead>\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 23 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
             foreach (var book in Books)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line 26 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
__builder.AddContent(13, book.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 27 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
__builder.AddContent(16, book.Loaned);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 28 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
__builder.AddContent(19, book.WhoLoan);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 29 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
__builder.AddContent(22, book.StartDate.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 30 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
__builder.AddContent(25, book.EndDate.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\BookList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591