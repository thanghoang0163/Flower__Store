using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export_invoice
{
    public interface IExportInvoice
    {
        Task<IEnumerable<INVOICE>> GetINVOICEs();
    }
}
