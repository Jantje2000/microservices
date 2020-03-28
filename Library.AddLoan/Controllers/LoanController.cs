using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.AddLoan.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Library.AddLoan.Controllers
{
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly LibraryContext _context;
        public LoanController(LibraryContext context)
        {
            this._context = context;
        }

        [HttpPost("api/loan")]
        public IActionResult Post([FromBody] Loan loan)
        {
            this._context.Add(loan);

            this._context.SaveChanges();

            return Ok();
        }
    }
}
