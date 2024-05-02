using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {      
        CurdMvcEntities Db = new CurdMvcEntities();
        // GET: Main
        public ActionResult Index()
        {
            var data = Db.StudentInfoes.ToList();
            return View(data);
        }
        public ActionResult Create()
        {        
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentInfo s)
        {
            if(ModelState.IsValid == true)
            {
                Db.StudentInfoes.Add(s);
                int Result = Db.SaveChanges();

                if(Result >  0)
                {
                    TempData["InsertMessage"] = "<script>alert('Information Insert Successfully')</scripy>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InsertMessage"] = "<script>alert('Information Insert Faild')</scripy>";

                }
            }
           
            return View();
        }
        public ActionResult Edit( int Id)
        {
            var Row = Db.StudentInfoes.Where(Info => Info.Id == Id).FirstOrDefault();
            return View(Row);
        }

        [HttpPost]

        public ActionResult Edit(StudentInfo s)
        {
            if (ModelState.IsValid == true)
            {
                Db.Entry(s).State = EntityState.Modified;
                int Result = Db.SaveChanges();

                if (Result > 0)
                {
                    TempData["UpdateMessage"] = "<script>alert('Information Update Successfully')</scripy>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["UpdateMessage"] = "<script>alert('Information Update Faild')</scripy>";

                }
            }

            return View();
        }
        public ActionResult Delete(int Id)
        {
            var DRow = Db.StudentInfoes.Where(Info => Info.Id == Id).FirstOrDefault();
            return View(DRow);
        }

        [HttpPost]
        public ActionResult Delete(StudentInfo s)
        {
            if (ModelState.IsValid == true)
            {
                Db.Entry(s).State = EntityState.Deleted;
                int Result = Db.SaveChanges();

                if (Result > 0)
                {
                    TempData["DeletedMessage"] = "<script>alert('Information Deleted Successfully')</scripy>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["DeletedMessage"] = "<script>alert('Information Deleted Faild')</scripy>";

                }
            }

            return View();
        }
    }
}