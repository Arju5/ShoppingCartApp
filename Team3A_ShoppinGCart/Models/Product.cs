using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models
{
    public class Product
    {

        [MaxLength(36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ProductId { get; set; }

        [Required]
        [MaxLength(64)]
        public string ProductName { get; set; }

        [MaxLength(128)]
        public string ProductDescription { get; set; }

        public double ProductPrice { get; set; }

        [MaxLength(128)]
        public string ImageURL { get; set; }

        [MaxLength(36)]
        public string ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
