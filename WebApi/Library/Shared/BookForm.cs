using System;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Components;

namespace Library.Shared
{
    public partial class BookForm
    {
        [Parameter]
        public string ButtonTitle { get; set; }

        [Parameter]
        public Book book { get; set; }

        [Parameter]
        public Func<Task> SubmitForm { get; set; }
    }
}