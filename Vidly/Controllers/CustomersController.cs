using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;  
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;  

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
       
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext(); 
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); 
        }
          
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c=> c.MembershipType)  .ToList();   
            return View(customers);
        }
        // GET: Customers
        //[Route("Customers/Detail/")]
        public ActionResult Detail(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer==null)
            {
                return HttpNotFound(); 

            }
            return View(customer);
        }
        //private IEnumerable<Customers> GetCustomers()
        //{
        //    return new List<Customers>
        //    {
        //        new Customers { Id=1,Name="John smith"},
        //        new Customers { Id=2,Name="Mary Willaims"}

        //    };
        //}

        public ActionResult CustomerForm()
        {
            var membershiptype = _context.MembershipTypes.ToList();

            var viewmodel = new CustomerFormViewModel()
            {
                Membershiptypes=membershiptype 

            };
            return View("CustomerForm",viewmodel);
        }

        [HttpPost]
        public ActionResult Save(Customers  Customer)
        {
            if (Customer.Id == 0)
            {
                _context.Customers.Add(Customer);
            }
            else
            {
                var CustomerInDB = _context.Customers.Single(c => c.Id == Customer.Id);

                //TryUpdateModel(CustomerInDB);

                CustomerInDB.Name = Customer.Name;
                CustomerInDB.BirthDate = Customer.BirthDate;
                CustomerInDB.IsSubscribedToNewsLetter = Customer.IsSubscribedToNewsLetter;
                CustomerInDB.MembershiptypeId = Customer.MembershiptypeId;
            }
           
            _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();


            var CustomerViewModel = new CustomerFormViewModel()
            {

                Customer = customer,
                Membershiptypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", CustomerViewModel);
        }

    }
}