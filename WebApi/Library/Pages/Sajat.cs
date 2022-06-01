using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Library.Models;
using System.Collections.Generic;

namespace Library.Pages
{
	public partial class Sajat
	{
        [Inject]
        public HttpClient HttpClient { get; set; }

        public Book[] Books { get; set; }
        
        private List<Book> OwnBooks = new List<Book>(Kliens.OwnBooksList);
        protected override async Task OnInitializedAsync()
        {
            Books = await HttpClient.GetFromJsonAsync<Book[]>("book");
            await base.OnInitializedAsync();
        }

    }
}

