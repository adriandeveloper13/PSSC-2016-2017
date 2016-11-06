using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Models.Subject;

namespace University.Web.Controllers
{
    public class StudyYearController : Controller
    {
        // GET: StudyYear
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public virtual async Task<Subject> DefineSchoolSubjects()
        {
            return null;
        }

        public virtual async Task<SubjectStudentAssignments> AssignSchoolSubjectToStudent()
        {
            return null;
        }

        // GET: StudyYear/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudyYear/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudyYear/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudyYear/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudyYear/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudyYear/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudyYear/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
