using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeGitHubWebApp.Models
{
    public class Emp
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string EDesignation { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EDOJ { get; set; }
    }
}
