using DigitalBookStore.Common;
using DigitalBookStore.CustomEntities;
using DigitalBookStore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalBookStore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly BookStoreDb _bookStoreDb;
        public AccountController(BookStoreDb bookStoreDb)
        {
            _bookStoreDb = bookStoreDb;
        }

        [HttpPost]
        public IActionResult Login(User userModel)  // Account
        {
            var user = _bookStoreDb.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
            if (user == null)
                return BadRequest(new { message = "Username doesn't exist!!" });
            return Ok(user);
        }

        [HttpPost]
        public IActionResult SignUp(User userModel)  // Account
        {
            User user = new User();

            user.UserName = userModel.UserName;
            user.UserFullName = userModel.UserFullName;
            user.IsOwner = userModel.IsOwner;
            user.UserAddress = userModel.UserAddress;
            user.Password = userModel.Password;         // TODO: Password to be encrypted here and at line 21, we again need to decrypt the passwrd

            _bookStoreDb.Users.Add(user);
            _bookStoreDb.SaveChanges();
            return Ok(); 
        }

        [HttpGet]
        public IActionResult GetUser()      // Owners
        {
            var list = _bookStoreDb.Users.ToList();
            if (list == null)
                return BadRequest(new { message = "The list is null!!" });
            return Ok(list);
        }


        [HttpGet]
        public IActionResult GetOwnerList()     // Owner
        {
            var list = _bookStoreDb.Users.Where(x => x.IsOwner == 1).ToList();
            if (list == null)
                return BadRequest(new { message = "No Owner Found!! Make one" });
            return Ok(list);
        }

        [HttpGet]
        public IActionResult GetNonOwnerList()     // Owner
        {
            var list = _bookStoreDb.Users.Where(x => x.IsOwner == 0).ToList();
            if (list == null)
                return BadRequest(new { message = "No Visitor Found!! Make one" });
            return Ok(list);
        }

        // Owner's action
        [HttpGet]
        public IActionResult AddOwner(long Id)      // owner
        {
            var userObj = _bookStoreDb.Users.FirstOrDefault(x => x.UserId == Id);
            userObj.IsOwner = 1;
            _bookStoreDb.Users.Update(userObj);
            _bookStoreDb.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult RemoveOwner(long userId)   // owner
        {
            var userObj = _bookStoreDb.Users.FirstOrDefault(x => x.UserId == userId);
            userObj.IsOwner = 0;
            _bookStoreDb.Users.Update(userObj);
            _bookStoreDb.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult AddToMyBookList(long userId, long bookId)      // visitor
        {
            var userBookObj = new UserBook()
            {
                UserId = userId,
                BookId = bookId
            };
            _bookStoreDb.UserBooks.Add(userBookObj);
            _bookStoreDb.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetMyBookList(long userId)     // visitor
        {
            List<UserBookModel> list;
            try
            {
                list = _bookStoreDb.UserBookModel.
                    FromSqlRaw("[dbo].[spGetMyBookList] @userId",
                    new SqlParameter("@userId", userId)
                ).ToList();
            }
            catch (Exception e)
            {
                list = null;
                Console.WriteLine(e);
            }
            return Ok(list);
        }

        [HttpDelete]
        public IActionResult RemoveBookFromMyList(long userId, long bookId)     //visitor
        {
            var userBook = _bookStoreDb.UserBooks.Where(x => x.UserId == userId && x.BookId == bookId).FirstOrDefault();
            if (userBook == null)
            {
                return BadRequest(new { message = "The list is null!!" });
            }
            else
            {
                _bookStoreDb.UserBooks.Remove(userBook);
                _bookStoreDb.SaveChanges();
                return Ok(new { message = "The book is removed from your list successfully!!" });
            }
        }

        [HttpGet]
        public IActionResult GetBookComments(long bookId)       // visitor
        {
            List<BookCommentModel> list;
            try
            {
                list = _bookStoreDb.BookCommentModel.
                    FromSqlRaw("[dbo].[spGetBookComments] @bookId",
                    new SqlParameter("@bookId", bookId)
                ).ToList();
            }
            catch (Exception e)
            {
                list = null;
                Console.WriteLine(e);
            }
            return Ok(list);
        }

        [HttpGet]
        public IActionResult AddBookComment(long userId, long bookId, string comment)       //visitor
        {
            BookComment obj = new BookComment()
            {
                UserId = userId,
                BookId = bookId,
                Comment = comment
            };

            _bookStoreDb.Add(obj);
            _bookStoreDb.SaveChanges();
            return Ok();
        }
    }
}
