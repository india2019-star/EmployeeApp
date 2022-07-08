using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeGitHubWebApp.Models;

namespace EmployeeGitHubWebApp.Data
{
    public class EmployeeGitHubWebAppContext : DbContext
    {
        public EmployeeGitHubWebAppContext (DbContextOptions<EmployeeGitHubWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeGitHubWebApp.Models.Emp> Emp { get; set; }
    }
}
