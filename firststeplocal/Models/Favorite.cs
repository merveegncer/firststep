using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("favorites")]
    public partial class Favorite
    {
        [Key]
        [Column("favorite_id")]
        public int FavoriteId { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Column("product_id")]
        public int? ProductId { get; set; }
        [Column("date", TypeName = "date")]
        public DateTime? Date { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Favorites")]
        public virtual Product? Product { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Favorites")]
        public virtual User? User { get; set; }
    }
}
