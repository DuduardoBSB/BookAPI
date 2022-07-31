using Microsoft.AspNetCore.Mvc;
using Models;

namespace BookAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;
    private readonly BookContext _db;

    public BookController(ILogger<BookController> logger, BookContext db)
    {
        _logger = logger;
        _db = db;
    }

    [HttpGet(Name = "GetBooks")]
    public IActionResult Get()
    {
        _logger.LogInformation("GetBooks was called.");

        var books = _db.Books.ToList();

        return Ok(books);
    }

    [HttpPost(Name = "CreateBook")]
    public IActionResult Post([FromBody] Book book)
    {
        _logger.LogInformation("CreateBook was called.");

        _db.Books.Add(book);
        _db.SaveChanges();

        return Ok();
    }

    [HttpDelete(Name = "DeleteBook")]
    public IActionResult Delete([FromQuery] int id)
    {
        _logger.LogInformation("DeleteBook was called.");

        var book = _db.Books.FirstOrDefault(x => x.Id == id);

        if (book != null)
        {
            _db.Books.Remove(book);
            _db.SaveChanges();

            return Ok();
        }

        return NotFound();
    }
}
