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
        List<Books> _books = new List<Books>
        {

           new Books{Id = 1, BookName = "1984" , Author ="George Orwell", PublishedYear = new DateTime(1949,06,08)},
           new Books{Id = 2, BookName = "Foundation" , Author ="Isaac Asimov", PublishedYear = new DateTime(1951,06,08)},
           new Books{Id = 3, BookName = "The Sun Also Rises" , Author ="Ernest Hemingway"},
           new Books{Id = 4, BookName = "Вештица" , Author ="Венко Андоновски"},
           new Books{Id = 5, BookName = "Btothers Karamazov" , Author ="Fyodor Dostoyevsky", PublishedYear = new DateTime(1880,11,08)}
        };







        public IActionResult Books()
        {
            return View(_books);
        }

        public IActionResult Delete(int id)
        {
            var books = _books.Where(x => x.Id != id).ToList();

            return View("Books", books);
        }


        public IActionResult Details(int id)
        {
            var book = _books.Where(x => x.Id == id).FirstOrDefault();

            return View(book);
        }

        public IActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Books book)
        {
            _books.Add(book);
            return View("Books", _books);
        }


        public IActionResult EditBook(int id)
        {
            var book = _books.Where(x => x.Id == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Books book)
        {
            foreach (var item in _books.Where(x => x.Id == book.Id))
            {


                item.BookName = book.BookName;
                item.Author = book.Author;
                item.PublishedYear = book.PublishedYear;


            }

            return View("Books", _books);
        }


    }
}