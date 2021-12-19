using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Export_Report
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString;

        public CustomerRepository(IOptions<AppDbConnection> config)
        {
            _connectionString = config.Value.ConnectionString;
        }

        public async Task<IEnumerable<CUSTOMER>> GetCUSTOMERs()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<CUSTOMER>("select IDCUS, NAMECUS, PHONE, PRODUCT, QUANTITY, UNITPRICE from CUSTOMER", commandType: CommandType.Text);
            }
        }
    }
}
