using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Service;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBookListAsync()
        {
            var res = await _bookService.GetBookListAsync();
            return Ok(res);
        }
    }
}
