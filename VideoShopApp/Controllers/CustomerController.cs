using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoShopApp.Models;

namespace VideoShopApp.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>
           {
                new Customer{Name = "Swathi Thada", Id = 1},
                new Customer{Name = "Prshant Keshireddy" , Id= 2},
                new Customer{Name = "Pruthvi Thada" , Id=3}
            };
        // GET: Customer
        [Route("Customer/List")]
        public ActionResult ListCustomers()
        {
            if (customers.Count == 0)
                return Content("We do not have any customers");
            else 
            return View(customers);
        }
        [Route("Customer/details/{id}")]
        public ActionResult Details(int id)
        {
            //var customerdetails = new Customer { Id = id };

            //return View(customerdetails);
            if (id == 1)
                 return Content("Swathi Thada");
            if (id == 2)
                return Content("Prashant Keshireddy");
            if (id == 3)
                return Content("Pruthvi Thada");
            else
                return HttpNotFound();

        }
    }
}