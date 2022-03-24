using EMP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMP.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDbContext dbContext;
        public EmployeeController(EmployeeDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            var list = dbContext.emp_Info.ToList();
            return View(list);
        }
        [HttpPost]
        public IActionResult getAllUsers(Employee employee)
        {
           dbContext.emp_Info.Add(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var list = dbContext.emp_Info.SingleOrDefault(e => e.EmpId == Id);
            if (list != null)
            {
                dbContext.emp_Info.Remove(list);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Details(int id)
        {
            var list = dbContext.emp_Info.SingleOrDefault(e => e.EmpId == id);
            return View(list);
        }

        public IActionResult Edit(int id)
        {
            var list = dbContext.emp_Info.SingleOrDefault(e => e.EmpId == id);
            return View(list);
        }
        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            dbContext.emp_Info.Update(model);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
