using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace Library.Pages
{
	public partial class Kliens
	{
        [Inject]
        public HttpClient HttpClient { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }


        public Book[] AllBook { get; set; }


        protected string MyInput { get; set; }
        public static List<Book> OwnBooksList = new List<Book>();
        protected override async Task OnInitializedAsync()
        {
            AllBook = await HttpClient.GetFromJsonAsync<Book[]>("books");
            await base.OnInitializedAsync();
        }

        private void SubmitForm()
        {
            foreach(var book in AllBook)
            {
                if (book.WhoLoan.Equals(MyInput))
                {
                    OwnBooksList.Add(book);
                }
            }
            IEnumerable<Book> Books = OwnBooksList.OrderBy(Book => Book.EndDate);
            OwnBooksList = Books.ToList();
            NavigationManager.NavigateTo("SajatKolcsonzes");
        }

    }
}

