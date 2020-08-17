using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models
{
    public class Order
    {
        [MaxLength(36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string OrderId { get; set; }

        [MaxLength(36)]
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }

        public Double TotalPrice { get; set; }
    }
}
