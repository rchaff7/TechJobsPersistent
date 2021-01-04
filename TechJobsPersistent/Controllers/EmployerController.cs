using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel viewModel = new AddEmployerViewModel();
            return View(viewModel);
        }

        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer(viewModel.Name, viewModel.Location);
                context.Employers.Add(newEmployer);
                context.SaveChanges();
                return Redirect("/Employer");
            }

            return View("add", viewModel);
        }

        public IActionResult About(int id)
        {
            return View(context.Employers.Find(id));
        }
    }
}
