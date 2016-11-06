using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Models.Student;
using Models.Subject;

namespace University.Web.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            return View();
        }


        public virtual async Task<Subject> GetSchoolSubjectsById()
        {
            return null;
        }

        public virtual async Task<Subject> SetExamGradeForSchoolSubject()
        {
            return null;
        }

        public virtual async Task<T> SetGradeForStudentActivity()
        {
            return null;
        }

        public virtual async Task<T> SetLaboratoryPresenceLevel(List<Student> students)
        {
            return null;
        }

        public virtual async Task<T> SetPercentOfStudentActivityForFinalAverageGrades(List<Student> students)
        {
            return null;
        }


        public virtual async Task<Subject> ListSchoolSubjectGrades()
        {
            return null;
        }

        // GET: Subject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subject/Create
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

        // GET: Subject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Subject/Edit/5
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

        // GET: Subject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Subject/Delete/5
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
