using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Common.Models;
using WebApi_Server_Konyvtar.Repositories;

namespace WebApi_Server_Konyvtar.Controllers
{
    [ApiController]
    [Route("api/book")]
    public  class BookController : Controller
    {
        private long GetNewId(IEnumerable<Book> library)
        {
            long newId = 0;
            foreach (var book in library)
            {
                if (newId < book.Id)
                {
                    newId = book.Id;
                }
            }

            return newId + 1;
        }


        [HttpGet]
        public ActionResult<Book> Get()
        {

            var library = BookRepository.GetLibrary();
            return Ok(library);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var library = BookRepository.GetLibrary();

            var book = library.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                return Ok(library);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Book book)
        {
            var Library = BookRepository.GetLibrary().ToList();

            book.Id = GetNewId(Library);
            Library.Add(book);

            BookRepository.StoreLibrary(Library);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Book book)
        {
            var Library = BookRepository.GetLibrary().ToList();

            var BookToUpdate = Library.FirstOrDefault(p => p.Id == book.Id);
            if (BookToUpdate != null)
            {
                BookToUpdate.Title = book.Title;
                BookToUpdate.Loaned = book.Loaned;
                BookToUpdate.WhoLoan = book.WhoLoan;
                BookToUpdate.StartDate = book.StartDate;
                BookToUpdate.EndDate = book.EndDate;

                BookRepository.StoreLibrary(Library);
                return Ok();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var Library = BookRepository.GetLibrary().ToList();

            var BookToDelete = Library.FirstOrDefault(p => p.Id == id);
            if (BookToDelete != null)
            {
                Library.Remove(BookToDelete);

                BookRepository.StoreLibrary(Library);
                return Ok();
            }

            return NotFound();
        }


    }
}
