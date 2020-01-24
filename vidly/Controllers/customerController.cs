using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.viewModel;
using vidly.Models;

namespace vidly.Controllers
{
    public class customerController : Controller
    {
        // GET: customer
        public ActionResult Index()
        {
            var customer = new List<Customers>
            {
                new Customers {name="c1" },
                new Customers {name="c2" },
            };
            var viewModel = new viewListCustomers
            {
                listCustomers = customer
            };
            return View(viewModel);
        }
        [HttpGet]
        public ActionResult Details(String name)
        {
            ViewData["name"] = name;
            return View();

        }
    }
}