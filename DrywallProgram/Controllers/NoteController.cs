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
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (!ModelState.IsValid) return View(model);


              var service = CreateNoteService();

                if (service.CreateNote(model))
               {

                TempData["SaveResult"] = "Your Note was Created.";
                  return RedirectToAction("Index");
                };


            ModelState.AddModelError("", "Note could not be created.");


            return View(model);
        }

        public ActionResultDetails(int id)
        {
            var svc = CreateNoteService();
            var model = svc.GetNoteById(id);

            return Vew(model);
        }

        private NoteService CreateNoteService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);
            return service;
        }
    }


}