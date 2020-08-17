using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models
{
    public class Cart_Model
    {
        public string CartId { get; set; }
        public string ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string ImageURL { get; set; }
        public string ProductTypeName { get; set; }

        public double subTotal { get; set; }
    }
}
