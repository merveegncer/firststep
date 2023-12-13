using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("products")]
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Favorites = new HashSet<Favorite>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string? Name { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("category_id")]
        public int? CategoryId { get; set; }
        [Column("gender_id")]
        public int? GenderId { get; set; }
        [Column("price", TypeName = "decimal(10, 2)")]
        public decimal? Price { get; set; }
        [Column("stock")]
        public int? Stock { get; set; }
        [Column("image")]
        [StringLength(255)]
        public string? Image { get; set; }
        [Column("number")]
        [StringLength(50)]
        public string? Number { get; set; }
        [Column("color")]
        [StringLength(50)]
        public string? Color { get; set; }
        [Column("date", TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("is_home")]
        public int? IsHome { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category? Category { get; set; }
        [ForeignKey(nameof(GenderId))]
        [InverseProperty("Products")]
        public virtual Gender? Gender { get; set; }
        [InverseProperty(nameof(Cart.Product))]
        public virtual ICollection<Cart> Carts { get; set; }
        [InverseProperty(nameof(Favorite.Product))]
        public virtual ICollection<Favorite> Favorites { get; set; }
        [InverseProperty(nameof(OrderDetail.Product))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
