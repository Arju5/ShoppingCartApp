using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppinG_Cart.Models
{
    public class User
    {
        [MaxLength(36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserId { get; set; }

        [Required]
        [MaxLength(64)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(64)]
        public string Password { get; set; }

        [MaxLength(64)]
        public string FullName { get; set; }

        [MaxLength(36)]
        public string SessionId { get; set; }

        [MaxLength(64)]
        public string SessionData { get; set; }

    }
}
