using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models
{
    public class ProductType
    {
        [MaxLength(36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ProductTypeId { get; set; }

        [Required]
        [MaxLength(64)]
        public string ProductTypeName { get; set; }
    }
}
