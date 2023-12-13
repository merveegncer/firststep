using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("users")]
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Favorites = new HashSet<Favorite>();
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("full_name")]
        [StringLength(100)]
        public string? FullName { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }
        [Column("password")]
        [StringLength(50)]
        public string? Password { get; set; }
        [Column("address")]
        [StringLength(255)]
        public string? Address { get; set; }
        [Column("phone")]
        [StringLength(20)]
        public string? Phone { get; set; }
        [Column("is_admin")]
        public int? IsAdmin { get; set; }

        [InverseProperty(nameof(Cart.User))]
        public virtual ICollection<Cart> Carts { get; set; }
        [InverseProperty(nameof(Favorite.User))]
        public virtual ICollection<Favorite> Favorites { get; set; }
        [InverseProperty(nameof(Order.User))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
