using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExampleBlog.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ExampleBlog.Repo;
namespace ExampleBlog.Controllers
{
    public class BlogController : Controller
    {
        private BlogRepo blogrepo;
        public BlogController() //ctor Tab Tab (this will create the default constructor)
        {
            blogrepo = new BlogRepo();
        }

        public ActionResult Index()
        {
            return View(blogrepo.GetAllBlog());
        }


        public ActionResult Details (int id)
        {
            return View(blogrepo.GetBlogById(id));
        }
    }
}