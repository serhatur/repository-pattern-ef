using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepositoryPatternEntityFrameWork.Models
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context)
              : base(context)
        {

        }
        public Country GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}