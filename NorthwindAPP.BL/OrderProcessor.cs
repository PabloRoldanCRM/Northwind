using NorthwindAPP.DL;
using NorthwindAPP.ML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPP.BL
{
    public class OrderProcessor
    {
        private readonly IDapperr _dapper;
        public OrderProcessor(IDapperr dapper)
        {
            _dapper = dapper;
        }

        public async Task<List<Country>> GetCountries() {
            
            var result = await Task.FromResult(_dapper.GetAll<Country>($"sp_getAllCountries", null));
            return result;
        }

        public async Task<List<Customer>> GetCustomersByCountry(string countryName)
        {
            Dapper.DynamicParameters sp_params = new Dapper.DynamicParameters();
            sp_params.Add("@countryName", countryName, DbType.String, ParameterDirection.Input);
            var result = await Task.FromResult(_dapper.GetAll<Customer>($"sp_getCustomerByCountryName", sp_params));
            return result;
        }

        public async Task<List<Order>> GetOrderByCustomer(string customerId)
        {
            Dapper.DynamicParameters sp_params = new Dapper.DynamicParameters();
            sp_params.Add("@customerID", customerId, DbType.String, ParameterDirection.Input);
            var result = await Task.FromResult(_dapper.GetAll<Order>($"sp_getOrdersByCustomer", sp_params));
            return result;
        }

    }
}
