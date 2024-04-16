using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Magic_Moonlight_Cinema.Models;

namespace Magic_Moonlight_Cinema.Controllers
{
    [Authorize]
    public class CinemasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cinemas
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Cinemas.ToList());
        }

        // GET: Cinemas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinema cinema = db.Cinemas.Find(id);
            if (cinema == null)
            {
                return HttpNotFound();
            }
            return View(cinema);
        }

        // GET: Cinemas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cinemas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Location,Capacity,ImageURL")] Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                db.Cinemas.Add(cinema);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cinema);
        }

        // GET: Cinemas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinema cinema = db.Cinemas.Find(id);
            if (cinema == null)
            {
                return HttpNotFound();
            }
            return View(cinema);
        }

        // POST: Cinemas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Location,Capacity,ImageURL")] Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinema).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cinema);
        }

        // GET: Cinemas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinema cinema = db.Cinemas.Find(id);
            if (cinema == null)
            {
                return HttpNotFound();
            }
            return View(cinema);
        }

        // POST: Cinemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cinema cinema = db.Cinemas.Find(id);
            db.Cinemas.Remove(cinema);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult InsertNewMovie(int id)
        {
            MovieCinema model = new MovieCinema();
            model.CinemaId = id;
            model.cinema = db.Cinemas.Find(id);
            model.movies = db.Movies.ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult InsertMovieCinema(MovieCinema model)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertNewMovie", model);
            }
            var cinema = db.Cinemas.Find(model.CinemaId);
            var movie = db.Movies.Find(model.MovieId);

            cinema.movies.Add(movie);
            db.SaveChanges();

            return View("Details", cinema);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
