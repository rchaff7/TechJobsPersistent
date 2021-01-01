using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        [Required]
        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> emps)
        {
            Employers = new List<SelectListItem>();

            foreach(Employer emp in emps)
            {
                Employers.Add(new SelectListItem()
                {
                    Value = emp.Id.ToString(),
                    Text = emp.Name
                });
            }
        }
    }
}
