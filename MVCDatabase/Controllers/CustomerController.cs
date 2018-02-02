using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDatabase.Models;

namespace MVCDatabase.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Details(int id)
        {
            CustomerContext customerContext = new CustomerContext();
            Customer customer = customerContext.Customers.Single(Cus => Cus.CustomerId == id);  
            return View(customer);
        } 
        public ActionResult Index()
        {
            CustomerContext customerContext = new CustomerContext();
            List<Customer> customers = customerContext.Customers.ToList();
            return View(customers);
        }
    }
}