using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDatabase.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal PurchaseAmount { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }
}