using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_With_CodeFirst.Models
{
    public partial class TaxDataContext : DbContext
    {
        public TaxDataContext()
             : base("name=Taxdbcon")
        {

        }
        public DbSet<Tax> Tax { get; set; }
    }
}