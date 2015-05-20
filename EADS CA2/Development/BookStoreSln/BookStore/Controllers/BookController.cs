using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private Library_DBEntities db = new Library_DBEntities();

        //
        // GET: /Book/

        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        //
        // GET: /Book/Details/5

        public ActionResult Details(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //
        // GET: /Book/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Book/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                if(db.Books.Any(x=>x.Book_ID==book.Book_ID)){
                    return RedirectToAction("Error");
                }

                else if (db.Books.Any(x => x.Title == book.Title))
                {
                    return RedirectToAction("Error");
                }
                else
                {
                    db.Books.Add(book);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(book);
        }
        [HttpPost]
        public ActionResult Search(string title)
        {
            var id = db.Books.Where(x => x.Title == title).Select(n => n.Book_ID);

            Book book = db.Books.Find(id.FirstOrDefault());
            if (book == null)
            {
                return RedirectToAction("Error");
            }
            return View(book);
        }
       
        //
        // GET: /Book/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //
        // POST: /Book/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        //
        // GET: /Book/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //
        // POST: /Book/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}