using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2OData.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}