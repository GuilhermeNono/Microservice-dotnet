using MicroserviceTest.Catalog.Controllers.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceTest.Catalog.Controllers;

[Route("api/books")]
public class BookController : ApiController
{
    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks()
    {
        return Ok(new List<Book>()
        {
            new Book()
            {
                Author = "John Doe",
                Category = "Book",
                Name = "Book 1",
                Publisher = "Book Publisher",
                Year = 2020
            },
            new Book()
            {
            Author = "Mary Johnson",
            Category = "Book 2",
            Name = "Book 2",
            Publisher = "Book Publisher 2",
            Year = 2022
        }
        });
    }   
    
    [HttpGet("2")]
    public ActionResult<IEnumerable<Book>> GetBooks2()
    {
        return Ok(new List<Book>()
        {
            new Book()
            {
                Author = "John Doe",
                Category = "Book",
                Name = "Book 1",
                Publisher = "Book Publisher",
                Year = 2020
            },
            new Book()
            {
                Author = "Mary Johnson",
                Category = "Book 2",
                Name = "Book 2",
                Publisher = "Book Publisher 2",
                Year = 2022
            }
        });
    }   
    
}
