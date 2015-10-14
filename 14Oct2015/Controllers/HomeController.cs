using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _14Oct2015.Models;
using _14Oct2015.ViewModels;

namespace _14Oct2015.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Retrieve (database?) or fashion some Blog entities/objects
            // No db? So, make in-memory (or POCO) objects instead & populate ViewModel
            BlogViewModel bvm = new BlogViewModel(); // a BlogViewModel object created
            bvm.Blogs = new List<Blog>()
            {
                new Blog() {BlogTitle = "Ode To Code", BlogAuthor = "Scott Allen", Posts = new List<Post>()},
                new Blog() {BlogTitle = "Hanselman Minutes", BlogAuthor = "Scott Hanselman", Posts = new List<Post>()}
            };
            bvm.NumberOfBlogs = bvm.Blogs.Count;
            ViewBag.Title = "Blog List";
            return View(bvm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details()
        {
            BlogViewModel bvm = new BlogViewModel();
            bvm.Blogs = new List<Blog>()
            {
                new Blog() {BlogTitle = "Ode To Code", BlogAuthor = "Scott Allen", Posts = new List<Post>()},
                new Blog() {BlogTitle = "Hanselman Minutes", BlogAuthor = "Scott Hanselman", Posts = new List<Post>()}
            };
            bvm.NumberOfBlogs = bvm.Blogs.Count;
            bvm.Blogs.Where(blg => blg.BlogTitle == id);
            ViewBag.Title = "Details of ";
            return View();
        }
    }
}