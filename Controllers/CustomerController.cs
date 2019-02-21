using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;
using Videly.ViewModel;

namespace Videly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult CustomerDetails(int id)
        {


            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);

            /*  var customer = new List<Customer>
              {

                  new Customer {Id = 1, Name = "John Smith" },
                  new Customer {Id = 2,Name = "Mary Willams" }
              };

              //Videly.ViewModel.RandomViewModel
              Customer cust = customer.Single(c => c.Id == id);
              if(cust== null)
              {
                  return Content("We dont have any Customers");
              }
              return View(cust);*/
        }

        public ActionResult ListOfCustomers()
        {
            var customer = _context.Customers.ToList();

            /* var customer = new List<Customer>
             {

                 new Customer {Id = 1, Name = "John Smith" },
                 new Customer {Id = 2,Name = "Mary Willams" }
             };
             */
             var viewModel = new RandomViewModel { Customer = customer};
             return View(viewModel);
           // return View(customer);
        }
    }
}