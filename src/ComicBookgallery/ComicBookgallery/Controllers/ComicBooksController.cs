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
            if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/ComicBooks/DetailInfo");
            }
            return Content("Hello from the comic books controller!");
               
        }

        public string DetailInfo()
        {
            return "Hello from the detail info about the comic books controller!";

        }

    }
}
