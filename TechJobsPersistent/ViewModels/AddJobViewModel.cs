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
        [Required]
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }
        public string[] Checkboxes { get; set; }


        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> emps, List<Skill> skills, string[] checkboxes = null)
        {
            Employers = new List<SelectListItem>();
            Skills = skills;
            Checkboxes = checkboxes;

            foreach(Employer emp in emps)
            {
                Employers.Add(new SelectListItem
                {
                    Value = emp.Id.ToString(),
                    Text = emp.Name
                });
            }
        }
    }
}
