using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPP.ML
{
    public class Order
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }
        [Display(Name = "Customer")]
        public string CustomerID { get; set; }
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Required Date")]
        public DateTime RequiredDate { get; set; }
        [Display(Name = "ShipCity")]
        public string ShipCity { get; set; }
        [Display(Name = "Freight")]
        public float Freight { get; set; }
    }
}
