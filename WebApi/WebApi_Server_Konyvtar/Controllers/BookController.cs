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
        


        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {

            var library = BookRepository.GetLibrary();
            return Ok(library);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {

            var book = BookRepository.Getbook(id);
            if (book != null)
            {
                return Ok(book);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Post(Book book)
        {
            BookRepository.Addbook(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Book book, int id)
        {
            var dbbook = BookRepository.Getbook(id);

            if (dbbook != null)
            {
                BookRepository.UpdateBook(book);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var book = BookRepository.Getbook(id);
            if (book != null)
            {

                BookRepository.DeleteBook(book);
                return Ok();
            }

            return NotFound();
        }


    }
}
