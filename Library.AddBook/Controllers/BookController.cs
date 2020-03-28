using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.AddBook.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Library.AddBook.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : ControllerBase
    {
        private readonly LibraryContext _context;
        public BookController(LibraryContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public Book Post([FromBody] Book book)
        {
            this._context.Add(book);

            this._context.SaveChanges();

            return book;
        }
    }
}
