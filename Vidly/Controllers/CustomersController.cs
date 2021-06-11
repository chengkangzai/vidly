using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        RandomMovieViewModel _viewModel = new RandomMovieViewModel
        {
            Movie = new Movie() {Name = "LOL"},
            Customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"},
            }
        };

        public ActionResult Index()
        {
            return View(_viewModel);
        }

        public ActionResult Show(int id)
        {
            if (id >= 3)
            {
                return HttpNotFound();
            }

            var customer = _viewModel.Customers[id - 1];
            return View(customer);
        }
    }
}