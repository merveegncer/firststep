using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("cart")]
    public partial class Cart
    {
        [Key]
        [Column("cart_id")]
        public int CartId { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Column("product_id")]
        public int? ProductId { get; set; }
        [Column("amount")]
        public int? Amount { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Carts")]
        public virtual Product? Product { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Carts")]
        public virtual User? User { get; set; }
    }
}
