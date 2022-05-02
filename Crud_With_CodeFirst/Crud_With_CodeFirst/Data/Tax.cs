using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Crud_With_CodeFirst.Models
{
    [Table("Tax")]
    public class Tax
    {
        public int TaxId { get; set; }
        public string Name { get; set; }
         public string Description { get; set; }
        public float Percentage { get; set; }

        public string DisplayName { get; set; }
    }
}