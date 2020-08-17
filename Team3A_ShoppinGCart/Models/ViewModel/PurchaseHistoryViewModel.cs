using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models.ViewModel
{
    public class PurchaseHistoryViewModel
    {
        public string  ProductId { get; set; }
        public string  OrderId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string ProductUrl { get; set; }
        public int Quantity { get; set; }
        public string Orderdate { get; set; }
        public List<string> ActivationCodeId { get; set; }
    }
}
