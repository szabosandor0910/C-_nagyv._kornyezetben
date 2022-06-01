 using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Library.Models;

namespace Library.Pages
{
    public partial class BookList
    {
            [Inject]
            public HttpClient HttpClient { get; set;}

            public Book[] Books { get; set; }

            protected override async Task OnInitializedAsync()
            {
            Books = await HttpClient.GetFromJsonAsync<Book[]>("book");
            await base.OnInitializedAsync();
            }
    
    }
}


