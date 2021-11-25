using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ComicBookgallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();
               
        }

        public string DetailInfo()
        {
            return "Hello from the detail info about the comic books controller!";

        }

    }
}
