using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models
{
    public class ActivationCode
    {

        [MaxLength(36)]
        public string OrderId { get; set; }

        [MaxLength(64)]
        public string ActivationCodeId { get; set; }

        [MaxLength(36)]
        public string ProductId { get; set; }


    }
}
