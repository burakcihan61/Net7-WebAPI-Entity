using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net7_WebAPI_Entity.Services.BookService;

namespace Net7_WebAPI_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService bookService, ILogger<BookController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        // GET: api/Book
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var result = await _bookService.GetAllBooks();
            _logger.LogInformation("GetAllBooks called successfully");
            return Ok(result);
        }
    }
}
