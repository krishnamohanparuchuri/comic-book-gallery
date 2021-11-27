
using ComicBookgallery.Data;
using ComicBookgallery.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ComicBookgallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController() 
        {
            _comicBookRepository=new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if(id== null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);           
            return View(comicBook);   
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public string DetailInfo()
        {
            return "Hello from the detail info about the comic books controller!";

        }

    }
}
