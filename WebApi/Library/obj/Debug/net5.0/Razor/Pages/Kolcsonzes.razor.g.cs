#pragma checksum "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7889a0f4df0edd679b8458c90d756e9e955ba0ac"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/Kolcsonzes")]
    public partial class Kolcsonzes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor"
 if (Books == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 6 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Könyv neve</th></tr></thead>\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 17 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor"
             foreach (var book in Books)
            {
                if (@book.Loaned == false)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 22 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor"
__builder.AddContent(7, book.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n                        ");
            __builder.OpenElement(9, "td");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", 
#nullable restore
#line 24 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor"
                                       $"book/{book.Id}/loan"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "btn btn-primary table-btn");
            __builder.AddContent(13, "Kolcsonzes");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor"
                }

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Kolcsonzes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591