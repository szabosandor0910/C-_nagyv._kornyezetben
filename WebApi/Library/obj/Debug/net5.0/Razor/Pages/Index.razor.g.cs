#pragma checksum "C:\Users\Szabo\Desktop\C-_nagyv._kornyezetben\WebApi\Library\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c8c606e486c038a2efb37a17a57a03b76b787d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<Library.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Library.Pages.BookList>(4);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591