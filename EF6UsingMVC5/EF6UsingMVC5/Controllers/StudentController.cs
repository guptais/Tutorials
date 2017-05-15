using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF6UsingMVC5.DAL;
using EF6UsingMVC5.Models;

namespace EF6UsingMVC5.Controllers
{
    public class StudentController : Controller
    {
        GenericUnitOfWork _genericUnitOfWork;

        #region Ctor

        public StudentController()
        {
            _genericUnitOfWork = new GenericUnitOfWork();
        }

        public StudentController(GenericUnitOfWork genericUnitOfWork)
        {
            _genericUnitOfWork = genericUnitOfWork;
        }

        #endregion

        // GET: Students
        public ActionResult Index()
        {
            return View(_genericUnitOfWork.Repository<Student>().Get());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _genericUnitOfWork.Repository<Student>().GetByID(id.Value);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LastName,FirstMidName,EnrollmentDate")] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _genericUnitOfWork.Repository<Student>().Insert(student);
                    _genericUnitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                // Log the error (uncomment dex variable name and add a line here to write a log)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _genericUnitOfWork.Repository<Student>().GetByID(id.Value);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //// POST: Students/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost, ActionName("Edit")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        studentRepository.UpdateStudent(student);
        //        studentRepository.Save();
        //        return RedirectToAction("Index");
        //    }
        //    return View(student);
        //}

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var studentToUpdate = _genericUnitOfWork.Repository<Student>().GetByID(id.Value);
            if (TryUpdateModel(studentToUpdate, "",
               new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
            {
                try
                {
                    _genericUnitOfWork.Save();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(studentToUpdate);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage =
                    "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Student student = _genericUnitOfWork.Repository<Student>().GetByID(id.Value);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _genericUnitOfWork.Repository<Student>().Delete(id);
                _genericUnitOfWork.Save();
            }
            catch (DataException )
            {
                return RedirectToAction("Delete", new {id = id, saveChangesError = false});
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _genericUnitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
