using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.viewModel;
using vidly.Models;
using System.Data.Entity;

namespace vidly.Controllers
{
    public class customerController : Controller
    {
        private ApplicationDbContext _context;
        public customerController()
        {
            _context =new  ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: customer
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).ToList();
            
            
            return View(customer);
        }
        [HttpGet]
        public ActionResult Details(int  id)
        {
            var customer = _context.Customers.Include(c =>c.MembershipType).SingleOrDefault(c=>c.id==id);
            if (customer == null)
            {
                return HttpNotFound();
            }
             return View (customer);

        }
    }
}