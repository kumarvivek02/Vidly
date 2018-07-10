﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


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
        // GET: Customers
        public ActionResult Index()
        {

            //  var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //ToList() forces DB query when this line is executed
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
           
        }

        public ActionResult Random()
        {
            var customer = new Customer() { Name = "John Anderson" };

            return View(customer);
        }

        public ActionResult Details(int? id)
        {

            var customer = _context.Customers.SingleOrDefault(cus => cus.Id == id);
           
                        if (customer == null)
                                return HttpNotFound();
            
                        return View(customer);
        }

       
       
    }
}