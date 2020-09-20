using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class BooksController : Controller
    {
        List<Books> books = new List<Books>
        {
            new Books{Id=1, Title="Pride and Prejudice", Author="Jane Austen", 
                PublshingDate=new DateTime(13,01,28)},
            new Books{Id=2, Title="The Count of Monte Cristo", Author="Alexandre Dumas (père)",
                PublshingDate=new DateTime(1844,08,28)},
            new Books{Id=3, Title="The Picture of Dorian Gray", Author="Oscar Wilde",
                PublshingDate=new DateTime(1890,04,07)},
            new Books{Id=4, Title="Ulysses ", Author="James Joyce",
                PublshingDate=new DateTime(1922,02,02)},
            new Books{Id=5, Title="Jane Eyre", Author="Charlotte Brontë",
                PublshingDate=new DateTime(1847,10,16)},
            new Books{Id=6, Title="North and South", Author="Elizabeth Gaskell",
                PublshingDate=new DateTime(1854,06,15)}
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookList()
        {
            return View(books);
        }
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBookToList(Books book)
        {
            if (ModelState.IsValid)
            {
                books.Add(book);
                return View("BookList", books);
            }
            return View("AddBook", book);

        }

        public IActionResult EditBook(int id)
        {
            var item = books.Where(a => a.Id == id).FirstOrDefault();
            return View(item);
        }

        [HttpPost]
        public IActionResult EditBookList(Books book)
        {
            foreach (var item in books)
            {
                if (item.Id == book.Id)
                {
                    item.Title = book.Title;
                    item.Author = book.Author;
                    item.PublshingDate = book.PublshingDate;
                }
            }
            return View("BookList", books);
        }

        public IActionResult DeleteBook(int id)
        {
            var book = books.Where(a => a.Id != id).ToList();
            return View("BookList", book);
        }
    }
}
