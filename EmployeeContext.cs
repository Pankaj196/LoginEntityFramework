using LoginEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginEntityFramework
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=customerDbConnectionString")
        {

        }

        public DbSet<Employee> employee { get; set; }
    }
}