using DigitalBookStore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalBookStore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStoreDb _bookStoreDb;
        public BooksController(BookStoreDb bookStoreDb)
        {
            _bookStoreDb = bookStoreDb;
        }

        [HttpGet]
        public IActionResult BookList()
        {
            var list = _bookStoreDb.Books.ToList();
            if (list == null)
                return BadRequest(new { message = "The list is null!!" });
            return Ok(list);
        }

        [HttpGet]
        public IActionResult GetBookById(long Id)
        {
            var result = _bookStoreDb.Books.FirstOrDefault(e => e.BookId == Id);
            if (result == null)
            {
                return NotFound(new { message = "Ticket with entered Id is not available!!" });
            }
            else
            {
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookStoreDb.Books.Add(book);
            _bookStoreDb.SaveChanges();
            return Ok("Book Added!!");
        }

        [HttpPost]
        public int UpdateBook(Book book)
        {
            var bookObj = _bookStoreDb.Books.FirstOrDefault(x => x.BookId == book.BookId);
            bookObj.BookName = book.BookName;
            bookObj.BookAuthor = book.BookAuthor;
            bookObj.BookSummary = book.BookSummary;
            bookObj.BookImage = book.BookImage;
            bookObj.BookPrice = book.BookPrice;

            _bookStoreDb.Books.Update(bookObj);
            return _bookStoreDb.SaveChanges();
        }

        [HttpDelete]
        public IActionResult DeleteBook(int Id)
        {
            var Obj = _bookStoreDb.Books.FirstOrDefault(x => x.BookId == Id);
            try
            {
                if (Obj == null)
                {
                    return BadRequest(new { message = "Couldn't find the user you want to delete!!" });
                }
                else
                {
                    _bookStoreDb.Books.Remove(Obj);
                    _bookStoreDb.SaveChanges();
                    return Ok(new { message = "The Book is Deleted successfully!!" });
                }
            }
            catch(Exception e)
            {
                return BadRequest(new { message = "Bad Request" });
            }
        }
    }
}
