using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models
{
    public class UserCart
    {

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public double subTotal { get; set; }
        public string ProductDescription { get; set; }

        public virtual User User { get; set; }
    }
}
