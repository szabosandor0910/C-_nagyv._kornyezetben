using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Common.Models;

namespace WebApi_Server_Konyvtar.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get() {
            return Ok(new[] { new Book { Id = 1, Title = "tesztcím", Loaned = true, StartDate = DateTime.Now, EndDate = DateTime.Now, WhoLoan = "Adrfs" } });
        }
    }
}
