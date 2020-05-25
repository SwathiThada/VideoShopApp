using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoShopApp.Models;
using VideoShopApp.ViewModels;

namespace VideoShopApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/List
        [Route ("Movies/List")]
        public ActionResult ListMovies()
        {
            var movie = new List<Movie>
                {
                    new Movie { Name = "Thappad" , Id = 101},
                    new Movie { Name = "Guru" , Id = 102}
            };
            //var customers = new List<Customer>
            //{
            //    new Customer {Name = "Swathi"},
            //    new Customer {Name = "Prashant"}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers
            //};
             
            return View(movie);
            //return PartialView(movie);
            //return Content("Hello World!!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
            
        }
        //public ActionResult Edit(int Id)
        //{
        //    return Content("id = " + Id);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex ={0} & sortBy={1}",pageIndex, sortBy));

        //}
        [Route("movies/released")]
        public ActionResult ByReleaseDate()
        {
            return Content("released in 2020");
        }
    }
}