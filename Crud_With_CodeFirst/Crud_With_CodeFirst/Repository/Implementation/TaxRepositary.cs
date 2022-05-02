using Crud_With_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_With_CodeFirst.Repository.Implementation
{
    public class TaxRepositary : ITaxRepo
    {
        private readonly TaxDataContext _dbContext;

        public TaxRepositary()
        {
            _dbContext = new TaxDataContext();
        }
        public TaxRepositary(TaxDataContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<Tax> GetTax()
        {
            return _dbContext.Tax.ToList();
        }

        public Tax GetTaxById(int id)
        {
            return _dbContext.Tax.Find(id);
        }

        public void AddTax(Tax tax)
        {
            _dbContext.Tax.Add(tax);
            Save();
        }

        public void UpdateTax(Tax tax)
        {
            _dbContext.Entry(tax).State = EntityState.Modified;
        }

        public void DeleteTax(int id)
        {
            var tax = _dbContext.Tax.Find(id);
            if (tax != null) _dbContext.Tax.Remove(tax);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}