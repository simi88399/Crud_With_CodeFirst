using Crud_With_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_With_CodeFirst.Repository
{
 public   interface ITaxRepo
    {
        IEnumerable<Tax> GetTax();
        Tax GetTaxById(int id);
        void AddTax(Tax tax);
        void UpdateTax(Tax tax);

        void DeleteTax(int id);
        void Save();


    }
}
