using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using W7_Assignment.Models;

namespace W7_Assignment.Controllers
{
    public class UserInforsController : Controller
    {
        private FIT5032_Models db = new FIT5032_Models();

        // GET: UserInfors
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var userInfos = db.UserInfor.Where(s => s.UserId == userId).ToList();
            return View(userInfos);
        }

        // GET: UserInfors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfor userInfor = db.UserInfor.Find(id);
            if (userInfor == null)
            {
                return HttpNotFound();
            }
            return View(userInfor);
        }

        // GET: UserInfors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserInfors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Phone")] UserInfor userInfor)
        { 
            userInfor.UserId = User.Identity.GetUserId();

            ModelState.Clear();
            TryValidateModel(userInfor);

            if (ModelState.IsValid)
            {
                db.UserInfor.Add(userInfor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                
            return View(userInfor);
        }

        // GET: UserInfors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfor userInfor = db.UserInfor.Find(id);
            if (userInfor == null)
            {
                return HttpNotFound();
            }
            return View(userInfor);
        }

        // POST: UserInfors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Phone,UserId")] UserInfor userInfor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userInfor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userInfor);
        }

        // GET: UserInfors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfor userInfor = db.UserInfor.Find(id);
            if (userInfor == null)
            {
                return HttpNotFound();
            }
            return View(userInfor);
        }

        // POST: UserInfors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserInfor userInfor = db.UserInfor.Find(id);
            db.UserInfor.Remove(userInfor);
            db.SaveChanges();
            return RedirectToAction("Index");
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
