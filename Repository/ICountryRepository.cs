using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(int id);
    }
}
