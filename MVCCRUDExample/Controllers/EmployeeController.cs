using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;



namespace MVCCRUDExample.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);
        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
            
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post( )
        {
            Employee employee = new Employee();
            UpdateModel(employee);
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.AddEmployee(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee= employeeBusinessLayer.Employees.Single(emp => emp.Id == id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        { 
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.SaveEmployee(employee);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}