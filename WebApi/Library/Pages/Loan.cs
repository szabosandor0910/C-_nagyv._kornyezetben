using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Components;

namespace Library.Pages
{
	public partial class Loan
	{
		[Inject]
		public HttpClient HttpClient { get; set; }


		[Parameter]
		public string BookId { get; set; }


		[Inject]
		public NavigationManager NavigationManager { get; set; }

		public Book Book { get; set; }

		protected override async Task OnInitializedAsync()
		{
            Book = await HttpClient.GetFromJsonAsync<Book>($"books/{BookId}");
			await base.OnInitializedAsync();
		}

		private bool Ellenorzes(Book item)
        {
            int whitecount = 0;
            char spacechar = '0';
            if (item.WhoLoan.Equals(""))
            {
                return true;
            }
            for (int i = 0; i < item.WhoLoan.Length; i++)
            {
                if (Char.IsWhiteSpace(item.WhoLoan, i))
                {

                    whitecount++;
                    spacechar = item.WhoLoan[i];
                }
            }
            if (whitecount != 1 || !spacechar.Equals(' '))
            {
                return true;
            }
            if (DateTime.Compare(item.StartDate, item.EndDate) > 0)
            {
                return true;
            }
            return false;
        }

        private async Task SubmitForm()
        {
			Book.Loaned = true;
			if (Ellenorzes(Book))
			{
				Console.WriteLine("Hibás név");
			}else
			{
				await HttpClient.PutAsJsonAsync($"books/{BookId}", Book);
				NavigationManager.NavigateTo("books/Kolcsonzes");
			}
			
        }
	}
}

