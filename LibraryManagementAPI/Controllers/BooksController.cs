using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagementAPI.Data;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET : Get all books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {
            return await _context.Books
            .AsNoTracking()
            .ToListAsync();
        }

        // GET : Get a single book by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books
            .AsNoTracking()
            .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                return NotFound();

            return book;
        }

        // POST : Create a new book
        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (book.YearPublished > DateTime.Now.Year)
                return BadRequest("Year published cannot be in the future.");

            try
            {
                _context.Books.Add(book);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while saving the book.");
            }

            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // PUT : Update an existing book
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != book.Id)
                return BadRequest();

            if (book.YearPublished > DateTime.Now.Year)
                return BadRequest("Year published cannot be in the future.");

            var existingBook = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);

            if (existingBook == null)
                return NotFound();

            // Manual update
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Genre = book.Genre;
            existingBook.YearPublished = book.YearPublished;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE : Delete a book by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}