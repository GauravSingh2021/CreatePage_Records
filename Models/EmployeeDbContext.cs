using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMP.Models;

namespace EMP.Models
{
    public class EmployeeDbContext:DbContext
    {
       
            public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

            public DbSet<Employee> emp_Info { get; set; }
        }
}
