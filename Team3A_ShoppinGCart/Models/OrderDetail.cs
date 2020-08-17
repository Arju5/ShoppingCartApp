using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShoppinG_Cart.Models
{
    public class OrderDetail
    {
        [MaxLength(36)]
        public string OrderId { get; set; }

        [MaxLength(36)]
        public string ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
