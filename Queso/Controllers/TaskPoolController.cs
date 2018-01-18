using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Queso.Models;

namespace Queso.Controllers
{
    public class TaskPoolController : Controller
        {
        public ActionResult Index()
            {
            List<TaskPool> tasks;

                    using (var db = new QuesoContext())
                    {
                        tasks = db.TaskPool.ToList();
                    }

                return View(tasks);
            }

        //Get: /Taskpool/Edit
        public ActionResult Edit()
        //{
        //    using (var db = new QuesoContext())
        //    {
        //        TaskPool tasks = db.TaskPool.Find(id);
        //        return View(tasks);
        //    }
        // }
            {

            List<Task> tasks;

            using (var db = new QuesoContext())
                {
                tasks = db.Tasks.ToList();
                }

            return View(tasks);
            }
        //Post: /TaskPool/Edit
        [HttpPost]
        public ActionResult Edit(TaskPool tasks)
            {
            using (var db = new QuesoContext())
                {
                if (ModelState.IsValid)
                    {
                    db.Entry(tasks).State = EntityState.Modified;
                    db.SaveChanges();
                    }
                }
            return View(tasks);
            }

        public ActionResult Add()
            {

            List<Task> tasks;

            using (var db = new QuesoContext())
                {
                tasks = db.Tasks.ToList();
                }

            return View(tasks);
            }
        }
}