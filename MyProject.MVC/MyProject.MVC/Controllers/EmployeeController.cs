using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Data;
using MyProject.MVC.Models;
using MyProject.Model;

namespace MyProject.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Index()
        {
            using (var db = new SimpleDbContext())
            {
                var model = db.Employees.Select(e => new EmployeeViewModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    DOJ = e.DOJ
                }).ToList();

                return View(model);
            }
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeViewModel model)
        {
            using (var db = new SimpleDbContext())
            {
                db.Employees.Add(new Employee
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DOJ =model.DOJ
                });
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ViewResult Edit(int Id)
        {
            using (var db = new SimpleDbContext())
            {
                var model = db.Employees.Where(x => x.Id == Id).Select(e => new EmployeeViewModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    DOJ =e.DOJ
                }).First();

                return View(model);
            }
        }

        [HttpPost]
        public RedirectToRouteResult Edit(EmployeeViewModel model)
        {
            using (var db = new SimpleDbContext())
            {
                var employee = db.Employees.First(x => x.Id == model.Id);
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.DOJ = model.DOJ;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
