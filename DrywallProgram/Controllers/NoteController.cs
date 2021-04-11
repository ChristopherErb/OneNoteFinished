using DrywallProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrywallProgram.Controllers
{
    public class NoteController : Controller
    {
        // GET: Note
        [Authorize]
        public ActionResult Index()
        {
            var model = new NoteListItem[0];
            return View(model);
        }


        //Add Method Here
        //GET

        public ActionResult Create()
        {

            return View();
             
        }

        [HttpPost]
        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}