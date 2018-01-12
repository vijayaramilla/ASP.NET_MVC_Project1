using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo2.Models
{
    public class EmployeeContext : DbContext
    {
        //create a new property Employees
         public DbSet<Employee> Employees {get; set;}
        //public DbSet<Employee> Employees { get; set; }
    }
}