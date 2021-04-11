using DrywallProgram.Models;
using DrywallProgram.Services;
using Microsoft.AspNet.Identity;
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

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);
            var model = service.GetNotes();

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
            if (!ModelState.IsValid)
            {

            return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);

            service.CreateNote(model);

            return RedirectToAction("Index");
        }
    }
}