using dimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;

namespace dimple.Controllers
{
    public class CustomerController : Controller
    {
        ObjectCache cache = MemoryCache.Default;
        List<Customer> customers;

        public CustomerController()
        {
            customers = cache["customers"] as List<Customer>;
            if (customers == null)
            {
                customers = new List<Customer>();
                Console.WriteLine(customers.Count);
            }
        }
        public void SaveCache()
        {
            cache["customers"] = customers;
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            customer.Id = Guid.NewGuid().ToString();
            customers.Add(customer);
            SaveCache();
            return RedirectToAction("CustomerList");
        }
        public ActionResult CustomerList()
        {
            return View(customers);
        }

        public ActionResult ViewCustomer(string id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == id);
            if(customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }
        public ActionResult EditCustomer(string id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        [HttpPost]
        public ActionResult EditCustomer(Customer customer, string id)
        {
            Customer customerToEdit = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                customerToEdit.Name = customer.Name;
                customerToEdit.PhoneNumber = customer.PhoneNumber;
                SaveCache();
                return RedirectToAction("CustomerList");
            }
        }

        public ActionResult DeleteCustomer(string id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        [HttpPost]
        [ActionName("DeleteCustomer")]
        public ActionResult ConfirmDeleteCustomer(string id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                customers.Remove(customer);
                return RedirectToAction("CustomerList");
            }
        }
    }
}