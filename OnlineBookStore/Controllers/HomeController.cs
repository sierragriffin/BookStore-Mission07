using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;
using OnlineBookStore.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineBookStore.Controllers
{
    public class HomeController : Controller
    {

        private IBookStoreRepository repo;

        public HomeController(IBookStoreRepository temp)
        {
            repo = temp;
        }

        //private BookstoreContext context { get; set; }

        //public HomeController(BookstoreContext temp) => context = temp;

        // GET: /<controller>/
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;


            var BookListDisplay = new BooksViewModel
            {
                Books = repo.Books
                //.OrderBy(book => book.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum

                }
            };

            return View(BookListDisplay);

            //var bookList = repo.Books
            //    .OrderBy(book => book.Title)
            //    .Skip((pageNum - 1) * pageSize)
            //    .Take(pageSize);

            //return View(bookList);
        }

    }
}

//lambda is a shortcut to say the result of this function is this...
//setting up a repository insulates our app from changes in the data store and
//and can facilitate automated unit testing