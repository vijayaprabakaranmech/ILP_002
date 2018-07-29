using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ILP_002_Anglar_VI393317_VijayaprabakaranS.Models
{
    public class AspContext : DbContext
    {
        public AspContext()
            : base("DefaultConnection")
        { }

        public DbSet<Supervisor> supervisors { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}