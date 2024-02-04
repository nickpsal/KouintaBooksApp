using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.BookRepositories;
using Shared.Models;

namespace KouintaBooksApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepo BookRepo;
        public BookController(IBookRepo bookrepo)
        {
            this.BookRepo = bookrepo;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<KouintaBook>>> GetAllBooksAsync()
        {
            var books = await BookRepo.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet("{BookID}")]
        public async Task<ActionResult<List<KouintaBook>>> GetAllBooksAsync(int BookID)
        {
            var books = await BookRepo.GetBookByID(BookID);
            return Ok(books);
        }

        [HttpPost("new")]
        public async Task<ActionResult<KouintaBook>> AddNewProductAsync(KouintaBook model)
        {
            var book = await BookRepo.AddBookAsync(model);
            return Ok(book);
        }

        [HttpPut("update/{BookID}")]
        public async Task<ActionResult<KouintaBook>> UpdateProductAsync(KouintaBook model)
        {
            var book = await BookRepo.UpdateBookAsync(model);
            return Ok(book);
        }

        [HttpDelete("delete/{BookID}")]
        public async Task<ActionResult<KouintaBook>> DeleteProductAsync(int BookID)
        {
            var book = await BookRepo.DeleteBookAsync(BookID);
            return Ok(book);
        }
    }
}
