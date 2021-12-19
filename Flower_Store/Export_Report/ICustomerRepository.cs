using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export_Report
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CUSTOMER>> GetCUSTOMERs();
    }
}
