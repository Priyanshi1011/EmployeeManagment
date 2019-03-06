using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace EmpManagment.Models
{
    public class EmpmanagmentContext : DbContext
    {
        public EmpmanagmentContext() : base("Empmanagmentcontext")
        { }
        public System.Data.Entity.DbSet<EmpManagment.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<EmpManagment.Models.Employee> Employees { get; set; }
    }
}