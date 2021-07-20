using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPP.BL;
using NorthwindAPP.DL;

namespace NorthwindAPP.Controllers
{
    public class OrderController : Controller
    {
        OrderProcessor _orderProcessor;
        public OrderController(IDapperr dapperr2)
        {
            _orderProcessor = new OrderProcessor(dapperr2);
        }
        public async Task<IActionResult> GetCountries()
        {
            var result = await _orderProcessor.GetCountries();
            return View(result);
        }

        public async Task<IActionResult> GetCustomersByCountry(string countryName)
        {
            var result = await _orderProcessor.GetCustomersByCountry(countryName);
            return View(result);
        }

        public async Task<IActionResult> GetOrderByCustomer(string customerId)
        {
            var result = await _orderProcessor.GetOrderByCustomer(customerId);
            return View(result);
        }

    }
}