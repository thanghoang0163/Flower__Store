using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Export_invoice
{
    public class ExportInvoice : IExportInvoice
    {
        private readonly string _connectionString;

        public ExportInvoice(IOptions<AppDbConnection> config)
        {
            _connectionString = config.Value.ConnectionString;
        }

        public async Task<IEnumerable<INVOICE>> GetINVOICEs()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<INVOICE>("select IDINV, CUSTOMER, IDOD, TOTAL, INVOICEDATE from INVOICE", commandType: CommandType.Text);
            }
        }
    }
}
