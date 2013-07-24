using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApi2OData.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
