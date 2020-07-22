using patient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace patient.Data
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public ApplicationContext() : base("name=ApplicationConnectionString")
        {

        }
    }
}