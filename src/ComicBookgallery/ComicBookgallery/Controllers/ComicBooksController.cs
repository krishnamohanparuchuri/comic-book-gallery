using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ComicBookgallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public string Detail()
        {
            return "Hello from the comic books controller!";
           
        }

        public string DetailInfo()
        {
            return "Hello from the detail info about the comic books controller!";

        }

    }
}
