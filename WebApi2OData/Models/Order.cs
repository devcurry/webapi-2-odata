using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2OData.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string BillingAddress { get; set; }
        public virtual IList<OrderDetails> OrderItems { get; set; }
    }
}